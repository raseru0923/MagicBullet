using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

public class Item : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;
    [SerializeField] private f_Label ItemLabel;

    [SerializeField] private GameMaster GameMaster;
    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;
    /// <summary>
    /// �E��ꂽ���Ă΂��
    /// </summary>
    public async UniTask PickUp()
    {
        print("�E��ꂽ�I");
        this.tag = "Untagged";

        var myItem = await GameMaster.AssessmentDiceRoll(ItemManager.ItemData[ItemIndex]);

        if ((int)myItem.Comprehension >= 2)
        {
            myItem.canAssessment = true;
        }

        GameObject.Find("Bag").GetComponent<Bag>().Content.Add(myItem);

        onPickUp.Invoke();
    }
}
