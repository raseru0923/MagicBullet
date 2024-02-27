using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_Bag : MonoBehaviour
{
    // Š“‚Ì’†g
    public f_ObjectItem[] Content;
    private f_ItemList itemList;
    [SerializeField] private GameObject List;

    public void OpenBag()
    {
        StartCoroutine(CreateItemList());
    }

    IEnumerator CreateItemList()
    {
        List.SetActive(true);
        yield return null;
        itemList = List.GetComponent<f_ItemList>();
        itemList.Subject.text = "“¹‹ï";
        itemList.SetContent(Content);
    }
}
