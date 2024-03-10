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

    [Header("アイテムが拾われた時のイベント")]
    public UnityEvent onPickUp;

    private void Start()
    {
        this.tag = "Item";
    }

    /// <summary>
    /// 拾われた時呼ばれる
    /// </summary>
    public async UniTask PickUp()
    {
        print("拾われた！");
        this.tag = "Untagged";

        ObjectItem item = ItemManager.ItemData[ItemIndex];

        var myItem = await GameMaster.Instance.AssessmentDiceRoll(item, item.SkillSprite.name);

        // 理解度が低いとき鑑定のチャンスが与えられる
        if ((int)myItem.Comprehension >= 2)
        {
            myItem.canAssessment = true;
        }

        GameObject.Find("Bag").GetComponent<Bag>().Content.Add(myItem);
        onPickUp.Invoke();
    }
}

