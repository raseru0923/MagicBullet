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
    [Header("�䎌��")]
    [TextArea] public string word = null;
    [Header("BGM��")]
    public AudioClip BGM;
    [Header("�L�����N�^�[�̃��Z�b�g��")]
    public bool IsReset = false;
    [Header("�L�����N�^�[�̓�����")]
    public CharacterOperation[] characterOperations = null;
}

[System.Serializable]
public class CharacterOperation
{
    // ����Ώ�
    public enum OPERATIONTARGET
    {
        FIRST,
        SECOND
    }

    [Header("����Ώہ�")]
    public OPERATIONTARGET Target;
    [Header("�s������̎�ށ�")]
    public ENTRYPOINTOPERATIONTYPE Type = ENTRYPOINTOPERATIONTYPE.JOINT;
    [Header("�u���b�N�A�E�g���쎞�g�p")]
    public bool IsBlackOut = false;
    [Header("�W���C���g���쎞�A\n"
        + "�Z�b�g���������g�p\n"
        + "(�����Z�b�g���AImage�D��)")]
    public Image JointImage;
    public Sprite JointSprite;
}
