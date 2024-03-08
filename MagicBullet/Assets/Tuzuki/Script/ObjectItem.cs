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
    [Header("���O��")]
    public string Name;
    [Header("�{�́�")]
    public GameObject ItemBody;
    [Header("��ށ�")]
    public string Type;
    [Header("�g�p����Z�\�̕\����")]
    public Sprite SkillSprite;
    [Header("�N���e�B�J������")]
    [SerializeField, TextArea] public string[] CliticalText;
    [Header("��������")]
    [SerializeField, TextArea] public string[] SuccessText;
    [Header("���s����")]
    [SerializeField, TextArea] public string[] FailText;
    [Header("�t�@���u������")]
    [SerializeField, TextArea] public string[] FambleText;
    [Header("�t���[�o�[�e�L�X�g��")]
    [SerializeField, TextArea] public string[] FlavorText;
    // �Ӓ���g�p�\���ǂ���
    [System.NonSerialized] public bool canAssessment = false;
    
    //����x
    [System.NonSerialized] public COMPREHENSION Comprehension = COMPREHENSION.NUM;
    List<string> AssesmentText = new List<string>();

    private void SetAssesmentText()
    {
        AssesmentText.Clear();
        AssesmentText.Add("�N���e�B�J���I\n" + CliticalText);
        AssesmentText.Add("�����I\n" + SuccessText);
        AssesmentText.Add("���s�I\n" + FailText);
        AssesmentText.Add("�t�@���u���I\n" + FambleText);
    }
    //�A�C�e�����Ӓ肵�ď���ԋp
    public string[] AssesmentItem()
    {
        SetAssesmentText();
        switch (Comprehension)
        {
            case COMPREHENSION.DETAIL:
                return CliticalText;
            case COMPREHENSION.NOMAL:
                return SuccessText;
            case COMPREHENSION.ABOUT:
                return FailText;
            case COMPREHENSION.NONE:
                return FambleText;
            case COMPREHENSION.NUM:
                break;
            default:
                break;
        }
        return null;
    }
}
