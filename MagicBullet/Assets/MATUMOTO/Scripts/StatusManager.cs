using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour, IContentNames
{
    //基本ステータス
    public int STR;  //筋力
    public int CON;  //体力
    public int POW;  //精神力
    public int DEX;  //敏捷性
    public int APP;  //外見
    public int SIZ;  //体格
    public int INT;  //知性
    public int EDU;  //教育

    public int SAN;         //正気度
    public int Luck;        //幸運
    public int Idea;        //アイデア
    public int Memory;      //知識
    public int Durability;  //耐久力
    public int MgcP;        //マジックポイント
    public int WorkP;       //職業技能ポイント
    public int HobbyP;      //趣味技能ポイント
    public int DamagePCheck;
    public int DamageP;     //ダメージポイント

    //戦闘技能ステータス
    public int Kaihi;
    public int Kikku = 25;
    public int Kumitsuki = 25;
    public int Kobushi = 50;
    public int Zutsuki = 10;
    public int Toteki = 25;
    public int MSA = 1;         //マーシャルアーツ
    public int Kenzyu = 20;
    public int SMG = 15;         //サブマシンガン
    public int SG = 30;          //ショットガン
    public int MG = 15;          //マシンガン
    public int R = 25;            //ライフル

    //探索技能ステータス
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

    //行動技能ステータス
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

    //交渉技能ステータス
    public int Iikurume = 5;
    public int Shinyou = 15;
    public int Settoku = 15;
    public int Negiri = 5;
    public int Bokokugo = 90;

    //知識技能ステータス
    public int Igaku = 5;
    public int Okaruto = 5;
    public int Kagaku = 1;
    public int Shinwa = 0;          //クトゥルフ神話
    public int Gezyutsu = 5;
    public int Keiri = 10;
    public int Kokogaku = 1;
    public int PC = 1;              //コンピュータ
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
    public int Konmaigo = 80;       //ニート専用

    //職業選択
    public int ChoiceProfession;

    public bool OpenChoicePnal = false;

    public bool DecisionworkP = false;
    public bool DecisionhobbyP = false;

    // 技能名から技能値を取得
    public Dictionary<string, int> SkillParameter = new Dictionary<string, int>();

    // インスタンス
    public static StatusManager Instance;

    // 技能の名前
    string[] SkillNames = { "回避","キック","組みつき","拳","頭突き","投てき","マーシャルアーツ","拳銃","サブマシンガン","ショットガン","マシンガン","ライフル",
                           "応急手当","鍵開け","隠す","隠れる","聞き耳","忍び歩き","写真術","精神分析","追跡","登攀","図書館","目星",
                           "運転","機械修理","重機械操作","乗馬","水泳","制作","操縦","跳躍","電気修理","ナビゲート","変装",
                           "言いくるめ","信用","説得","値切り","母国語",
                           "医学","オカルト","神話","芸術","経理","考古学","PC","心理学","人類学","生物学","地質学","電子工学","天文学","博物学","物理学","法律","薬学","歴史"};

    // 閲覧モード
    public enum ShowMode
    {
        ATTACK = 12,
        SKILL = 58
    }

    // 選択されているモード
    public ShowMode ChoiceMode = ShowMode.ATTACK;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;

            foreach (var item in SkillNames)
            {
                SkillParameter.Add(item, 1);
            }

            return;
        }
        Destroy(this);
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

    public List<string> GetNames()
    {
        var names = new List<string>();


        switch (ChoiceMode)
        {
            case ShowMode.ATTACK:
                ShowNames(names, 1, (int)ShowMode.ATTACK);
                break;
            case ShowMode.SKILL:
                ShowNames(names, (int)ShowMode.ATTACK, (int)ShowMode.SKILL);
                break;
            default:
                break;
        }

        return names;
    }

    private void ShowNames(List<string> names, int InitializeValue, int endValue)
    {
        int i = 0;
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
    }
}
