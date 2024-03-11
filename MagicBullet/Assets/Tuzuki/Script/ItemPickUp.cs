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
    /// ItemPickUp�Ƀo�C���h����Ă���{�^���������ꂽ��Ă΂��
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
            // �E��
            if (item.GetComponent<Item>() != null)
            {
                await item.GetComponent<Item>().PickUp();
                Item = null;
                return;
            }
            // �g�p
            if (item.GetComponent<ItemUse>() != null)
            {
                await item.GetComponent<ItemUse>().UseItem();
                Item = null;
                return;
            }
            // ����
            if (item.GetComponent<DescriptionMessage>() != null)
            {
                await item.GetComponent<DescriptionMessage>().PlayMessage();
                Item = null;
            }
        }
    }
}