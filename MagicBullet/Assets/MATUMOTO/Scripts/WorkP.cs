using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkP : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(StatusManager.Instance.DecisionworkP)
        this.gameObject.GetComponent<Text>().text = StatusManager.Instance.WorkP.ToString();
    }
}
