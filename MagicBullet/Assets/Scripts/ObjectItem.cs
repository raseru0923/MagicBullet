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
    [Header("���O��")]
    public string Name;
    [Header("�{�́�")]
    public GameObject ItemBody;
    [Header("��ށ�")]
    public string Type;
    [Header("�t���[�o�[�e�L�X�g��")]
    [SerializeField, TextArea] public string FlavorText;
    // ����x
    [System.NonSerialized] public COMPREHENSION Comprehension = COMPREHENSION.ABOUT;
    List<string> AssesmentText = new List<string>();

    private void SetAssesmentText()
    {
        AssesmentText.Clear();
        AssesmentText.Add(Name + "���E�����B\n" + FlavorText);
        AssesmentText.Add(Name + "���E�����B");
        AssesmentText.Add(Type + "���E�����B");
    }

    // �A�C�e�����Ӓ肵�ď���ԋp
    public string AssesmentItem()
    {
        SetAssesmentText();
        return AssesmentText[(int)Comprehension];
    }
}
