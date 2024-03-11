using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class ItemUse : MonoBehaviour, IConfirm
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;

    [Header("アイテムが拾われた時のイベント")]
    public UnityEvent onPickUp;
    public UnityEvent onUseItem;
    public ConfirmButton confirmButton;

    private bool isUse;

    [SerializeField] private AudioClip GunReportClip;
    private AudioSource audioSource;

    private void OnEnable()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        this.tag = "Item";
    }

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
            var myItem = ItemManager.ItemData[ItemIndex];
            var useSkillName = myItem.SkillSprite.name;
            await GameMaster.Instance.informationLabel.PlayLabelTask(useSkillName);
            await GameMaster.Instance.HundredDiceRoll(StatusManager.Instance.SkillParameter[useSkillName]);
            GameMaster.Instance.Moderate("特に何もないようだ");
            Cursor.lockState = CursorLockMode.Locked;
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
            audioSource.PlayOneShot(GunReportClip);
            GameMaster.Instance.Moderate(AssessmentName() + "を使用しました。");
            var bag = GameObject.Find("Bag").GetComponent<Bag>();
            bag.Content.Remove(ItemManager.ItemData[ItemIndex]);
            GameMaster.Instance.GimmickClear();
            onUseItem.Invoke();
            Cursor.lockState = CursorLockMode.Locked;
            this.enabled = false;
        }
        if (this.tag == "Untagged" && !confirmButton.GetButtonActive())
        {
            Cursor.lockState = CursorLockMode.Locked;
            this.tag = "Item";
        }
    }

    public void SetConfirm(bool isAgree)
    {
        isUse = isAgree;
    }
}
