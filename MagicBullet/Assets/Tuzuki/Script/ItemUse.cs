using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

public class ItemUse : MonoBehaviour, IConfirm
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;

    [Header("アイテムが拾われた時のイベント")]
    public UnityEvent onPickUp;
    public ConfirmButton confirmButton;

    private bool isUse;

    /// <summary>
    /// 使用するときに呼ばれる
    /// </summary>
    public async UniTask UseItem()
    {
        print("使用！");

        // 使用する処理を追加

        // 仕様武器を所持しているかチェック
        bool isHave = false;

        Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
        foreach (var item in bag.Content)
        {
            if (item == ItemManager.ItemData[ItemIndex])
            {
                isHave = true;
            }
        }
        if (!isHave)
        {
            await GameMaster.Instance.HundredDiceRoll(100);
            GameMaster.Instance.Moderate("特に何もないようだ");
            return;
        }

        // 使用するか質問
        GameMaster.Instance.Moderate(AssessmentName() + "を使用しますか？");

        confirmButton.OnButton(this.GetComponent<IConfirm>());

        onPickUp.Invoke();
    }

    private string AssessmentName()
    {
        string itemName;
        if ((int)ItemManager.ItemData[ItemIndex].Comprehension < 2)
        {
            itemName = ItemManager.ItemData[ItemIndex].Name;
            return itemName;
        }
        itemName = ItemManager.ItemData[ItemIndex].Type;
        return itemName;
    }

    private async void Update()
    {
        if (isUse)
        {
            isUse = false;
            GameMaster.Instance.Moderate(AssessmentName() + "を使用しました。");
            this.tag = "Untagged";
        }
    }

    public void SetConfirm(bool isAgree)
    {
        isUse = isAgree;
    }
}
