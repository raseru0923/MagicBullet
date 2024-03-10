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
        foreach (var item in StatusManager.Instance.SkillParameter.Keys)
        {
            if (item == Label.text)
            {

                StatusManager.Instance.SetMode(58);
                foreach (var skillItem in StatusManager.Instance.GetNames())
                {
                    // �g�p�Z�\���U���Z�\�łȂ��Ƃ��͏I��
                    if (skillItem == item && skillItem != "���}�蓖") { GameMaster.Instance.Moderate("�g�p���Ă��Ӗ��͂Ȃ��������B"); return; }
                }
                Debug.Log("�I�����܂����I");
                if (GameMaster.Instance.currentBattlePlayer != null)
                {
                    GameMaster.Instance.currentBattlePlayer.ActionEnter(Label.text);
                    return;
                }
            }
        }
    }
}
