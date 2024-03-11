using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour, IContentNames
{
    // 中身
    public List<ObjectItem> Content = new List<ObjectItem>();
    // 表示リスト
    [SerializeField] private GameObject myList;

    public void CallInventory()
    {
        if (myList.activeSelf)
        {
            myList.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            GameMaster.Instance.PlayerRelease();
            return;
        }

        Cursor.lockState =  CursorLockMode.None;
        GameMaster.Instance.PlayerLocked();

        myList.SetActive(true);

        ContentList list = myList.GetComponent<ContentList>();

        list.PrintList(this);
    }

    public bool IsOpenInventory()
    {
        return myList.activeSelf;
    }

    public List<string> GetNames()
    {
        var names = new List<string>();
        foreach (var item in Content)
        {
            names.Add(item.Name);
        }
        return names;
    }
}
