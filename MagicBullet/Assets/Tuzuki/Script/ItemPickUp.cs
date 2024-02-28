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
            await item.GetComponent<Item>().PickUp();
        }
        Debug.Log("null");
    }
}