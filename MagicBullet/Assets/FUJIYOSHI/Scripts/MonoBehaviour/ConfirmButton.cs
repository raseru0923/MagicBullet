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

    public void TargetBooleanTrue()
    {
        targetObject.SetConfirm(true);
        OffButton();
    }

    public void OffButton()
    {
        foreach (var item in Buttons)
        {
            Cursor.lockState = CursorLockMode.Locked;
            item.SetActive(false);
        }
    }

    public bool GetButtonActive()
    {
        return Buttons[0].activeSelf;
    }

    private void Update()
    {
        if (GetButtonActive() && Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
