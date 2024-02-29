using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmButton : MonoBehaviour
{
    [SerializeField] GameObject[] Buttons;
    ItemNode targetNode;


    public void OnButton(ItemNode target)
    {
        targetNode = target;

        foreach (var item in Buttons)
        {
            item.SetActive(true);
        }
    }

    public void targetAssessment()
    {
        targetNode.isAssessment = true;
        OffButton();
    }

    public void OffButton()
    {
        foreach (var item in Buttons)
        {
            item.SetActive(false);
        }
    }
}
