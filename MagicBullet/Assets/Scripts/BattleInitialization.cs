using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleInitialization : MonoBehaviour
{
    [SerializeField] private GameObject BattleDisplay;
    // Start is called before the first frame update
    void Start()
    {
        BattleDisplay.GetComponent<ImageAnimation>().StartAniamtion();
    }
}
