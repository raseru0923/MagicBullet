using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;


public class ItemNode : MonoBehaviour, IConfirm
{
    [SerializeField] Text myText;
    public bool isAssessment = false;
    int ItemIndex = 0;
    // �Q�Ƃ��Ă����o�b�O
    private Bag ReferencedBag;

    private GameMaster gameMaster;

    private void OnEnable()
    {
        gameMaster = GameMaster.Instance;
    }

    public void SetItem(Bag bag, int itemIndex)
    {
        ReferencedBag = bag;
        ItemIndex = itemIndex;
        ObjectItem myItem = bag.Content[ItemIndex];

        // ���sor�t�@���u�����̗���x
        if ((int)myItem.Comprehension >= 2)
        {
            myText.text = myItem.Type;
            return;
        }
        myText.text = myItem.Name;
    }

    public void ConfirmButton()
    {
        ObjectItem myItem = ReferencedBag.Content[ItemIndex];
        if (myItem.canAssessment)
        {
            GameObject.Find("ConfirmButton").GetComponent<ConfirmButton>().OnButton(this.GetComponent<IConfirm>());
            gameMaster.Moderate("�Ӓ���s���܂����H");
            return;
        }

        if (myItem.ReplaceFlavorText.Length != 0)
        {
            gameMaster.Moderate(myItem.ReplaceFlavorText);
            return;
        }

        if ((int)myItem.Comprehension < 2)
        {
            gameMaster.Moderate(myItem.Name + "���B");
            return;
        }

        gameMaster.Moderate(myItem.Type + "���B");
    }

    async void Update()
    {
        if (isAssessment)
        {
            isAssessment = false;
            await AssessmentItem();
        }
    }

    public void SetConfirm(bool isAgree)
    {
        isAssessment = isAgree;
    }

    private async UniTask AssessmentItem()
    {
        Debug.Log("�Ӓ�");

        ObjectItem myItem = ReferencedBag.Content[ItemIndex];

        // �Ӓ�g�p�s�\
        if (!myItem.canAssessment)
        {
            return;
        }

        // �A�C�e���̊Ӓ�
        string useSkill = GetUseAssessmentSkill(myItem);
        myItem = await gameMaster.AssessmentDiceRoll(myItem, useSkill);

        ReferencedBag.Content[ItemIndex] = myItem;

        SetItem(ReferencedBag, ItemIndex);

        myItem.canAssessment = false;
    }

    private static string GetUseAssessmentSkill(ObjectItem myItem)
    {
        string useSkill = myItem.AssessmentSkill;
        if (useSkill.Length == 0)
        {
            useSkill = myItem.SkillSprite.name;
        }

        return useSkill;
    }

    public void SelectItem()
    {
        Debug.Log("�I���I");
        var selectItem = ReferencedBag.Content[ItemIndex];
        gameMaster.SelectItem = selectItem;
        gameMaster.IsSelectItem = true;
    }
}
