using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    [SerializeField] private Text Label;

    public void SetLabel(string setText)
    {
        Label.text = setText;
    }

    public void Action()
    {
        Debug.Log("ëIëÇµÇ‹ÇµÇΩÅI");
        if (GameMaster.Instance.currentBattlePlayer != null)
        {
            GameMaster.Instance.currentBattlePlayer.ActionEnter(Label.text);
        }
    }
}
