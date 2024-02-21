using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COMPREHENSION
{
    DETAIL = 0,
    NORMAL,
    ABOUT,
    NUM
}

[System.Serializable]
public class ObjectItem
{
    [Header("名前▼")]
    public string Name;
    [Header("本体▼")]
    public GameObject ItemBody;
    [Header("種類▼")]
    public string Type;
    [Header("フレーバーテキスト▼")]
    [SerializeField, TextArea] public string FlavorText;
    // 理解度
    [System.NonSerialized] public COMPREHENSION Comprehension = COMPREHENSION.ABOUT;
    List<string> AssesmentText = new List<string>();

    private void SetAssesmentText()
    {
        AssesmentText.Clear();
        AssesmentText.Add(Name + "を拾った。\n" + FlavorText);
        AssesmentText.Add(Name + "を拾った。");
        AssesmentText.Add(Type + "を拾った。");
    }

    // アイテムを鑑定して情報を返却
    public string AssesmentItem()
    {
        SetAssesmentText();
        return AssesmentText[(int)Comprehension];
    }
}
