using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_Node : MonoBehaviour
{
    [SerializeField] private Text Label;

    public void SetLabel(string setText)
    {
        Label.text = setText;
    }

    public void Action()
    {
        Debug.Log("ëIëÇµÇ‹ÇµÇΩÅI");
    }
}
