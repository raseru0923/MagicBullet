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
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
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
        myItem = await gameMaster.AssessmentDiceRoll(myItem);

        ReferencedBag.Content[ItemIndex] = myItem;

        SetItem(ReferencedBag, ItemIndex);

        myItem.canAssessment = false;
    }
}
