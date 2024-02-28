using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;


public class ItemNode : MonoBehaviour
{
    [SerializeField] Text myText;
    private ObjectItem myItem;
    public bool isAssessment = false;
    int ItemIndex = 0;

    public void SetItem(ObjectItem item, int itemIndex)
    {
        myItem = item;
        ItemIndex = itemIndex;

        Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
        bag.Content[ItemIndex] = myItem;

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
        GameObject.Find("ConfirmButton").GetComponent<ConfirmButton>().OnButton(this);
    }

    async void Update()
    {
        if (isAssessment)
        {
            isAssessment = false;
            await AssessmentItem();
        }
    }

    private async UniTask AssessmentItem()
    {
        Debug.Log("�Ӓ�");
        // �Ӓ�g�p�s�\
        if (!myItem.canAssessment)
        {
            return;
        }

        GameMaster gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        // �A�C�e���̊Ӓ�
        myItem = await gameMaster.AssessmentDiceRoll(myItem);

        SetItem(myItem, ItemIndex);

        myItem.canAssessment = false;
    }
}
