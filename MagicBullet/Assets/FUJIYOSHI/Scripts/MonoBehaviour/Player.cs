using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���g�̃o�b�O
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
