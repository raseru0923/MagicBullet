using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_BattleInitialization : MonoBehaviour
{
    [SerializeField] private GameObject BattleDisplay;
    // Start is called before the first frame update
    void Start()
    {
        BattleDisplay.GetComponent<f_ImageAnimation>().StartAniamtion();
    }
}
