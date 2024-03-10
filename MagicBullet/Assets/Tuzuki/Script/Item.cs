using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class Item : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;

    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;

    private void Start()
    {
        this.tag = "Item";
    }

    /// <summary>
    /// �E��ꂽ���Ă΂��
    /// </summary>
    public async UniTask PickUp()
    {
        print("�E��ꂽ�I");
        this.tag = "Untagged";

        ObjectItem item = ItemManager.ItemData[ItemIndex];

        var myItem = await GameMaster.Instance.AssessmentDiceRoll(item, item.SkillSprite.name);

        // ����x���Ⴂ�Ƃ��Ӓ�̃`�����X���^������
        if ((int)myItem.Comprehension >= 2)
        {
            myItem.canAssessment = true;
        }

        GameObject.Find("Bag").GetComponent<Bag>().Content.Add(myItem);
        onPickUp.Invoke();
    }
}

