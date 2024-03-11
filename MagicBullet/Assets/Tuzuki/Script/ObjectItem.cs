using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COMPREHENSION
{
    DETAIL = 0,
    NOMAL,
    ABOUT,
    NONE,
    NUM
}

[System.Serializable]
public class ObjectItem
{
    [Header("名前▼")]
    [TextArea] public string Name;
    [Header("本体▼")]
    public GameObject ItemBody;
    [Header("アイテム画像▼")]
    public Sprite ItemImage;
    [Header("種類▼")]
    public string Type;
    [Header("拾得時アイテムを削除するか▼")]
    public bool isGetWithDestroy = false;
    [Header("拾得時技能を使用するか▼")]
    public bool isUsingSkill = true;
    [Header("拾得時の使用技能アイコン▼")]
    public Sprite SkillSprite;
    [Header("鑑定時の使用技能名▼")]
    public string AssessmentSkill;
    [Header("クリティカル時▼")]
    [SerializeField, TextArea] public string[] CliticalText;
    [Header("成功時▼")]
    [SerializeField, TextArea] public string[] SuccessText;
    [Header("失敗時▼")]
    [SerializeField, TextArea] public string[] FailText;
    [Header("ファンブル時▼")]
    [SerializeField, TextArea] public string[] FambleText;
    [Header("フレーバーテキスト▼")]
    [SerializeField, TextArea] private string[] FlavorText;
    // 鑑定を使用可能かどうか
    [System.NonSerialized] public bool canAssessment = false;

    //理解度
    [System.NonSerialized] public COMPREHENSION Comprehension = COMPREHENSION.DETAIL;
    List<string> AssesmentText = new List<string>();

    private void SetAssesmentText()
    {
        AssesmentText.Clear();
        AssesmentText.Add("クリティカル！\n" + CliticalText);
        AssesmentText.Add("成功！\n" + SuccessText);
        AssesmentText.Add("失敗！\n" + FailText);
        AssesmentText.Add("ファンブル！\n" + FambleText);
    }
    //アイテムを鑑定して情報を返却
    public string[] AssesmentItem()
    {
        SetAssesmentText();
        switch (Comprehension)
        {
            case COMPREHENSION.DETAIL:
                return KeyWordReplace(CliticalText);
            case COMPREHENSION.NOMAL:
                return KeyWordReplace(SuccessText);
            case COMPREHENSION.ABOUT:
                return KeyWordReplace(FailText);
            case COMPREHENSION.NONE:
                return KeyWordReplace(FambleText);
            case COMPREHENSION.NUM:
                break;
            default:
                break;
        }
        return null;
    }

    public string[] ReplaceFlavorText
    {
        get { return KeyWordReplace(FlavorText); }
    }

    private string[] KeyWordReplace(string[] targetText)
    {
        var replaceText = targetText;
        for (int i = 0; i < replaceText.Length; i++)
        {
            replaceText[i] = replaceText[i].Replace("@Name", Name);
            replaceText[i] = replaceText[i].Replace("@Type", Type);
        }
        return replaceText;
    }
}
