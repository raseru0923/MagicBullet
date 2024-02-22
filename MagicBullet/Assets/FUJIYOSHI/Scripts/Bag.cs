using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    // Š“‚Ì’†g
    public ObjectItem[] Content;
    private ItemList itemList;
    [SerializeField] private GameObject List;

    public void OpenBag()
    {
        StartCoroutine(CreateItemList());
    }

    IEnumerator CreateItemList()
    {
        List.SetActive(true);
        yield return null;
        itemList = List.GetComponent<ItemList>();
        itemList.Subject.text = "“¹‹ï";
        itemList.SetContent(Content);
    }
}
