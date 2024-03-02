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

    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;
    public ConfirmButton confirmButton;

    private bool isUse;

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
            await GameMaster.Instance.HundredDiceRoll(100);
            GameMaster.Instance.Moderate("���ɉ����Ȃ��悤��");
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
            GameMaster.Instance.Moderate(AssessmentName() + "���g�p���܂����B");
            this.tag = "Untagged";
        }
    }

    public void SetConfirm(bool isAgree)
    {
        isUse = isAgree;
    }
}
