using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    //��{�X�e�[�^�X
    public int STR;  //�ؗ�
    public int CON;  //�̗�
    public int POW;  //���_��
    public int DEX;  //�q����
    public int APP;  //�O��
    public int SIZ;  //�̊i
    public int INT;  //�m��
    public int EDU;  //����

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
    public int SMG = 15;         //�T�u�}�V���K��
    public int SG = 30;          //�V���b�g�K��
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

    public Dictionary<string, int> dic = new Dictionary<string, int>();

    public static StatusManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void StatusPoints()
    {
        SAN = POW * 5;
        Luck = POW * 5;
        Idea = INT * 5;
        Memory = EDU * 5;
        Durability = (CON + SIZ) / 2;
        MgcP = POW;
        WorkP = EDU * 20;
        HobbyP = INT * 10;
        DamagePCheck = STR + SIZ;
        Kaihi = DEX * 2;
    }
}
