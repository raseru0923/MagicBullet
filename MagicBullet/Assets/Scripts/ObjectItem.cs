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
    [Header("���O��")]
    public string Name;
    [Header("�{�́�")]
    public GameObject ItemBody;
    [Header("��ށ�")]
    public string Type;
    [Header("�t���[�o�[�e�L�X�g��")]
    [SerializeField, TextArea] public string FlavorText;
    // ����x
    [System.NonSerialized] public COMPREHENSION Comprehension;
}
