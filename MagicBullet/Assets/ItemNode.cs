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
    public bool isAssessment = false;
    int ItemIndex = 0;
    // 参照していたバッグ
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

        // 失敗orファンブル時の理解度
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
            GameObject.Find("ConfirmButton").GetComponent<ConfirmButton>().OnButton(this);
            gameMaster.PrintLog("鑑定を行いますか？");
            return;
        }

        if ((int)myItem.Comprehension < 2)
        {
            gameMaster.PrintLog(myItem.Name + "だ。");
            return;
        }

        gameMaster.PrintLog(myItem.Type + "だ。");
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
        Debug.Log("鑑定");

        ObjectItem myItem = ReferencedBag.Content[ItemIndex];

        // 鑑定使用不可能
        if (!myItem.canAssessment)
        {
            return;
        }

        // アイテムの鑑定
        myItem = await gameMaster.AssessmentDiceRoll(myItem);

        ReferencedBag.Content[ItemIndex] = myItem;

        SetItem(ReferencedBag, ItemIndex);

        myItem.canAssessment = false;
    }
}
