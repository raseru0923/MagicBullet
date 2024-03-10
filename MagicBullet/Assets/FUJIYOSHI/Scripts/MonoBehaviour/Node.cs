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
                    // 使用技能が攻撃技能でないときは終了
                    if (skillItem == item && skillItem != "応急手当") { GameMaster.Instance.Moderate("使用しても意味はなさそうだ。"); return; }
                }
                Debug.Log("選択しました！");
                if (GameMaster.Instance.currentBattlePlayer != null)
                {
                    GameMaster.Instance.currentBattlePlayer.ActionEnter(Label.text);
                    return;
                }
            }
        }
    }
}
