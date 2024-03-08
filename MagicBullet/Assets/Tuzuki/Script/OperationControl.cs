using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationControl : MonoBehaviour
{
    [SerializeField] private Operation operation;
    [SerializeField] Behaviour[] behaviours;

    private void OnEnable()
    {
        SetEnabled(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (operation.isOperation != behaviours[0].enabled)
        {
            SetEnabled(operation.isOperation);
        }
    }

    private void SetEnabled(bool isEnabled)
    {
        foreach (var item in behaviours)
        {
            item.enabled = isEnabled;
        }
    }
}
