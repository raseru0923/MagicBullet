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

    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
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
    /// �g�p����Ƃ��ɌĂ΂��
    /// </summary>
    public async UniTask UseItem()
    {
        print("�g�p�I");

        // �g�p���鏈����ǉ�

        // �d�l������������Ă��邩�`�F�b�N
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
            GameMaster.Instance.Moderate("���ɉ����Ȃ��悤��");
            Cursor.lockState = CursorLockMode.Locked;
            return;
        }

        // �g�p���邩����
        GameMaster.Instance.Moderate(AssessmentName() + "���g�p���܂����H");

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
            GameMaster.Instance.Moderate(AssessmentName() + "���g�p���܂����B");
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
