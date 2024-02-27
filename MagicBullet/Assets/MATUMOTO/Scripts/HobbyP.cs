using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HobbyP : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = StatusManager.instance.HobbyP.ToString();
    }
}
