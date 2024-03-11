using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableGimmick : MonoBehaviour
{
    // 選択中のカードをリスト形式で保存
    private List<string> SelectCardName = new List<string>();

    // 正解のカードの名前を保存
    [SerializeField] private List<string> GimmickPassCardName = new List<string>();

    // プレイヤー
    [SerializeField] private Player CurrentPlayer;

    // 開かずの扉
    [SerializeField] private Operation DoorOperation;

    private Coroutine SelectCoroutine = null;

    private Image SelectImage = null;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;

        var count = 4;

        SelectCardName.Clear();
        for (int i = 0; i < count; i++)
        {
            SelectCardName.Add(default);
        }
    }
    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void SetImage(Image selectImage)
    {
        SelectImage = selectImage;
    }

    public void SetCard(int CardPositionIndex)
    {
        if (SelectCoroutine != null)
        {
            StopCoroutine(SelectCoroutine);
            SelectCoroutine = null;
        }
        SelectCoroutine = StartCoroutine(SelectCard(CardPositionIndex));
    }
    public IEnumerator SelectCard(int CardPositionIndex)
    {
        // アイテム未選択状態にする
        GameMaster.Instance.IsSelectItem = false;

        GameMaster.Instance.Moderate("カードを選択してください！");
        // クリックされるまで待機
        while (!Input.GetMouseButtonDown(0)) { yield return null; }

        // 鞄を開く
        CurrentPlayer.MyBag.CallInventory();
        Cursor.lockState = CursorLockMode.None;

        // アイテムが選択されるまで待機。
        while (!GameMaster.Instance.IsSelectItem) { yield return null; }

        GameMaster.Instance.IsSelectItem = false;

        // 選択されたアイテムを取得
        var selectItem = GameMaster.Instance.SelectItem;

        if (selectItem.Type != "カード")
        {
            GameMaster.Instance.Moderate("カードを選択してください！");
            CurrentPlayer.MyBag.CallInventory();
            yield break;
        }

        // 既に使用されているとき再度選択待機
        foreach (var item in SelectCardName)
        {
            if (item == selectItem.Name)
            {
                GameMaster.Instance.Moderate("すでに使用されています！");
                CurrentPlayer.MyBag.CallInventory();
                yield break;
            }
        }
        // 鞄を閉じる
        CurrentPlayer.MyBag.CallInventory();
        Cursor.lockState = CursorLockMode.None;

        // アイテムの名前を設定
        SelectCardName[CardPositionIndex] = selectItem.Name;

        // アイテムの見た目を設定
        SelectImage.sprite = selectItem.ItemImage;

        // ギミック通過チェック
        var passCount = 0;

        // 正解したとき通過カウントをプラス1
        foreach (var item in GimmickPassCardName)
        {
            if (SelectCardName.Contains(item))
            {
                ++passCount;
                Debug.Log("通過！" + passCount);
            }
        }

        // 4枚ともすべてそろっているとき
        if (passCount >= 4)
        {
            var bag = GameObject.Find("Bag").GetComponent<Bag>();
            foreach (var item in bag.Content)
            {
                if ("カード" == item.Type)
                {
                    bag.Content.Remove(item);
                }
            }
            DoorOperation.isOperation = true;
            yield return null;
            while (!Input.GetMouseButtonDown(0)) { yield return null; }
            GameMaster.Instance.Moderate("どこかで鍵の開いた音がした！");
            // クリックされるまで待機
            while (!Input.GetMouseButtonDown(0)) { yield return null; }
        }
    }

}