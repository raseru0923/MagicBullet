using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmButton : MonoBehaviour
{
    [SerializeField] GameObject[] Buttons;
    IConfirm targetObject;


    public void OnButton(IConfirm target)
    {
        Cursor.lockState = CursorLockMode.None;

        targetObject = target;

        foreach (var item in Buttons)
        {
            item.SetActive(true);
        }
    }

    public void targetAssessment()
    {
        targetObject.SetConfirm(true);
        OffButton();
    }

    public void OffButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        foreach (var item in Buttons)
        {
            item.SetActive(false);
        }
    }
}
