using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cysharp.Threading.Tasks;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private ItemSearch itemSearch;
    private GameObject Item;
    /// <summary>
    /// ItemPickUpにバインドされているボタンが押されたら呼ばれる
    /// </summary>
    public async UniTask OnItemPickUp()
    {
        if (itemSearch != null)
        {
            var item = itemSearch.GetNearItem();
            if (item == null) { return; }
            if (item == Item) { item = null; return; }
            if (!item.CompareTag("Item")) { item = null; return; }

            Cursor.lockState = CursorLockMode.None;

            Item = item;
            Debug.Log(item);
            // 拾う
            if (item.GetComponent<Item>() != null)
            {
                await item.GetComponent<Item>().PickUp();
                Item = null;
                return;
            }
            // 使用
            if (item.GetComponent<ItemUse>() != null)
            {
                await item.GetComponent<ItemUse>().UseItem();
                Item = null;
                return;
            }
            // 説明
            if (item.GetComponent<DescriptionMessage>() != null)
            {
                await item.GetComponent<DescriptionMessage>().PlayMessage();
                Item = null;
            }
        }
    }
}