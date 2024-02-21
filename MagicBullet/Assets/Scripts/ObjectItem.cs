using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COMPREHENSION
{
    About = 0,
    Normal,
    Detail,
}

[System.Serializable]
public struct ObjectItem
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
    [System.NonSerialized] public COMPREHENSION Comprehension;
}
