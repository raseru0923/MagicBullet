using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour, IContentNames
{
    //��{�X�e�[�^�X
    public enum BasicStatusType
    {
        STR = 0,
        CON,
        POW,
        DEX,
        APP,
        SIZ,
        INT,
        EDU,
        NUM
    }


    [HideInInspector] public int[] BasicStatus = new int[(int)BasicStatusType.NUM]
    {
        10,
        10,
        10,
        10,
        10,
        10,
        10,
        10
    };

    public int SAN;         //���C�x
    public int Luck;        //�K�^
    public int Idea;        //�A�C�f�A
    public int Memory;      //�m��
    public int Durability;  //�ϋv��
    public int MgcP;        //�}�W�b�N�|�C���g
    public int WorkP;       //�E�ƋZ�\�|�C���g
    public int HobbyP;      //��Z�\�|�C���g
    public int DamagePCheck;
    public int DamageP;     //�_���[�W�|�C���g

    //�퓬�Z�\�X�e�[�^�X
    public int Kaihi;
    public int Kikku = 25;
    public int Kumitsuki = 25;
    public int Kobushi = 50;
    public int Zutsuki = 10;
    public int Toteki = 25;
    public int MSA = 1;         //�}�[�V�����A�[�c
    public int Kenzyu = 20;
    public int rl = 15;         //�T�u�}�V���K��
    public int PH = 30;          //�V���b�g�K��
    public int MG = 15;          //�}�V���K��
    public int R = 25;            //���C�t��

    //�T���Z�\�X�e�[�^�X
    public int Okyuteate = 30;
    public int Kagiake = 1;
    public int Kakusu = 15;
    public int Kakureru = 10;
    public int Kikimimi = 25;
    public int Shinobiaruki = 10;
    public int Syashinzyutsu = 10;
    public int Seshinbunseki = 1;
    public int Tsuiseki = 10;
    public int Touhan = 40;
    public int Tosyokan = 25;
    public int Meboshi = 25;

    //�s���Z�\�X�e�[�^�X
    public int Unten = 20;
    public int Kikaisyuri = 20;
    public int Zyukikaisosa = 1;
    public int Zyoba = 5;
    public int Suiei = 25;
    public int Sesaku = 5;
    public int Sozyu = 1;
    public int Tyoyaku = 25;
    public int Denkisyuri = 10;
    public int Nabigeto = 10;
    public int Hensou = 1;

    //���Z�\�X�e�[�^�X
    public int Iikurume = 5;
    public int Shinyou = 15;
    public int Settoku = 15;
    public int Negiri = 5;
    public int Bokokugo = 90;

    //�m���Z�\�X�e�[�^�X
    public int Igaku = 5;
    public int Okaruto = 5;
    public int Kagaku = 1;
    public int Shinwa = 0;          //�N�g�D���t�_�b
    public int Gezyutsu = 5;
    public int Keiri = 10;
    public int Kokogaku = 1;
    public int PC = 1;              //�R���s���[�^
    public int Shinrigaku = 5;
    public int Zinruigaku = 1;
    public int Seibutsugaku = 1;
    public int Tishitsugaku = 1;
    public int Denshikougaku = 1;
    public int Tenmongaku = 1;
    public int Hakubutsugaku = 10;
    public int Butsurigaku = 1;
    public int Houritsu = 5;
    public int Yakugaku = 1;
    public int Rekishi = 20;
    public int Konmaigo = 80;       //�j�[�g��p

    //�E�ƑI��
    public int ChoiceProfession;

    public bool OpenChoicePnal = false;

    public bool DecisionworkP = false;
    public bool DecisionhobbyP = false;

    // �Z�\������Z�\�l���擾
    public Dictionary<string, int> SkillParameter = new Dictionary<string, int>();

    // �C���X�^���X
    public static StatusManager Instance;

    // �Z�\�̖��O
    string[] SkillNames = { "���","�L�b�N","�g�݂�","��","���˂�","���Ă�","�}�[�V�����A�[�c","���e","���P�b�g�����`���[","P�n���h�K��","�}�V���K��","���C�t��",
                           "���}�蓖","���J��","�B��","�B���","������","�E�ѕ���","�ʐ^�p","���_����","�ǐ�","�o��","�}����","�ڐ�",
                           "�^�]","�@�B�C��","�d�@�B����","��n","���j","����","���c","����","�d�C�C��","�i�r�Q�[�g","�ϑ�",
                           "���������","�M�p","����","�l�؂�","�ꍑ��",
                           "��w","�I�J���g","�_�b","�|�p","�o��","�l�Êw","PC","�S���w","�l�ފw","�����w","�n���w","�d�q�H�w","�V���w","�����w","�����w","�@��","��w","���j"};

    // �{�����[�h
    public enum ShowMode
    {
        STATUS = 0,
        ATTACK = 12,
        SKILL = 58
    }

    // �I������Ă��郂�[�h
    public ShowMode ChoiceMode = ShowMode.ATTACK;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;

            if (SkillParameter.Count == 0)
            {
                foreach (var item in SkillNames)
                {
                    SkillParameter.Add(item, 1);
                }
            }

            return;
        }

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Status")
        {
            Destroy(Instance.gameObject);
            DontDestroyOnLoad(this);
            Instance = this;

            if (SkillParameter.Count == 0)
            {
                foreach (var item in SkillNames)
                {
                    SkillParameter.Add(item, 1);
                }
            }
            return;
        }

        Destroy(this.gameObject);
    }
    public void StatusPoints()
    {
        SAN = BasicStatusTypeValue(BasicStatusType.POW) * 5;
        Luck = BasicStatusTypeValue(BasicStatusType.POW) * 5;
        Idea = BasicStatusTypeValue(BasicStatusType.INT) * 5;
        Memory = BasicStatusTypeValue(BasicStatusType.EDU) * 5;
        Durability = (BasicStatusTypeValue(BasicStatusType.CON) + BasicStatusTypeValue(BasicStatusType.SIZ)) / 2;
        MgcP = BasicStatusTypeValue(BasicStatusType.POW);
        WorkP = BasicStatusTypeValue(BasicStatusType.EDU) * 20;
        HobbyP = BasicStatusTypeValue(BasicStatusType.INT) * 10;
        DamagePCheck = BasicStatusTypeValue(BasicStatusType.STR) + BasicStatusTypeValue(BasicStatusType.SIZ);
        Kaihi = BasicStatusTypeValue(BasicStatusType.DEX) * 2;
    }

    public int BasicStatusTypeValue(BasicStatusType basicStatusType)
    {
        return BasicStatus[(int)basicStatusType];
    }

    public List<string> GetNames()
    {
        var names = new List<string>();


        switch (ChoiceMode)
        {
            case ShowMode.STATUS:
                ShowNames(names, 0, (int)ChoiceMode);
                break;
            case ShowMode.ATTACK:
                ShowNames(names, 1, (int)ChoiceMode);
                break;
            case ShowMode.SKILL:
                ShowNames(names, (int)ShowMode.ATTACK, (int)ChoiceMode);
                break;
            default:
                break;
        }

        return names;
    }

    private void ShowNames(List<string> names, int InitializeValue, int endValue)
    {
        int i = 0;
        if (endValue == 0)
        {
            for (int j = 0; j < BasicStatus.Length; j++)
            {
                names.Add((BasicStatusType)j + " = " + BasicStatus[j].ToString());
            }

            foreach (var item in SkillParameter)
            {
                names.Add(item.Key + " = " + item.Value);
            }

            return;
        }

        foreach (var item in SkillParameter)
        {
            if (i >= endValue)
            {
                break;
            }

            if (i < InitializeValue)
            {
                ++i;
                continue;
            }
            names.Add(item.Key);
            ++i;
        }
    }

    public void SetMode(int mode)
    {
        ChoiceMode = (ShowMode)mode;
        StartCoroutine(SetList());
    }


    IEnumerator SetList()
    {
        while (GameObject.Find("List") == null)
        {
            yield return null;
        }

        GameObject.Find("List").GetComponent<f_List>().CreateList(this.gameObject);
        Debug.Log("Set");
    }
}
