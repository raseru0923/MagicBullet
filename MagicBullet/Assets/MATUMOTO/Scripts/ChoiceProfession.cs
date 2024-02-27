using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChoiceProfession : MonoBehaviour
{
    [SerializeField] GameObject ChoicePanel;
    [SerializeField] GameObject ProfessionPanel;
    [SerializeField] GameObject SkillPanel;
    void OnMouseOver()
    {
        ChoicePanel.SetActive(true);
        if ((Input.GetMouseButtonDown(0))&&(StatusManager.instance.OpenChoicePnal==false))
        {
            StatusManager.instance.OpenChoicePnal = true;
            ProfessionPanel.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        ChoicePanel.SetActive(false);
    }
    public void ClosePanel()
    {
        ProfessionPanel.SetActive(false);
        StatusManager.instance.OpenChoicePnal = false;
    }
    public void OpenSkillPanel()
    {
        SkillPanel.SetActive(true);
    }
    public void CloseSkillPanel()
    {
        SkillPanel.SetActive(false);
    }
}
