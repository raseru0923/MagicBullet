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
    [TextArea] public string Name;
    [Header("�{�́�")]
    public GameObject ItemBody;
    [Header("�A�C�e���摜��")]
    public Sprite ItemImage;
    [Header("��ށ�")]
    public string Type;
    [Header("�E�����A�C�e�����폜���邩��")]
    public bool isGetWithDestroy = false;
    [Header("�E�����Z�\���g�p���邩��")]
    public bool isUsingSkill = true;
    [Header("�E�����̎g�p�Z�\�A�C�R����")]
    public Sprite SkillSprite;
    [Header("�Ӓ莞�̎g�p�Z�\����")]
    public string AssessmentSkill;
    [Header("�N���e�B�J������")]
    [SerializeField, TextArea] public string[] CliticalText;
    [Header("��������")]
    [SerializeField, TextArea] public string[] SuccessText;
    [Header("���s����")]
    [SerializeField, TextArea] public string[] FailText;
    [Header("�t�@���u������")]
    [SerializeField, TextArea] public string[] FambleText;
    [Header("�t���[�o�[�e�L�X�g��")]
    [SerializeField, TextArea] private string[] FlavorText;
    // �Ӓ���g�p�\���ǂ���
    [System.NonSerialized] public bool canAssessment = false;

    //����x
    [System.NonSerialized] public COMPREHENSION Comprehension = COMPREHENSION.DETAIL;
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
