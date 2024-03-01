using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cysharp.Threading.Tasks;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private ItemSearch itemSearch;
    /// <summary>
    /// ItemPickUpにバインドされているボタンが押されたら呼ばれる
    /// </summary>
    public async UniTask OnItemPickUp()
    {
        if (itemSearch != null)
        {
            var item = itemSearch.GetNearItem();
            if (item == null) return;


            // 拾う
            if (item.GetComponent<Item>() != null)
            {
                await item.GetComponent<Item>().PickUp();
            }
            // 使用
            if (item.GetComponent<ItemUse>() != null)
            {
                await item.GetComponent<ItemUse>().UseItem();
            }
        }
    }
}