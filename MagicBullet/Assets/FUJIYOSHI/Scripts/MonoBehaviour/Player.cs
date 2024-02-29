using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 自身のバッグ
    [SerializeField] private Bag MyBag;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            MyBag.PrintInventory();
        }
    }
}
