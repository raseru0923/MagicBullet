using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    // 中身
    public List<ObjectItem> Content = new List<ObjectItem>();
    // 表示リスト
    [SerializeField] private GameObject myList;

    public void PrintInventory()
    {
        if (myList.activeSelf)
        {
            myList.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            return;
        }

        Cursor.lockState =  CursorLockMode.None;

        myList.SetActive(true);

        ContentList list = myList.GetComponent<ContentList>();

        list.PrintList(Content);
    }
}
