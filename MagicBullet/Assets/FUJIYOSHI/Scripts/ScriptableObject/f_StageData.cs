using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TalkData", menuName = "ScriptableObjects/TalkData")]
public class f_StageData : ScriptableObject
{
    public f_Scene[] Scenes;
}

[System.Serializable]
public class f_Scene
{
    [Header("台詞▼")]
    [TextArea] public string word = null;
    [Header("BGM▼")]
    public AudioClip BGM;
    [Header("キャラクターのリセット▼")]
    public bool IsReset = false;
    [Header("キャラクターの動き▼")]
    public CharacterOperation[] characterOperations = null;
}

[System.Serializable]
public class CharacterOperation
{
    // 操作対象
    public enum OPERATIONTARGET
    {
        FIRST,
        SECOND
    }

    [Header("操作対象▼")]
    public OPERATIONTARGET Target;
    [Header("行う操作の種類▼")]
    public ENTRYPOINTOPERATIONTYPE Type = ENTRYPOINTOPERATIONTYPE.JOINT;
    [Header("ブラックアウト操作時使用")]
    public bool IsBlackOut = false;
    [Header("ジョイント操作時、\n"
        + "セットした方を使用\n"
        + "(両方セット時、Image優先)")]
    public Image JointImage;
    public Sprite JointSprite;
}
