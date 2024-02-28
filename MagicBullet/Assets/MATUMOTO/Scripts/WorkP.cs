using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkP : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(StatusManager.instance.DecisionworkP)
        this.gameObject.GetComponent<Text>().text = StatusManager.instance.WorkP.ToString();
    }
}
