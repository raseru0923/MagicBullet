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

        if (item.isUsingSkill)
        {
            var result = await GameMaster.Instance.AssessmentDiceRoll(item, item.SkillSprite.name);
            item = result;
        }
        else
        {
            foreach (var content in item.AssesmentItem())
            {
                await UniTask.Yield(PlayerLoopTiming.Update);

                GameMaster.Instance.informationLabel.PlayLabel(content);

                while (!Input.GetMouseButtonDown(0))
                {
                    await UniTask.Yield(PlayerLoopTiming.Update);
                }
            }
        }

        // ����x���Ⴂ�Ƃ��Ӓ�̃`�����X���^������
        if ((int)item.Comprehension >= 2)
        {
            item.canAssessment = true;
        }

        GameObject.Find("Bag").GetComponent<Bag>().Content.Add(item);
        Cursor.lockState = CursorLockMode.Locked;
        onPickUp.Invoke();
        if (item.isGetWithDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}

