using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public AudioClip StatusSound;
    AudioSource audioSource;

    public GameObject DiceButton;
    public GameObject NextButton;
    public GameObject StatusReturnButton;
    public GameObject StatusPanel;
    public GameObject ProfessionPanel;
    public GameObject BattlePanel;
    public GameObject SearchPanel;
    public GameObject ActionPanel;
    public GameObject TalkPanel;
    public GameObject BrainPanel;
    public GameObject DecisionPanel;
    public GameObject SkillCheckerPanel;

    //戦闘技能ステータス
    public InputField InputWorkPKaihi;
    public InputField InputHobbyPKaihi;
    public InputField InputWorkPKikku;
    public InputField InputHobbyPKikku;
    public InputField InputWorkPKumitsuki;
    public InputField InputHobbyPKumitsuki;
    public InputField InputWorkPKobushi;
    public InputField InputHobbyPKobushi;
    public InputField InputWorkPZutsuki;
    public InputField InputHobbyPZutsuki;
    public InputField InputWorkPToteki;
    public InputField InputHobbyPToteki;
    public InputField InputWorkPMSA;
    public InputField InputHobbyPMSA;
    public InputField InputWorkPKenzyu;
    public InputField InputHobbyPKenzyu;
    public InputField InputWorkPSMG;
    public InputField InputHobbyPSMG;
    public InputField InputWorkPSG;
    public InputField InputHobbyPSG;
    public InputField InputWorkPMG;
    public InputField InputHobbyPMG;
    public InputField InputWorkPR;
    public InputField InputHobbyPR;

    public GameObject workKaihi;
    public GameObject workKikku;
    public GameObject workKumitsuki;
    public GameObject workKobushi;
    public GameObject workZutsuki;
    public GameObject workToteki;
    public GameObject workMSA;
    public GameObject workKenzyu;
    public GameObject workSMG;
    public GameObject workSG;
    public GameObject workMG;
    public GameObject workR;

    //探索技能ステータス
    public InputField InputWorkPOkyuteate;
    public InputField InputHobbyPOkyuteate;
    public InputField InputWorkPKagiake;
    public InputField InputHobbyPKagiake;
    public InputField InputWorkPKakusu;
    public InputField InputHobbyPKakusu;
    public InputField InputWorkPKakureru;
    public InputField InputHobbyPKakureru;
    public InputField InputWorkPKikimimi;
    public InputField InputHobbyPKikimimi;
    public InputField InputWorkPShinobiaruki;
    public InputField InputHobbyPShinobiaruki;
    public InputField InputWorkPSyashinzyutsu;
    public InputField InputHobbyPSyashinzyutsu;
    public InputField InputWorkPSeshinbunseki;
    public InputField InputHobbyPSeshinbunseki;
    public InputField InputWorkPTsuiseki;
    public InputField InputHobbyPTsuiseki;
    public InputField InputWorkPTouhan;
    public InputField InputHobbyPTouhan;
    public InputField InputWorkPTosyokan;
    public InputField InputHobbyPTosyokan;
    public InputField InputWorkPMeboshi;
    public InputField InputHobbyPMeboshi;

    public GameObject workOkyuteate;
    public GameObject workKagiake;
    public GameObject workKakusu;
    public GameObject workKakureru;
    public GameObject workKikimimi;
    public GameObject workShinobiaruki;
    public GameObject workSyashinzyutsu;
    public GameObject workSeshinbunseki;
    public GameObject workTsuiseki;
    public GameObject workTouhan;
    public GameObject workTosyokan;
    public GameObject workMeboshi;

    //行動技能ステータス
    public InputField InputWorkPUnten;
    public InputField InputHobbyPUnten;
    public InputField InputWorkPKikaisyuri;
    public InputField InputHobbyPKikaisyuri;
    public InputField InputWorkPZyukikaisosa;
    public InputField InputHobbyPZyukikaisosa;
    public InputField InputWorkPZyoba;
    public InputField InputHobbyPZyoba;
    public InputField InputWorkPSuiei;
    public InputField InputHobbyPSuiei;
    public InputField InputWorkPSesaku;
    public InputField InputHobbyPSesaku;
    public InputField InputWorkPSozyu;
    public InputField InputHobbyPSozyu;
    public InputField InputWorkPTyoyaku;
    public InputField InputHobbyPTyoyaku;
    public InputField InputWorkPDenkisyuri;
    public InputField InputHobbyPDenkisyuri;
    public InputField InputWorkPNabigeto;
    public InputField InputHobbyPNabigeto;
    public InputField InputWorkPHensou;
    public InputField InputHobbyPHensou;

    public GameObject workUnten;
    public GameObject workKikaisyuri;
    public GameObject workZyukikaisosa;
    public GameObject workZyoba;
    public GameObject workSuiei;
    public GameObject workSesaku;
    public GameObject workSozyu;
    public GameObject workTyoyaku;
    public GameObject workDenkisyuri;
    public GameObject workNabigeto;
    public GameObject workHensou;

    //交渉技能ステータス
    public InputField InputWorkPIikurume;
    public InputField InputHobbyPIikurume;
    public InputField InputWorkPShinyou;
    public InputField InputHobbyPShinyou;
    public InputField InputWorkPSettoku;
    public InputField InputHobbyPSettoku;
    public InputField InputWorkPNegiri;
    public InputField InputHobbyPNegiri;
    public InputField InputWorkPBokokugo;
    public InputField InputHobbyPBokokugo;

    public GameObject workIikurume;
    public GameObject workShinyo;
    public GameObject workSettoku;
    public GameObject workNegiri;
    public GameObject workBokokugo;

    //知識技能ステータス
    public InputField InputWorkPIgaku;
    public InputField InputHobbyPIgaku;
    public InputField InputWorkPOkaruto;
    public InputField InputHobbyPOkaruto;
    public InputField InputWorkPKagaku;
    public InputField InputHobbyPKagaku;
    public InputField InputWorkPShinwa;
    public InputField InputHobbyPShinwa;
    public InputField InputWorkPGezyutsu;
    public InputField InputHobbyPGezyutsu;
    public InputField InputWorkPKeiri;
    public InputField InputHobbyPKeiri;
    public InputField InputWorkPKokogaku;
    public InputField InputHobbyPKokogaku;
    public InputField InputWorkPPC;
    public InputField InputHobbyPPC;
    public InputField InputWorkPShinrigaku;
    public InputField InputHobbyPShinrigaku;
    public InputField InputWorkPZinruigaku;
    public InputField InputHobbyPZinruigaku;
    public InputField InputWorkPSeibutsugaku;
    public InputField InputHobbyPSeibutsugaku;
    public InputField InputWorkPTishitsugaku;
    public InputField InputHobbyPTishitsugaku;
    public InputField InputWorkPDenshikougaku;
    public InputField InputHobbyPDenshikougaku;
    public InputField InputWorkPTenmongaku;
    public InputField InputHobbyPTenmongaku;
    public InputField InputWorkPHakubutsugaku;
    public InputField InputHobbyPHakubutsugaku;
    public InputField InputWorkPButsurigaku;
    public InputField InputHobbyPButsurigaku;
    public InputField InputWorkPHouritsu;
    public InputField InputHobbyPHouritsu;
    public InputField InputWorkPYakugaku;
    public InputField InputHobbyPYakugaku;
    public InputField InputWorkPRekishi;
    public InputField InputHobbyPRekishi;

    public GameObject workIgaku;
    public GameObject workOkaruto;
    public GameObject workKagaku;
    public GameObject workShinwa;
    public GameObject workGezyutsu;
    public GameObject workKeiri;
    public GameObject workKokogaku;
    public GameObject workPC;
    public GameObject workShinrigaku;
    public GameObject workZinruigaku;
    public GameObject workSebutsugaku;
    public GameObject workTishitsugaku;
    public GameObject workDenshikougaku;
    public GameObject workTenmongaku;
    public GameObject workHakubutsugaku;
    public GameObject workButsurigaku;
    public GameObject workHouritsu;
    public GameObject workYakugaku;
    public GameObject workRekishi;
    public GameObject Konmaigo;

    float choicePanel = 0;
    private int limit = 80;     //ステータス上限
    private int delay = 300;

    //戦闘技能ステータス
    int kaihi = 0;
    int kikku = 0;
    int kumitsuki = 0;
    int kobushi = 0;
    int zutsuki = 0;
    int toteki = 0;
    int msa = 0;
    int kenzyu = 0;
    int smg = 0;
    int sg = 0;
    int mg = 0;
    int r = 0;

    //探索技能ステータス
    int okyuteate = 0;
    int kagiake = 0;
    int kakusu = 0;
    int kakureru = 0;
    int kikimimi = 0;
    int shinobiaruki = 0;
    int syashinzyutsu = 0;
    int seshinbunseki = 0;
    int tsuiseki = 0;
    int touhan = 0;
    int tosyokan = 0;
    int meboshi = 0;

    //行動技能ステータス
    int unten = 0;
    int kikaisyuri = 0;
    int zyukikaisosa = 0;
    int zyoba = 0;
    int suiei = 0;
    int sesaku = 0;
    int sozyu = 0;
    int tyoyaku = 0;
    int denkisyuri = 0;
    int nabigeto = 0;
    int hensou = 0;

    //交渉技能ステータス
    int iikurume = 0;
    int shinyou = 0;
    int settoku = 0;
    int negiri = 0;
    int bokokugo = 0;

    //知識技能ステータス
    int igaku = 0;
    int okaruto = 0;
    int kagaku = 0;
    int shinwa = 0;
    int gezyutsu = 0;
    int keiri = 0;
    int kokogaku = 0;
    int pc = 0;
    int shinrigaku = 0;
    int zinruigaku = 0;
    int seibutsugaku = 0;
    int tishitsugaku = 0;
    int denshikougaku = 0;
    int tenmongaku = 0;
    int hakubutsugaku = 0;
    int butsurigaku = 0;
    int houritsu = 0;
    int yakugaku = 0;
    int rekishi = 0;

    bool NRButton;
    int[] inputworkp = { 0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,};
    int[] inputhobbyp = { 0,0,0,0,0,0,0,0,0,0,0,0,
                          0,0,0,0,0,0,0,0,0,0,0,0,
                          0,0,0,0,0,0,0,0,0,0,0,
                          0,0,0,0,0,
                          0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,};
    //初期ステータス
    int[] status =    {  0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,};
    //変更後のステータス
    int[] Afterstatus =    {  0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,
                         0,0,0,0,0,
                         0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,};
    string[] SkillNames = { "回避","キック","組みつき","拳","頭突き","投てき","マーシャルアーツ","拳銃","サブマシンガン","ショットガン","マシンガン","ライフル",
                           "応急手当","鍵開け","隠す","隠れる","聞き耳","忍び歩き","写真術","精神分析","追跡","登攀","図書館","目星",
                           "運転","機械修理","重機械操作","乗馬","水泳","制作","操縦","跳躍","電気修理","ナビゲート","変装",
                           "言いくるめ","信用","説得","値切り","母国語",
                           "医学","オカルト","神話","芸術","経理","考古学","PC","心理学","人類学","生物学","地質学","電子工学","天文学","博物学","物理学","法律","薬学","歴史"};

    //基礎ステータス
    [SerializeField] Text STR;
    [SerializeField] Text CON;
    [SerializeField] Text POW;
    [SerializeField] Text DEX;
    [SerializeField] Text APP;
    [SerializeField] Text SIZ;
    [SerializeField] Text INT;
    [SerializeField] Text EDU;

    [SerializeField] Text SAN;
    [SerializeField] Text Luck;
    [SerializeField] Text Idea;
    [SerializeField] Text Memory;
    [SerializeField] Text Durability;
    [SerializeField] Text MgcP;
    [SerializeField] Text DamegeP;

    //戦闘技能ステータス
    [SerializeField] Text NowKaihi;
    [SerializeField] Text NowKikku;
    [SerializeField] Text NowKumitsuki;
    [SerializeField] Text NowKobushi;
    [SerializeField] Text NowZutsuki;
    [SerializeField] Text NowToteki;
    [SerializeField] Text NowMSA;
    [SerializeField] Text NowKenzyu;
    [SerializeField] Text NowSMG;
    [SerializeField] Text NowSG;
    [SerializeField] Text NowMG;
    [SerializeField] Text NowR;

    //探索技能ステータス
    [SerializeField] Text NowOkyuteate;
    [SerializeField] Text NowKagiake;
    [SerializeField] Text NowKakusu;
    [SerializeField] Text NowKakureru;
    [SerializeField] Text NowKikimimi;
    [SerializeField] Text NowShinobiaruki;
    [SerializeField] Text NowSyashinzyutsu;
    [SerializeField] Text NowSeshinbunseki;
    [SerializeField] Text NowTsuiseki;
    [SerializeField] Text NowTouhan;
    [SerializeField] Text NowTosyokan;
    [SerializeField] Text NowMeboshi;

    //行動技能ステータス
    [SerializeField] Text NowUnten;
    [SerializeField] Text NowKikaisyuri;
    [SerializeField] Text NowZyukikaisosa;
    [SerializeField] Text NowZyoba;
    [SerializeField] Text NowSuiei;
    [SerializeField] Text NowSesaku;
    [SerializeField] Text NowSozyu;
    [SerializeField] Text NowTyoyaku;
    [SerializeField] Text NowDenkisyuri;
    [SerializeField] Text NowNabigeto;
    [SerializeField] Text NowHensou;

    //交渉技能ステータス
    [SerializeField] Text NowIikurume;
    [SerializeField] Text NowShinyou;
    [SerializeField] Text NowSettoku;
    [SerializeField] Text NowNegiri;
    [SerializeField] Text NowBokokugo;

    //知識技能ステータス
    [SerializeField] Text NowIgaku;
    [SerializeField] Text NowOkaruto;
    [SerializeField] Text NowKagaku;
    [SerializeField] Text NowShinwa;            //クトゥルフ神話
    [SerializeField] Text NowGezyutsu;
    [SerializeField] Text NowKeiri;
    [SerializeField] Text NowKokogaku;
    [SerializeField] Text NowPC;                //コンピュータ
    [SerializeField] Text NowShinrigaku;
    [SerializeField] Text NowZinruigaku;
    [SerializeField] Text NowSeibutsugaku;
    [SerializeField] Text NowTishitsugaku;
    [SerializeField] Text NowDenshikougaku;
    [SerializeField] Text NowTenmongaku;
    [SerializeField] Text NowHakubutsugaku;
    [SerializeField] Text NowButsurigaku;
    [SerializeField] Text NowHouritsu;
    [SerializeField] Text NowYakugaku;
    [SerializeField] Text NowRekishi;

    [SerializeField]
    private Fade m_fade = null;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();


        //戦闘技能ステータス
        //回避
        InputWorkPKaihi = InputWorkPKaihi.GetComponent<InputField>();
        InputHobbyPKaihi = InputHobbyPKaihi.GetComponent<InputField>();
        //キック
        InputWorkPKikku = InputWorkPKikku.GetComponent<InputField>();
        InputHobbyPKikku = InputHobbyPKikku.GetComponent<InputField>();
        //組み付き
        InputWorkPKumitsuki = InputWorkPKumitsuki.GetComponent<InputField>();
        InputHobbyPKumitsuki = InputHobbyPKumitsuki.GetComponent<InputField>();
        //こぶし
        InputWorkPKobushi = InputWorkPKobushi.GetComponent<InputField>();
        InputHobbyPKobushi = InputHobbyPKobushi.GetComponent<InputField>();
        //頭突き
        InputWorkPZutsuki = InputWorkPZutsuki.GetComponent<InputField>();
        InputHobbyPZutsuki = InputHobbyPZutsuki.GetComponent<InputField>();
        //投擲
        InputWorkPToteki = InputWorkPToteki.GetComponent<InputField>();
        InputHobbyPToteki = InputHobbyPToteki.GetComponent<InputField>();
        //マーシャルアーツ
        InputWorkPMSA = InputWorkPMSA.GetComponent<InputField>();
        InputHobbyPMSA = InputHobbyPMSA.GetComponent<InputField>();
        //拳銃
        InputWorkPKenzyu = InputWorkPKenzyu.GetComponent<InputField>();
        InputHobbyPKenzyu = InputHobbyPKenzyu.GetComponent<InputField>();
        //サブマシンガン
        InputWorkPSMG = InputWorkPSMG.GetComponent<InputField>();
        InputHobbyPSMG = InputHobbyPSMG.GetComponent<InputField>();
        //ショットガン
        InputWorkPSG = InputWorkPSG.GetComponent<InputField>();
        InputHobbyPSG = InputHobbyPSG.GetComponent<InputField>();
        //マシンガン
        InputWorkPMG = InputWorkPMG.GetComponent<InputField>();
        InputHobbyPMG = InputHobbyPMG.GetComponent<InputField>();
        //ライフル
        InputWorkPR = InputWorkPR.GetComponent<InputField>();
        InputHobbyPR = InputHobbyPR.GetComponent<InputField>();

        //探索技能ステータス
        //応急手当
        InputWorkPOkyuteate = InputWorkPOkyuteate.GetComponent<InputField>();
        InputHobbyPOkyuteate = InputHobbyPOkyuteate.GetComponent<InputField>();
        //鍵開け
        InputWorkPKagiake = InputWorkPKagiake.GetComponent<InputField>();
        InputHobbyPKagiake = InputHobbyPKagiake.GetComponent<InputField>();
        //隠す
        InputWorkPKakusu = InputWorkPKakusu.GetComponent<InputField>();
        InputHobbyPKakusu = InputHobbyPKakusu.GetComponent<InputField>();
        //隠れる
        InputWorkPKakureru = InputWorkPKakureru.GetComponent<InputField>();
        InputHobbyPKakureru = InputHobbyPKakureru.GetComponent<InputField>();
        //聞き耳
        InputWorkPKikimimi = InputWorkPKikimimi.GetComponent<InputField>();
        InputHobbyPKikimimi = InputHobbyPKikimimi.GetComponent<InputField>();
        //忍び歩き
        InputWorkPShinobiaruki = InputWorkPShinobiaruki.GetComponent<InputField>();
        InputHobbyPShinobiaruki = InputHobbyPShinobiaruki.GetComponent<InputField>();
        //写真術
        InputWorkPSyashinzyutsu = InputWorkPSyashinzyutsu.GetComponent<InputField>();
        InputHobbyPSyashinzyutsu = InputHobbyPSyashinzyutsu.GetComponent<InputField>();
        //精神分析
        InputWorkPSeshinbunseki = InputWorkPSeshinbunseki.GetComponent<InputField>();
        InputHobbyPSeshinbunseki = InputHobbyPSeshinbunseki.GetComponent<InputField>();
        //追跡
        InputWorkPTsuiseki = InputWorkPTsuiseki.GetComponent<InputField>();
        InputHobbyPTsuiseki = InputHobbyPTsuiseki.GetComponent<InputField>();
        //登攀
        InputWorkPTouhan = InputWorkPTouhan.GetComponent<InputField>();
        InputHobbyPTouhan = InputHobbyPTouhan.GetComponent<InputField>();
        //図書館
        InputWorkPTosyokan = InputWorkPTosyokan.GetComponent<InputField>();
        InputHobbyPTosyokan = InputHobbyPTosyokan.GetComponent<InputField>();
        //目星
        InputWorkPMeboshi = InputWorkPMeboshi.GetComponent<InputField>();
        InputHobbyPMeboshi = InputHobbyPMeboshi.GetComponent<InputField>();

        //行動技能ステータス
        //運転
        InputWorkPUnten = InputWorkPUnten.GetComponent<InputField>();
        InputHobbyPUnten = InputHobbyPUnten.GetComponent<InputField>();
        //機械修理
        InputWorkPKikaisyuri = InputWorkPKikaisyuri.GetComponent<InputField>();
        InputHobbyPKikaisyuri = InputHobbyPKikaisyuri.GetComponent<InputField>();
        //重機械操作
        InputWorkPZyukikaisosa = InputWorkPZyukikaisosa.GetComponent<InputField>();
        InputHobbyPZyukikaisosa = InputHobbyPZyukikaisosa.GetComponent<InputField>();
        //乗馬
        InputWorkPZyoba = InputWorkPZyoba.GetComponent<InputField>();
        InputHobbyPZyoba = InputHobbyPZyoba.GetComponent<InputField>();
        //操縦
        InputWorkPSozyu = InputWorkPSozyu.GetComponent<InputField>();
        InputHobbyPSozyu = InputHobbyPSozyu.GetComponent<InputField>();
        //跳躍
        InputWorkPTyoyaku = InputWorkPTyoyaku.GetComponent<InputField>();
        InputHobbyPTyoyaku = InputHobbyPTyoyaku.GetComponent<InputField>();
        //電気修理
        InputWorkPDenkisyuri = InputWorkPDenkisyuri.GetComponent<InputField>();
        InputHobbyPDenkisyuri = InputHobbyPDenkisyuri.GetComponent<InputField>();
        //ナビゲート
        InputWorkPNabigeto = InputWorkPNabigeto.GetComponent<InputField>();
        InputHobbyPNabigeto = InputHobbyPNabigeto.GetComponent<InputField>();
        //変装
        InputWorkPHensou = InputWorkPHensou.GetComponent<InputField>();
        InputHobbyPHensou = InputHobbyPHensou.GetComponent<InputField>();

        //交渉技能ステータス
        //言いくるめ
        InputWorkPIikurume = InputWorkPIikurume.GetComponent<InputField>();
        InputHobbyPIikurume = InputHobbyPIikurume.GetComponent<InputField>();
        //信用
        InputWorkPShinyou = InputWorkPShinyou.GetComponent<InputField>();
        InputHobbyPShinyou = InputHobbyPShinyou.GetComponent<InputField>();
        //説得
        InputWorkPSettoku = InputWorkPSettoku.GetComponent<InputField>();
        InputHobbyPSettoku = InputHobbyPSettoku.GetComponent<InputField>();
        //値切り
        InputWorkPNegiri = InputWorkPNegiri.GetComponent<InputField>();
        InputHobbyPNegiri = InputHobbyPNegiri.GetComponent<InputField>();
        //母国語
        InputWorkPBokokugo = InputWorkPBokokugo.GetComponent<InputField>();
        InputHobbyPBokokugo = InputHobbyPBokokugo.GetComponent<InputField>();

        //知識技能ステータス
        //医学
        InputWorkPIgaku = InputWorkPIgaku.GetComponent<InputField>();
        InputHobbyPIgaku = InputHobbyPIgaku.GetComponent<InputField>();
        //オカルト
        InputWorkPOkaruto = InputWorkPOkaruto.GetComponent<InputField>();
        InputHobbyPOkaruto = InputHobbyPOkaruto.GetComponent<InputField>();
        //化学
        InputWorkPKagaku = InputWorkPKagaku.GetComponent<InputField>();
        InputHobbyPKagaku = InputHobbyPKagaku.GetComponent<InputField>();
        //クトゥルフ神話
        InputWorkPShinwa = InputWorkPShinwa.GetComponent<InputField>();
        InputHobbyPShinwa = InputHobbyPShinwa.GetComponent<InputField>();
        //芸術
        InputWorkPGezyutsu = InputWorkPGezyutsu.GetComponent<InputField>();
        InputHobbyPGezyutsu = InputHobbyPGezyutsu.GetComponent<InputField>();
        //経理
        InputWorkPKeiri = InputWorkPKeiri.GetComponent<InputField>();
        InputHobbyPKeiri = InputHobbyPKeiri.GetComponent<InputField>();
        //考古学
        InputWorkPKokogaku = InputWorkPKokogaku.GetComponent<InputField>();
        InputHobbyPKokogaku = InputHobbyPKokogaku.GetComponent<InputField>();
        //コンピューター
        InputWorkPPC = InputWorkPPC.GetComponent<InputField>();
        InputHobbyPPC = InputHobbyPPC.GetComponent<InputField>();
        //心理学
        InputWorkPShinrigaku = InputWorkPShinrigaku.GetComponent<InputField>();
        InputHobbyPShinrigaku = InputHobbyPShinrigaku.GetComponent<InputField>();
        //人類学
        InputWorkPZinruigaku = InputWorkPZinruigaku.GetComponent<InputField>();
        InputHobbyPZinruigaku = InputHobbyPZinruigaku.GetComponent<InputField>();
        //生物学
        InputWorkPSeibutsugaku = InputWorkPSeibutsugaku.GetComponent<InputField>();
        InputHobbyPSeibutsugaku = InputHobbyPSeibutsugaku.GetComponent<InputField>();
        //地質学
        InputWorkPTishitsugaku = InputWorkPTishitsugaku.GetComponent<InputField>();
        InputHobbyPTishitsugaku = InputHobbyPTishitsugaku.GetComponent<InputField>();
        //電子工学
        InputWorkPDenshikougaku = InputWorkPDenshikougaku.GetComponent<InputField>();
        InputHobbyPDenshikougaku = InputHobbyPDenshikougaku.GetComponent<InputField>();
        //天文学
        InputWorkPTenmongaku = InputWorkPTenmongaku.GetComponent<InputField>();
        InputHobbyPTenmongaku = InputHobbyPTenmongaku.GetComponent<InputField>();
        //博物学
        InputWorkPHakubutsugaku = InputWorkPHakubutsugaku.GetComponent<InputField>();
        InputHobbyPHakubutsugaku = InputHobbyPHakubutsugaku.GetComponent<InputField>();
        //物理学
        InputWorkPButsurigaku = InputWorkPButsurigaku.GetComponent<InputField>();
        InputHobbyPButsurigaku = InputHobbyPButsurigaku.GetComponent<InputField>();
        //法律
        InputWorkPHouritsu = InputWorkPHouritsu.GetComponent<InputField>();
        InputHobbyPHouritsu = InputHobbyPHouritsu.GetComponent<InputField>();
        //薬学
        InputWorkPYakugaku = InputWorkPYakugaku.GetComponent<InputField>();
        InputHobbyPYakugaku = InputHobbyPYakugaku.GetComponent<InputField>();
        //歴史
        InputWorkPRekishi = InputWorkPRekishi.GetComponent<InputField>();
        InputHobbyPRekishi = InputHobbyPRekishi.GetComponent<InputField>();

        //戦闘技能ステータス
        InputWorkPKaihi.text = "0";
        InputHobbyPKaihi.text = "0";
        InputWorkPKikku.text = "0";
        InputHobbyPKikku.text = "0";
        InputWorkPKumitsuki.text = "0";
        InputHobbyPKumitsuki.text = "0";
        InputWorkPKobushi.text = "0";
        InputHobbyPKobushi.text = "0";
        InputWorkPZutsuki.text = "0";
        InputHobbyPZutsuki.text = "0";
        InputWorkPToteki.text = "0";
        InputHobbyPToteki.text = "0";
        InputWorkPMSA.text = "0";
        InputHobbyPMSA.text = "0";
        InputWorkPKenzyu.text = "0";
        InputHobbyPKenzyu.text = "0";
        InputWorkPSMG.text = "0";
        InputHobbyPSMG.text = "0";
        InputWorkPSG.text = "0";
        InputHobbyPSG.text = "0";
        InputWorkPMG.text = "0";
        InputHobbyPMG.text = "0";
        InputWorkPR.text = "0";
        InputHobbyPR.text = "0";

        //探索技能ステータス
        InputWorkPOkyuteate.text = "0";
        InputHobbyPOkyuteate.text = "0";
        InputWorkPKagiake.text = "0";
        InputHobbyPKagiake.text = "0";
        InputWorkPKakusu.text = "0";
        InputHobbyPKakusu.text = "0";
        InputWorkPKakureru.text = "0";
        InputHobbyPKakureru.text = "0";
        InputWorkPKikimimi.text = "0";
        InputHobbyPKikimimi.text = "0";
        InputWorkPShinobiaruki.text = "0";
        InputHobbyPShinobiaruki.text = "0";
        InputWorkPSyashinzyutsu.text = "0";
        InputHobbyPSyashinzyutsu.text = "0";
        InputWorkPSeshinbunseki.text = "0";
        InputHobbyPSeshinbunseki.text = "0";
        InputWorkPTsuiseki.text = "0";
        InputHobbyPTsuiseki.text = "0";
        InputWorkPTouhan.text = "0";
        InputHobbyPTouhan.text = "0";
        InputWorkPTosyokan.text = "0";
        InputHobbyPTosyokan.text = "0";
        InputWorkPMeboshi.text = "0";
        InputHobbyPMeboshi.text = "0";

        //行動技能ステータス
        InputWorkPUnten.text = "0";
        InputHobbyPUnten.text = "0";
        InputWorkPKikaisyuri.text = "0";
        InputHobbyPKikaisyuri.text = "0";
        InputWorkPZyukikaisosa.text = "0";
        InputHobbyPZyukikaisosa.text = "0";
        InputWorkPZyoba.text = "0";
        InputHobbyPZyoba.text = "0";
        InputWorkPSuiei.text = "0";
        InputHobbyPSuiei.text = "0";
        InputWorkPSesaku.text = "0";
        InputHobbyPSesaku.text = "0";
        InputWorkPSozyu.text = "0";
        InputHobbyPSozyu.text = "0";
        InputWorkPTyoyaku.text = "0";
        InputHobbyPTyoyaku.text = "0";
        InputWorkPDenkisyuri.text = "0";
        InputHobbyPDenkisyuri.text = "0";
        InputWorkPNabigeto.text = "0";
        InputHobbyPNabigeto.text = "0";
        InputWorkPHensou.text = "0";
        InputHobbyPHensou.text = "0";

        //交渉技能ステータス
        InputWorkPIikurume.text = "0";
        InputHobbyPIikurume.text = "0";
        InputWorkPShinyou.text = "0";
        InputHobbyPShinyou.text = "0";
        InputWorkPSettoku.text = "0";
        InputHobbyPSettoku.text = "0";
        InputWorkPNegiri.text = "0";
        InputHobbyPNegiri.text = "0";
        InputWorkPBokokugo.text = "0";
        InputHobbyPBokokugo.text = "0";

        //知識技能ステータス
        InputWorkPIgaku.text = "0";
        InputHobbyPIgaku.text = "0";
        InputWorkPOkaruto.text = "0";
        InputHobbyPOkaruto.text = "0";
        InputWorkPKagaku.text = "0";
        InputHobbyPKagaku.text = "0";
        InputWorkPShinwa.text = "0";
        InputHobbyPShinwa.text = "0";
        InputWorkPGezyutsu.text = "0";
        InputHobbyPGezyutsu.text = "0";
        InputWorkPKeiri.text = "0";
        InputHobbyPKeiri.text = "0";
        InputWorkPKokogaku.text = "0";
        InputHobbyPKokogaku.text = "0";
        InputWorkPPC.text = "0";
        InputHobbyPPC.text = "0";
        InputWorkPShinrigaku.text = "0";
        InputHobbyPShinrigaku.text = "0";
        InputWorkPZinruigaku.text = "0";
        InputHobbyPZinruigaku.text = "0";
        InputWorkPSeibutsugaku.text = "0";
        InputHobbyPSeibutsugaku.text = "0";
        InputWorkPTishitsugaku.text = "0";
        InputHobbyPTishitsugaku.text = "0";
        InputWorkPDenshikougaku.text = "0";
        InputHobbyPDenshikougaku.text = "0";
        InputWorkPTenmongaku.text = "0";
        InputHobbyPTenmongaku.text = "0";
        InputWorkPHakubutsugaku.text = "0";
        InputHobbyPHakubutsugaku.text = "0";
        InputWorkPButsurigaku.text = "0";
        InputHobbyPButsurigaku.text = "0";
        InputWorkPHouritsu.text = "0";
        InputHobbyPHouritsu.text = "0";
        InputWorkPYakugaku.text = "0";
        InputHobbyPYakugaku.text = "0";
        InputWorkPRekishi.text = "0";
        InputHobbyPRekishi.text = "0";

    }
    int Dice(int a, int b)   //Dice(ダイスの数,ダイスのプラス値)
    {
        int x = Random.Range(1, 6);
        x = x * a + b;
        return x;
    }
    //ステータス決め
    public async void Status()
    {
        DiceButton.SetActive(false);
        StatusManager.Instance.STR = Dice(3, 0);
        StatusManager.Instance.CON = Dice(3, 0);
        StatusManager.Instance.POW = Dice(3, 0);
        StatusManager.Instance.DEX = Dice(3, 0);
        StatusManager.Instance.APP = Dice(3, 0);
        StatusManager.Instance.SIZ = Dice(2, 6);
        StatusManager.Instance.INT = Dice(2, 6);
        StatusManager.Instance.EDU = Dice(3, 3);
        StatusManager.Instance.StatusPoints();
        audioSource.PlayOneShot(StatusSound);
        STR.text = StatusManager.Instance.STR.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        CON.text = StatusManager.Instance.CON.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        POW.text = StatusManager.Instance.POW.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        DEX.text = StatusManager.Instance.DEX.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        APP.text = StatusManager.Instance.APP.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        SIZ.text = StatusManager.Instance.SIZ.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        INT.text = StatusManager.Instance.INT.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        EDU.text = StatusManager.Instance.EDU.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        SAN.text = StatusManager.Instance.SAN.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        Luck.text = StatusManager.Instance.Luck.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        Idea.text = StatusManager.Instance.Idea.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        Memory.text = StatusManager.Instance.Memory.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        Durability.text = StatusManager.Instance.Durability.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        MgcP.text = StatusManager.Instance.MgcP.ToString();
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        StatusManager.Instance.DecisionworkP = true;
        await Task.Delay(delay);
        audioSource.PlayOneShot(StatusSound);
        StatusManager.Instance.DecisionhobbyP = true;
        await Task.Delay(delay);

        if ((2 <= StatusManager.Instance.DamagePCheck) && (StatusManager.Instance.DamagePCheck <= 12))
        {
            DamegeP.text = "-1D6";
            StatusManager.Instance.DamageP = -6;
        }
        else if ((13 <= StatusManager.Instance.DamagePCheck) && (StatusManager.Instance.DamagePCheck <= 16))
        {
            DamegeP.text = "-1D4";
            StatusManager.Instance.DamageP = -4;
        }
        else if ((17 <= StatusManager.Instance.DamagePCheck) && (StatusManager.Instance.DamagePCheck <= 24))
        {
            DamegeP.text = "0";
            StatusManager.Instance.DamageP = -0;
        }
        else if ((25 <= StatusManager.Instance.DamagePCheck) && (StatusManager.Instance.DamagePCheck <= 32))
        {
            DamegeP.text = "+1D4";
            StatusManager.Instance.DamageP = 4;
        }
        else if ((33 <= StatusManager.Instance.DamagePCheck) && (StatusManager.Instance.DamagePCheck <= 40))
        {
            DamegeP.text = "+1D6";
            StatusManager.Instance.DamageP = 6;
        }

        //戦闘技能ステータス
        NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
        status[0] = StatusManager.Instance.Kaihi;
        NowKikku.text = StatusManager.Instance.Kikku.ToString();
        status[1] = StatusManager.Instance.Kikku;
        NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
        status[2] = StatusManager.Instance.Kikimimi;
        NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
        status[3] = StatusManager.Instance.Kobushi;
        NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
        status[4] = StatusManager.Instance.Zutsuki;
        NowToteki.text = StatusManager.Instance.Toteki.ToString();
        status[5] = StatusManager.Instance.Toteki;
        NowMSA.text = StatusManager.Instance.MSA.ToString();
        status[6] = StatusManager.Instance.MSA;
        NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
        status[7] = StatusManager.Instance.Kenzyu;
        NowSMG.text = StatusManager.Instance.SMG.ToString();
        status[8] = StatusManager.Instance.SMG;
        NowSG.text = StatusManager.Instance.SG.ToString();
        status[9] = StatusManager.Instance.SG;
        NowMG.text = StatusManager.Instance.MG.ToString();
        status[10] = StatusManager.Instance.MG;
        NowR.text = StatusManager.Instance.R.ToString();
        status[11] = StatusManager.Instance.R;

        //探索技能ステータス
        NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
        status[12] = StatusManager.Instance.Okyuteate;
        NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
        status[13] = StatusManager.Instance.Kagiake;
        NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
        status[14] = StatusManager.Instance.Kakusu;
        NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
        status[15] = StatusManager.Instance.Kakureru;
        NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
        status[16] = StatusManager.Instance.Kikimimi;
        NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
        status[17] = StatusManager.Instance.Shinobiaruki;
        NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
        status[18] = StatusManager.Instance.Syashinzyutsu;
        NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
        status[19] = StatusManager.Instance.Seshinbunseki;
        NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
        status[20] = StatusManager.Instance.Tsuiseki;
        NowTouhan.text = StatusManager.Instance.Touhan.ToString();
        status[21] = StatusManager.Instance.Touhan;
        NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
        status[22] = StatusManager.Instance.Tosyokan;
        NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
        status[23] = StatusManager.Instance.Meboshi;

        //行動技能ステータス
        NowUnten.text = StatusManager.Instance.Unten.ToString();
        status[24] = StatusManager.Instance.Unten;
        NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
        status[25] = StatusManager.Instance.Kikaisyuri;
        NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
        status[26] = StatusManager.Instance.Zyukikaisosa;
        NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
        status[27] = StatusManager.Instance.Zyoba;
        NowSuiei.text = StatusManager.Instance.Suiei.ToString();
        status[28] = StatusManager.Instance.Suiei;
        NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
        status[29] = StatusManager.Instance.Sesaku;
        NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
        status[30] = StatusManager.Instance.Sozyu;
        NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
        status[31] = StatusManager.Instance.Tyoyaku;
        NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
        status[32] = StatusManager.Instance.Denkisyuri;
        NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
        status[33] = StatusManager.Instance.Nabigeto;
        NowHensou.text = StatusManager.Instance.Hensou.ToString();
        status[34] = StatusManager.Instance.Hensou;

        //交渉技能ステータス
        NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
        status[35] = StatusManager.Instance.Iikurume;
        NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
        status[36] = StatusManager.Instance.Shinyou;
        NowSettoku.text = StatusManager.Instance.Settoku.ToString();
        status[37] = StatusManager.Instance.Settoku;
        NowNegiri.text = StatusManager.Instance.Negiri.ToString();
        status[38] = StatusManager.Instance.Negiri;
        NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
        status[39] = StatusManager.Instance.Bokokugo;

        //知識技能ステータス
        NowIgaku.text = StatusManager.Instance.Igaku.ToString();
        status[40] = StatusManager.Instance.Igaku;
        NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
        status[41] = StatusManager.Instance.Okaruto;
        NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
        status[42] = StatusManager.Instance.Kagaku;
        NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
        status[43] = StatusManager.Instance.Shinwa;
        NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
        status[44] = StatusManager.Instance.Gezyutsu;
        NowKeiri.text = StatusManager.Instance.Keiri.ToString();
        status[45] = StatusManager.Instance.Keiri;
        NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
        status[46] = StatusManager.Instance.Kokogaku;
        NowPC.text = StatusManager.Instance.PC.ToString();
        status[47] = StatusManager.Instance.PC;
        NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
        status[48] = StatusManager.Instance.Shinrigaku;
        NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
        status[49] = StatusManager.Instance.Zinruigaku;
        NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
        status[50] = StatusManager.Instance.Seibutsugaku;
        NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
        status[51] = StatusManager.Instance.Tishitsugaku;
        NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
        status[52] = StatusManager.Instance.Denshikougaku;
        NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
        status[53] = StatusManager.Instance.Tenmongaku;
        NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
        status[54] = StatusManager.Instance.Hakubutsugaku;
        NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
        status[55] = StatusManager.Instance.Butsurigaku;
        NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
        status[56] = StatusManager.Instance.Houritsu;
        NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
        status[57] = StatusManager.Instance.Yakugaku;
        NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
        status[58] = StatusManager.Instance.Rekishi;

        NextButton.SetActive(true);
    }

    //ステータスの確認
    public void CheckStatus(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:
                StatusPanel.SetActive(true);
                ProfessionPanel.SetActive(false);
                StatusReturnButton.SetActive(true);
                break;
            case 1:
                StatusPanel.SetActive(false);
                ProfessionPanel.SetActive(true);
                StatusReturnButton.SetActive(false);
                break;
        }
    }

    //職業技能取得パネルの表示
    public void NextProfession()
    {
        NextButton.SetActive(false);
        StatusPanel.SetActive(false);
        ProfessionPanel.SetActive(true);
    }

    //職業決定ボタン
    public void NextStatusPoint(int Button)
    {
        switch (Button)
        {
            case 0:
                StatusManager.Instance.ChoiceProfession = 0;
                break;
            case 1:
                StatusManager.Instance.ChoiceProfession = 1;
                break;
            case 2:
                StatusManager.Instance.ChoiceProfession = 2;
                break;
            case 3:
                StatusManager.Instance.ChoiceProfession = 3;
                break;
        }
        WorkChoiceStatus();
        ProfessionPanel.SetActive(false);
        BattlePanel.SetActive(true);
    }

    //職業による習得できるスキル
    public void WorkChoiceStatus()
    {
        switch (StatusManager.Instance.ChoiceProfession)
        {
            case 0:     //ボディーガード(SP)
                workKaihi.SetActive(true);
                workKikku.SetActive(true);
                workKumitsuki.SetActive(true);
                workKobushi.SetActive(true);
                workZutsuki.SetActive(true);
                workToteki.SetActive(false);
                workMSA.SetActive(true);
                workKenzyu.SetActive(true);
                workSMG.SetActive(true);
                workSG.SetActive(true);
                workMG.SetActive(true);
                workR.SetActive(true);

                workOkyuteate.SetActive(false);
                workKagiake.SetActive(false);
                workKakusu.SetActive(false);
                workKakureru.SetActive(false);
                workKikimimi.SetActive(true);
                workShinobiaruki.SetActive(false);
                workSyashinzyutsu.SetActive(false);
                workSeshinbunseki.SetActive(false);
                workTsuiseki.SetActive(false);
                workTouhan.SetActive(false);
                workTosyokan.SetActive(false);
                workMeboshi.SetActive(true);

                workUnten.SetActive(true);
                workKikaisyuri.SetActive(false);
                workZyukikaisosa.SetActive(false);
                workZyoba.SetActive(false);
                workSuiei.SetActive(false);
                workSesaku.SetActive(false);
                workSozyu.SetActive(false);
                workTyoyaku.SetActive(false);
                workDenkisyuri.SetActive(false);
                workNabigeto.SetActive(false);
                workHensou.SetActive(false);

                workIikurume.SetActive(true);
                workShinyo.SetActive(true);
                workSettoku.SetActive(true);
                workNegiri.SetActive(true);
                workBokokugo.SetActive(true);

                workIgaku.SetActive(false);
                workOkaruto.SetActive(false);
                workKagaku.SetActive(false);
                workShinwa.SetActive(false);
                workGezyutsu.SetActive(false);
                workKeiri.SetActive(false);
                workKokogaku.SetActive(false);
                workPC.SetActive(false);
                workShinrigaku.SetActive(true);
                workZinruigaku.SetActive(false);
                workSebutsugaku.SetActive(false);
                workTishitsugaku.SetActive(false);
                workDenshikougaku.SetActive(false);
                workTenmongaku.SetActive(false);
                workHakubutsugaku.SetActive(false);
                workButsurigaku.SetActive(false);
                workHouritsu.SetActive(false);
                workYakugaku.SetActive(false);
                workRekishi.SetActive(false);
                break;
            case 1:     //古物研究家
                workKaihi.SetActive(false);
                workKikku.SetActive(false);
                workKumitsuki.SetActive(false);
                workKobushi.SetActive(false);
                workZutsuki.SetActive(false);
                workToteki.SetActive(false);
                workMSA.SetActive(false);
                workKenzyu.SetActive(false);
                workSMG.SetActive(false);
                workSG.SetActive(false);
                workMG.SetActive(false);
                workR.SetActive(false);

                workOkyuteate.SetActive(false);
                workKagiake.SetActive(false);
                workKakusu.SetActive(false);
                workKakureru.SetActive(false);
                workKikimimi.SetActive(false);
                workShinobiaruki.SetActive(false);
                workSyashinzyutsu.SetActive(false);
                workSeshinbunseki.SetActive(false);
                workTsuiseki.SetActive(false);
                workTouhan.SetActive(false);
                workTosyokan.SetActive(true);
                workMeboshi.SetActive(true);

                workUnten.SetActive(false);
                workKikaisyuri.SetActive(false);
                workZyukikaisosa.SetActive(false);
                workZyoba.SetActive(false);
                workSuiei.SetActive(false);
                workSesaku.SetActive(true);
                workSozyu.SetActive(false);
                workTyoyaku.SetActive(false);
                workDenkisyuri.SetActive(false);
                workNabigeto.SetActive(false);
                workHensou.SetActive(false);

                workIikurume.SetActive(true);
                workShinyo.SetActive(true);
                workSettoku.SetActive(true);
                workNegiri.SetActive(true);
                workBokokugo.SetActive(true);

                workIgaku.SetActive(false);
                workOkaruto.SetActive(true);
                workKagaku.SetActive(false);
                workShinwa.SetActive(false);
                workGezyutsu.SetActive(true);
                workKeiri.SetActive(false);
                workKokogaku.SetActive(false);
                workPC.SetActive(false);
                workShinrigaku.SetActive(false);
                workZinruigaku.SetActive(false);
                workSebutsugaku.SetActive(false);
                workTishitsugaku.SetActive(false);
                workDenshikougaku.SetActive(false);
                workTenmongaku.SetActive(false);
                workHakubutsugaku.SetActive(false);
                workButsurigaku.SetActive(false);
                workHouritsu.SetActive(false);
                workYakugaku.SetActive(false);
                workRekishi.SetActive(true);
                break;
            case 2:     //刑事
                workKaihi.SetActive(false);
                workKikku.SetActive(false);
                workKumitsuki.SetActive(false);
                workKobushi.SetActive(false);
                workZutsuki.SetActive(false);
                workToteki.SetActive(false);
                workMSA.SetActive(false);
                workKenzyu.SetActive(true);
                workSMG.SetActive(true);
                workSG.SetActive(true);
                workMG.SetActive(true);
                workR.SetActive(true);

                workOkyuteate.SetActive(false);
                workKagiake.SetActive(false);
                workKakusu.SetActive(false);
                workKakureru.SetActive(false);
                workKikimimi.SetActive(true);
                workShinobiaruki.SetActive(false);
                workSyashinzyutsu.SetActive(false);
                workSeshinbunseki.SetActive(false);
                workTsuiseki.SetActive(false);
                workTouhan.SetActive(false);
                workTosyokan.SetActive(false);
                workMeboshi.SetActive(true);

                workUnten.SetActive(false);
                workKikaisyuri.SetActive(false);
                workZyukikaisosa.SetActive(false);
                workZyoba.SetActive(false);
                workSuiei.SetActive(false);
                workSesaku.SetActive(true);
                workSozyu.SetActive(false);
                workTyoyaku.SetActive(false);
                workDenkisyuri.SetActive(false);
                workNabigeto.SetActive(false);
                workHensou.SetActive(true);

                workIikurume.SetActive(true);
                workShinyo.SetActive(true);
                workSettoku.SetActive(true);
                workNegiri.SetActive(true);
                workBokokugo.SetActive(true);

                workIgaku.SetActive(false);
                workOkaruto.SetActive(false);
                workKagaku.SetActive(false);
                workShinwa.SetActive(false);
                workGezyutsu.SetActive(true);
                workKeiri.SetActive(false);
                workKokogaku.SetActive(false);
                workPC.SetActive(false);
                workShinrigaku.SetActive(true);
                workZinruigaku.SetActive(false);
                workSebutsugaku.SetActive(false);
                workTishitsugaku.SetActive(false);
                workDenshikougaku.SetActive(false);
                workTenmongaku.SetActive(false);
                workHakubutsugaku.SetActive(false);
                workButsurigaku.SetActive(false);
                workHouritsu.SetActive(true);
                workYakugaku.SetActive(false);
                workRekishi.SetActive(false);
                break;
            case 3:
                workKaihi.SetActive(false);
                workKikku.SetActive(false);
                workKumitsuki.SetActive(false);
                workKobushi.SetActive(false);
                workZutsuki.SetActive(false);
                workToteki.SetActive(false);
                workMSA.SetActive(false);
                workKenzyu.SetActive(false);
                workSMG.SetActive(false);
                workSG.SetActive(false);
                workMG.SetActive(false);
                workR.SetActive(false);

                workOkyuteate.SetActive(false);
                workKagiake.SetActive(false);
                workKakusu.SetActive(false);
                workKakureru.SetActive(false);
                workKikimimi.SetActive(false);
                workShinobiaruki.SetActive(false);
                workSyashinzyutsu.SetActive(false);
                workSeshinbunseki.SetActive(false);
                workTsuiseki.SetActive(false);
                workTouhan.SetActive(false);
                workTosyokan.SetActive(false);
                workMeboshi.SetActive(false);

                workUnten.SetActive(false);
                workKikaisyuri.SetActive(false);
                workZyukikaisosa.SetActive(false);
                workZyoba.SetActive(false);
                workSuiei.SetActive(false);
                workSesaku.SetActive(false);
                workSozyu.SetActive(false);
                workTyoyaku.SetActive(false);
                workDenkisyuri.SetActive(false);
                workNabigeto.SetActive(false);
                workHensou.SetActive(false);

                workIikurume.SetActive(false);
                workShinyo.SetActive(false);
                workSettoku.SetActive(false);
                workNegiri.SetActive(false);
                workBokokugo.SetActive(false);

                workIgaku.SetActive(false);
                workOkaruto.SetActive(false);
                workKagaku.SetActive(false);
                workShinwa.SetActive(false);
                workGezyutsu.SetActive(false);
                workKeiri.SetActive(false);
                workKokogaku.SetActive(false);
                workPC.SetActive(false);
                workShinrigaku.SetActive(false);
                workZinruigaku.SetActive(false);
                workSebutsugaku.SetActive(false);
                workTishitsugaku.SetActive(false);
                workDenshikougaku.SetActive(false);
                workTenmongaku.SetActive(false);
                workHakubutsugaku.SetActive(false);
                workButsurigaku.SetActive(false);
                workHouritsu.SetActive(false);
                workYakugaku.SetActive(false);
                workRekishi.SetActive(false);
                Konmaigo.SetActive(true);
                break;
        }
    }

    //取得技能パネルの変更
    public void ChoicePanel()
    {
        if ((choicePanel == 1) && (NRButton))
        {
            BattlePanel.SetActive(false);
            SearchPanel.SetActive(true);
        }
        else if ((choicePanel == 1) && (!NRButton))
        {
            BattlePanel.SetActive(false);
            BrainPanel.SetActive(true);
        }
        if ((choicePanel == 2) && (NRButton))
        {
            SearchPanel.SetActive(false);
            ActionPanel.SetActive(true);
        }
        else if ((choicePanel == 2) && (!NRButton))
        {
            SearchPanel.SetActive(false);
            BattlePanel.SetActive(true);
        }
        if ((choicePanel == 3) && (NRButton))
        {
            ActionPanel.SetActive(false);
            TalkPanel.SetActive(true);
        }
        else if ((choicePanel == 3) && (!NRButton))
        {
            ActionPanel.SetActive(false);
            SearchPanel.SetActive(true);
        }
        if ((choicePanel == 4) && (NRButton))
        {
            TalkPanel.SetActive(false);
            BrainPanel.SetActive(true);
        }
        else if ((choicePanel == 4) && (!NRButton))
        {
            TalkPanel.SetActive(false);
            ActionPanel.SetActive(true);
        }
        if ((choicePanel == 5) && (NRButton))
        {
            BrainPanel.SetActive(false);
            BattlePanel.SetActive(true);
        }
        else if ((choicePanel == 5) && (!NRButton))
        {
            BrainPanel.SetActive(false);
            TalkPanel.SetActive(true);
        }
    }
    public void ButtonN(int Button)
    {
        switch (Button)
        {
            case 0:
                choicePanel = 1;
                NRButton = true;
                break;
            case 1:
                choicePanel = 2;
                NRButton = true;
                break;
            case 2:
                choicePanel = 3;
                NRButton = true;
                break;
            case 3:
                choicePanel = 4;
                NRButton = true;
                break;
            case 4:
                choicePanel = 5;
                NRButton = true;
                break;
        }
    }
    public void ButtonR(int Button)
    {
        switch (Button)
        {
            case 0:
                choicePanel = 1;
                NRButton = false;
                break;
            case 1:
                choicePanel = 2;
                NRButton = false;
                break;
            case 2:
                choicePanel = 3;
                NRButton = false;
                break;
            case 3:
                choicePanel = 4;
                NRButton = false;
                break;
            case 4:
                choicePanel = 5;
                NRButton = false;
                break;
        }
    }

    //職業技能ポイント入力
    public void InputWorkP(int InputWorkPNo)
    {
        switch (InputWorkPNo)
        {
            //戦闘技能ステータス
            case 0:     //回避
                if ((int.Parse(InputWorkPKaihi.text) + int.Parse(InputHobbyPKaihi.text) + status[0]) > limit)
                {
                    InputWorkPKaihi.text = (limit - status[0] - int.Parse(InputHobbyPKaihi.text)).ToString();
                }
                else if (int.Parse(InputWorkPKaihi.text) < 0)
                {
                    InputWorkPKaihi.text = "0";
                }
                kaihi = int.Parse(InputWorkPKaihi.text);
                if (StatusManager.Instance.WorkP < kaihi)
                {
                    kaihi = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kaihi += kaihi;
                    InputWorkPKaihi.text = kaihi.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kaihi;
                    StatusManager.Instance.Kaihi -= inputworkp[0];
                    StatusManager.Instance.Kaihi += kaihi;
                    StatusManager.Instance.WorkP += inputworkp[0];
                }
                NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                inputworkp[0] = kaihi;
                Afterstatus[0] = StatusManager.Instance.Kaihi;
                break;
            case 1:     //キック
                if ((int.Parse(InputWorkPKikku.text) + int.Parse(InputHobbyPKikku.text) + status[1]) > limit)
                {
                    InputWorkPKikku.text = (limit - status[1] - int.Parse(InputHobbyPKikku.text)).ToString();
                }
                else if (int.Parse(InputWorkPKikku.text) < 0)
                {
                    InputWorkPKikku.text = "0";
                }
                kikku = int.Parse(InputWorkPKikku.text);
                if (StatusManager.Instance.WorkP < kikku)
                {
                    kikku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kikku += kikku;
                    InputWorkPKikku.text = kikku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kikku;
                    StatusManager.Instance.Kikku -= inputworkp[1];
                    StatusManager.Instance.Kikku += kikku;
                    StatusManager.Instance.WorkP += inputworkp[1];
                }
                NowKikku.text = StatusManager.Instance.Kikku.ToString();
                inputworkp[1] = kikku;
                Afterstatus[1] = StatusManager.Instance.Kikku;
                break;
            case 2:     //組み付き
                if ((int.Parse(InputWorkPKumitsuki.text) + int.Parse(InputHobbyPKumitsuki.text) + status[2]) > limit)
                {
                    InputWorkPKumitsuki.text = (limit - status[2] - int.Parse(InputHobbyPKumitsuki.text)).ToString();
                }
                else if (int.Parse(InputWorkPKumitsuki.text) < 0)
                {
                    InputWorkPKumitsuki.text = "0";
                }
                kumitsuki = int.Parse(InputWorkPKumitsuki.text);
                if (StatusManager.Instance.WorkP < kumitsuki)
                {
                    kumitsuki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kumitsuki += kumitsuki;
                    InputWorkPKumitsuki.text = kumitsuki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kumitsuki;
                    StatusManager.Instance.Kumitsuki -= inputworkp[2];
                    StatusManager.Instance.Kumitsuki += kumitsuki;
                    StatusManager.Instance.WorkP += inputworkp[2];
                }
                NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                inputworkp[2] = kumitsuki;
                Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                break;
            case 3:     //こぶし
                if ((int.Parse(InputWorkPKobushi.text) + int.Parse(InputHobbyPKobushi.text) + status[3]) > limit)
                {
                    InputWorkPKobushi.text = (limit - status[3] - int.Parse(InputHobbyPKobushi.text)).ToString();
                }
                else if (int.Parse(InputWorkPKobushi.text) < 0)
                {
                    InputWorkPKobushi.text = "0";
                }
                kobushi = int.Parse(InputWorkPKobushi.text);
                if (StatusManager.Instance.WorkP < kobushi)
                {
                    kobushi = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kobushi += kobushi;
                    InputWorkPKobushi.text = kobushi.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kobushi;
                    StatusManager.Instance.Kobushi -= inputworkp[3];
                    StatusManager.Instance.Kobushi += kobushi;
                    StatusManager.Instance.WorkP += inputworkp[3];
                }
                NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                inputworkp[3] = kobushi;
                Afterstatus[3] = StatusManager.Instance.Kobushi;
                break;
            case 4:     //頭突き
                if ((int.Parse(InputWorkPZutsuki.text) + int.Parse(InputHobbyPZutsuki.text) + status[4]) > limit)
                {
                    InputWorkPZutsuki.text = (limit - status[4] - int.Parse(InputHobbyPZutsuki.text)).ToString();
                }
                else if (int.Parse(InputWorkPZutsuki.text) < 0)
                {
                    InputWorkPZutsuki.text = "0";
                }
                zutsuki = int.Parse(InputWorkPZutsuki.text);
                if (StatusManager.Instance.WorkP < zutsuki)
                {
                    zutsuki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Zutsuki += zutsuki;
                    InputWorkPZutsuki.text = zutsuki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= zutsuki;
                    StatusManager.Instance.Zutsuki -= inputworkp[4];
                    StatusManager.Instance.Zutsuki += zutsuki;
                    StatusManager.Instance.WorkP += inputworkp[4];
                }
                NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                inputworkp[4] = zutsuki;
                Afterstatus[4] = StatusManager.Instance.Zutsuki;
                break;
            case 5:     //投擲
                if ((int.Parse(InputWorkPToteki.text) + int.Parse(InputHobbyPToteki.text) + status[5]) > limit)
                {
                    InputWorkPToteki.text = (limit - status[5] - int.Parse(InputHobbyPToteki.text)).ToString();
                }
                else if (int.Parse(InputWorkPToteki.text) < 0)
                {
                    InputWorkPToteki.text = "0";
                }
                toteki = int.Parse(InputWorkPToteki.text);
                if (StatusManager.Instance.WorkP < toteki)
                {
                    toteki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Toteki += toteki;
                    InputWorkPToteki.text = toteki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= toteki;
                    StatusManager.Instance.Toteki -= inputworkp[5];
                    StatusManager.Instance.Toteki += toteki;
                    StatusManager.Instance.WorkP += inputworkp[5];
                }
                NowToteki.text = StatusManager.Instance.Toteki.ToString();
                inputworkp[5] = toteki;
                Afterstatus[5] = StatusManager.Instance.Toteki;
                break;
            case 6:     //マーシャルアーツ
                if ((int.Parse(InputWorkPMSA.text) + int.Parse(InputHobbyPMSA.text) + status[6]) > limit)
                {
                    InputWorkPMSA.text = (limit - status[6] - int.Parse(InputHobbyPMSA.text)).ToString();
                }
                else if (int.Parse(InputWorkPMSA.text) < 0)
                {
                    InputWorkPMSA.text = "0";
                }
                msa = int.Parse(InputWorkPMSA.text);
                if (StatusManager.Instance.WorkP < msa)
                {
                    msa = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.MSA += msa;
                    InputWorkPMSA.text = msa.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= msa;
                    StatusManager.Instance.MSA -= inputworkp[6];
                    StatusManager.Instance.MSA += msa;
                    StatusManager.Instance.WorkP += inputworkp[6];
                }
                NowMSA.text = StatusManager.Instance.MSA.ToString();
                inputworkp[6] = msa;
                Afterstatus[6] = StatusManager.Instance.MSA;
                break;
            case 7:     //拳銃
                if ((int.Parse(InputWorkPKenzyu.text) + int.Parse(InputHobbyPKenzyu.text) + status[7]) > limit)
                {
                    InputWorkPKenzyu.text = (limit - status[7] - int.Parse(InputHobbyPKenzyu.text)).ToString();
                }
                else if (int.Parse(InputWorkPKenzyu.text) < 0)
                {
                    InputWorkPKenzyu.text = "0";
                }
                kenzyu = int.Parse(InputWorkPKenzyu.text);
                if (StatusManager.Instance.WorkP < kenzyu)
                {
                    kenzyu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kenzyu += kenzyu;
                    InputWorkPKenzyu.text = kenzyu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kenzyu;
                    StatusManager.Instance.Kenzyu -= inputworkp[7];
                    StatusManager.Instance.Kenzyu += kenzyu;
                    StatusManager.Instance.WorkP += inputworkp[7];
                }
                NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                inputworkp[7] = kenzyu;
                Afterstatus[7] = StatusManager.Instance.Kenzyu;
                break;
            case 8:     //サブマシンガン
                if ((int.Parse(InputWorkPSMG.text) + int.Parse(InputHobbyPSMG.text) + status[8]) > limit)
                {
                    InputWorkPSMG.text = (limit - status[8] - int.Parse(InputHobbyPSMG.text)).ToString();
                }
                else if (int.Parse(InputWorkPSMG.text) < 0)
                {
                    InputWorkPSMG.text = "0";
                }
                smg = int.Parse(InputWorkPSMG.text);
                if (StatusManager.Instance.WorkP < smg)
                {
                    smg = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.SMG += smg;
                    InputWorkPSMG.text = smg.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= smg;
                    StatusManager.Instance.SMG -= inputworkp[8];
                    StatusManager.Instance.SMG += smg;
                    StatusManager.Instance.WorkP += inputworkp[8];
                }
                NowSMG.text = StatusManager.Instance.SMG.ToString();
                inputworkp[8] = smg;
                Afterstatus[8] = StatusManager.Instance.SMG;
                break;
            case 9:     //ショットガン
                if ((int.Parse(InputWorkPSG.text) + int.Parse(InputHobbyPSG.text) + status[9]) > limit)
                {
                    InputWorkPSG.text = (limit - status[9] - int.Parse(InputHobbyPSG.text)).ToString();
                }
                else if (int.Parse(InputWorkPSG.text) < 0)
                {
                    InputWorkPSG.text = "0";
                }
                sg = int.Parse(InputWorkPSG.text);
                if (StatusManager.Instance.WorkP < sg)
                {
                    sg = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.SG += sg;
                    InputWorkPSG.text = sg.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= sg;
                    StatusManager.Instance.SG -= inputworkp[9];
                    StatusManager.Instance.SG += sg;
                    StatusManager.Instance.WorkP += inputworkp[9];
                }
                NowSG.text = StatusManager.Instance.SG.ToString();
                inputworkp[9] = sg;
                Afterstatus[9] = StatusManager.Instance.SG;
                break;
            case 10:        //マシンガン
                if ((int.Parse(InputWorkPMG.text) + int.Parse(InputHobbyPMG.text) + status[10]) > limit)
                {
                    InputWorkPMG.text = (limit - status[10] - int.Parse(InputHobbyPMG.text)).ToString();
                }
                else if (int.Parse(InputWorkPMG.text) < 0)
                {
                    InputWorkPMG.text = "0";
                }
                mg = int.Parse(InputWorkPMG.text);
                if (StatusManager.Instance.WorkP < mg)
                {
                    mg = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.MG += mg;
                    InputWorkPMG.text = mg.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= mg;
                    StatusManager.Instance.MG -= inputworkp[10];
                    StatusManager.Instance.MG += mg;
                    StatusManager.Instance.WorkP += inputworkp[10];
                }
                NowMG.text = StatusManager.Instance.MG.ToString();
                inputworkp[10] = mg;
                Afterstatus[10] = StatusManager.Instance.MG;
                break;
            case 11:        //ライフル
                if ((int.Parse(InputWorkPR.text) + int.Parse(InputHobbyPR.text) + status[11]) > limit)
                {
                    InputWorkPR.text = (limit - status[11] - int.Parse(InputHobbyPR.text)).ToString();
                }
                else if (int.Parse(InputWorkPR.text) < 0)
                {
                    InputWorkPR.text = "0";
                }
                r = int.Parse(InputWorkPR.text);
                if (StatusManager.Instance.WorkP < r)
                {
                    r = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.R += r;
                    InputWorkPR.text = r.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= r;
                    StatusManager.Instance.R -= inputworkp[11];
                    StatusManager.Instance.R += r;
                    StatusManager.Instance.WorkP += inputworkp[11];
                }
                NowR.text = StatusManager.Instance.R.ToString();
                inputworkp[11] = r;
                Afterstatus[11] = StatusManager.Instance.R;
                break;

            //探索技能ステータス
            case 100:        //応急手当
                if ((int.Parse(InputWorkPOkyuteate.text) + int.Parse(InputHobbyPOkyuteate.text) + status[12]) > limit)
                {
                    InputWorkPOkyuteate.text = (limit - status[12] - int.Parse(InputHobbyPOkyuteate.text)).ToString();
                }
                else if (int.Parse(InputWorkPOkyuteate.text) < 0)
                {
                    InputWorkPOkyuteate.text = "0";
                }
                okyuteate = int.Parse(InputWorkPOkyuteate.text);
                if (StatusManager.Instance.WorkP < okyuteate)
                {
                    okyuteate = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Okyuteate += okyuteate;
                    InputWorkPOkyuteate.text = okyuteate.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= okyuteate;
                    StatusManager.Instance.Okyuteate -= inputworkp[12];
                    StatusManager.Instance.Okyuteate += okyuteate;
                    StatusManager.Instance.WorkP += inputworkp[12];
                }
                NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                inputworkp[12] = okyuteate;
                Afterstatus[12] = StatusManager.Instance.Okyuteate;
                break;
            case 101:        //鍵開け
                if ((int.Parse(InputWorkPKagiake.text) + int.Parse(InputHobbyPKagiake.text) + status[13]) > limit)
                {
                    InputWorkPKagiake.text = (limit - status[13] - int.Parse(InputHobbyPKagiake.text)).ToString();
                }
                else if (int.Parse(InputWorkPKagiake.text) < 0)
                {
                    InputWorkPKagiake.text = "0";
                }
                kagiake = int.Parse(InputWorkPKagiake.text);
                if (StatusManager.Instance.WorkP < kagiake)
                {
                    kagiake = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kagiake += kagiake;
                    InputWorkPKagiake.text = kagiake.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kagiake;
                    StatusManager.Instance.Kagiake -= inputworkp[13];
                    StatusManager.Instance.Kagiake += kagiake;
                    StatusManager.Instance.WorkP += inputworkp[13];
                }
                NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                inputworkp[13] = kagiake;
                Afterstatus[13] = StatusManager.Instance.Kagiake;
                break;
            case 102:        //隠す
                if ((int.Parse(InputWorkPKakusu.text) + int.Parse(InputHobbyPKakusu.text) + status[14]) > limit)
                {
                    InputWorkPKakusu.text = (limit - status[14] - int.Parse(InputHobbyPKakusu.text)).ToString();
                }
                else if (int.Parse(InputWorkPKakusu.text) < 0)
                {
                    InputWorkPKakusu.text = "0";
                }
                kakusu = int.Parse(InputWorkPKakusu.text);
                if (StatusManager.Instance.WorkP < kakusu)
                {
                    kakusu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kakusu += kakusu;
                    InputWorkPKakusu.text = kakusu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kakusu;
                    StatusManager.Instance.Kakusu -= inputworkp[14];
                    StatusManager.Instance.Kakusu += kakusu;
                    StatusManager.Instance.WorkP += inputworkp[14];
                }
                NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                inputworkp[14] = kakusu;
                Afterstatus[14] = StatusManager.Instance.Kakusu;
                break;
            case 103:        //隠れる
                if ((int.Parse(InputWorkPKakureru.text) + int.Parse(InputHobbyPKakureru.text) + status[15]) > limit)
                {
                    InputWorkPKakureru.text = (limit - status[15] - int.Parse(InputHobbyPKakureru.text)).ToString();
                }
                else if (int.Parse(InputWorkPKakureru.text) < 0)
                {
                    InputWorkPKakureru.text = "0";
                }
                kakureru = int.Parse(InputWorkPKakureru.text);
                if (StatusManager.Instance.WorkP < kakureru)
                {
                    kakureru = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kakureru += kakureru;
                    InputWorkPKakureru.text = kakureru.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kakureru;
                    StatusManager.Instance.Kakureru -= inputworkp[15];
                    StatusManager.Instance.Kakureru += kakureru;
                    StatusManager.Instance.WorkP += inputworkp[15];
                }
                NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                inputworkp[15] = kakureru;
                Afterstatus[15] = StatusManager.Instance.Kakureru;
                break;
            case 104:        //聞き耳
                if ((int.Parse(InputWorkPKikimimi.text) + int.Parse(InputHobbyPKikimimi.text) + status[16]) > limit)
                {
                    InputWorkPKikimimi.text = (limit - status[16] - int.Parse(InputHobbyPKikimimi.text)).ToString();
                }
                else if (int.Parse(InputWorkPKikimimi.text) < 0)
                {
                    InputWorkPKikimimi.text = "0";
                }
                kikimimi = int.Parse(InputWorkPKikimimi.text);
                if (StatusManager.Instance.WorkP < kikimimi)
                {
                    kikimimi = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kikimimi += kikimimi;
                    InputWorkPKikimimi.text = kikimimi.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kikimimi;
                    StatusManager.Instance.Kikimimi -= inputworkp[16];
                    StatusManager.Instance.Kikimimi += kikimimi;
                    StatusManager.Instance.WorkP += inputworkp[16];
                }
                NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                inputworkp[16] = kikimimi;
                Afterstatus[16] = StatusManager.Instance.Kikimimi;
                break;
            case 105:        //忍び歩き
                if ((int.Parse(InputWorkPShinobiaruki.text) + int.Parse(InputHobbyPShinobiaruki.text) + status[17]) > limit)
                {
                    InputWorkPShinobiaruki.text = (limit - status[17] - int.Parse(InputHobbyPShinobiaruki.text)).ToString();
                }
                else if (int.Parse(InputWorkPShinobiaruki.text) < 0)
                {
                    InputWorkPShinobiaruki.text = "0";
                }
                shinobiaruki = int.Parse(InputWorkPShinobiaruki.text);
                if (StatusManager.Instance.WorkP < shinobiaruki)
                {
                    shinobiaruki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Shinobiaruki += shinobiaruki;
                    InputWorkPShinobiaruki.text = shinobiaruki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= shinobiaruki;
                    StatusManager.Instance.Shinobiaruki -= inputworkp[17];
                    StatusManager.Instance.Shinobiaruki += shinobiaruki;
                    StatusManager.Instance.WorkP += inputworkp[17];
                }
                NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                inputworkp[17] = shinobiaruki;
                Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                break;
            case 106:        //写真術
                if ((int.Parse(InputWorkPSyashinzyutsu.text) + int.Parse(InputHobbyPSyashinzyutsu.text) + status[18]) > limit)
                {
                    InputWorkPSyashinzyutsu.text = (limit - status[18] - int.Parse(InputHobbyPSyashinzyutsu.text)).ToString();
                }
                else if (int.Parse(InputWorkPSyashinzyutsu.text) < 0)
                {
                    InputWorkPSyashinzyutsu.text = "0";
                }
                syashinzyutsu = int.Parse(InputWorkPSyashinzyutsu.text);
                if (StatusManager.Instance.WorkP < syashinzyutsu)
                {
                    syashinzyutsu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Syashinzyutsu += syashinzyutsu;
                    InputWorkPSyashinzyutsu.text = syashinzyutsu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= syashinzyutsu;
                    StatusManager.Instance.Syashinzyutsu -= inputworkp[18];
                    StatusManager.Instance.Syashinzyutsu += syashinzyutsu;
                    StatusManager.Instance.WorkP += inputworkp[18];
                }
                NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                inputworkp[18] = syashinzyutsu;
                Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                break;
            case 107:        //精神分析
                if ((int.Parse(InputWorkPSeshinbunseki.text) + int.Parse(InputHobbyPSeshinbunseki.text) + status[19]) > limit)
                {
                    InputWorkPSeshinbunseki.text = (limit - status[19] - int.Parse(InputHobbyPSeshinbunseki.text)).ToString();
                }
                else if (int.Parse(InputWorkPSeshinbunseki.text) < 0)
                {
                    InputWorkPSeshinbunseki.text = "0";
                }
                seshinbunseki = int.Parse(InputWorkPSeshinbunseki.text);
                if (StatusManager.Instance.WorkP < seshinbunseki)
                {
                    seshinbunseki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Seshinbunseki += seshinbunseki;
                    InputWorkPSeshinbunseki.text = seshinbunseki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= seshinbunseki;
                    StatusManager.Instance.Seshinbunseki -= inputworkp[19];
                    StatusManager.Instance.Seshinbunseki += seshinbunseki;
                    StatusManager.Instance.WorkP += inputworkp[19];
                }
                NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                inputworkp[19] = seshinbunseki;
                Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                break;
            case 108:        //追跡
                if ((int.Parse(InputWorkPTsuiseki.text) + int.Parse(InputHobbyPTsuiseki.text) + status[20]) > limit)
                {
                    InputWorkPTsuiseki.text = (limit - status[20] - int.Parse(InputHobbyPTsuiseki.text)).ToString();
                }
                else if (int.Parse(InputWorkPTsuiseki.text) < 0)
                {
                    InputWorkPTsuiseki.text = "0";
                }
                tsuiseki = int.Parse(InputWorkPTsuiseki.text);
                if (StatusManager.Instance.WorkP < tsuiseki)
                {
                    tsuiseki = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Tsuiseki += tsuiseki;
                    InputWorkPTsuiseki.text = tsuiseki.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= tsuiseki;
                    StatusManager.Instance.Tsuiseki -= inputworkp[20];
                    StatusManager.Instance.Tsuiseki += tsuiseki;
                    StatusManager.Instance.WorkP += inputworkp[20];
                }
                NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                inputworkp[20] = tsuiseki;
                Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                break;
            case 109:        //登攀
                if ((int.Parse(InputWorkPTouhan.text) + int.Parse(InputHobbyPTouhan.text) + status[21]) > limit)
                {
                    InputWorkPTouhan.text = (limit - status[21] - int.Parse(InputHobbyPTouhan.text)).ToString();
                }
                else if (int.Parse(InputWorkPTouhan.text) < 0)
                {
                    InputWorkPTouhan.text = "0";
                }
                touhan = int.Parse(InputWorkPTouhan.text);
                if (StatusManager.Instance.WorkP < touhan)
                {
                    touhan = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Touhan += touhan;
                    InputWorkPTouhan.text = touhan.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= touhan;
                    StatusManager.Instance.Touhan -= inputworkp[21];
                    StatusManager.Instance.Touhan += touhan;
                    StatusManager.Instance.WorkP += inputworkp[21];
                }
                NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                inputworkp[21] = touhan;
                Afterstatus[21] = StatusManager.Instance.Touhan;
                break;
            case 110:        //図書館
                if ((int.Parse(InputWorkPTosyokan.text) + int.Parse(InputHobbyPTosyokan.text) + status[22]) > limit)
                {
                    InputWorkPTosyokan.text = (limit - status[22] - int.Parse(InputHobbyPTosyokan.text)).ToString();
                }
                else if (int.Parse(InputWorkPTosyokan.text) < 0)
                {
                    InputWorkPTosyokan.text = "0";
                }
                tosyokan = int.Parse(InputWorkPTosyokan.text);
                if (StatusManager.Instance.WorkP < tosyokan)
                {
                    tosyokan = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Tosyokan += tosyokan;
                    InputWorkPTosyokan.text = tosyokan.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= tosyokan;
                    StatusManager.Instance.Tosyokan -= inputworkp[22];
                    StatusManager.Instance.Tosyokan += tosyokan;
                    StatusManager.Instance.WorkP += inputworkp[22];
                }
                NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                inputworkp[22] = tosyokan;
                Afterstatus[22] = StatusManager.Instance.Tosyokan;
                break;
            case 111:        //目星
                if ((int.Parse(InputWorkPMeboshi.text) + int.Parse(InputHobbyPMeboshi.text) + status[23]) > limit)
                {
                    InputWorkPMeboshi.text = (limit - status[23] - int.Parse(InputHobbyPMeboshi.text)).ToString();
                }
                else if (int.Parse(InputWorkPMeboshi.text) < 0)
                {
                    InputWorkPMeboshi.text = "0";
                }
                meboshi = int.Parse(InputWorkPMeboshi.text);
                if (StatusManager.Instance.WorkP < meboshi)
                {
                    meboshi = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Meboshi += meboshi;
                    InputWorkPMeboshi.text = meboshi.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= meboshi;
                    StatusManager.Instance.Meboshi -= inputworkp[23];
                    StatusManager.Instance.Meboshi += meboshi;
                    StatusManager.Instance.WorkP += inputworkp[23];
                }
                NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                inputworkp[23] = meboshi;
                Afterstatus[23] = StatusManager.Instance.Meboshi;
                break;

            //行動技能ステータス
            case 200:        //運転
                if ((int.Parse(InputWorkPUnten.text) + int.Parse(InputHobbyPUnten.text) + status[24]) > limit)
                {
                    InputWorkPUnten.text = (limit - status[24] - int.Parse(InputHobbyPUnten.text)).ToString();
                }
                else if (int.Parse(InputWorkPUnten.text) < 0)
                {
                    InputWorkPUnten.text = "0";
                }
                unten = int.Parse(InputWorkPUnten.text);
                if (StatusManager.Instance.WorkP < unten)
                {
                    unten = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Unten += unten;
                    InputWorkPUnten.text = unten.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= unten;
                    StatusManager.Instance.Unten -= inputworkp[24];
                    StatusManager.Instance.Unten += unten;
                    StatusManager.Instance.WorkP += inputworkp[24];
                }
                NowUnten.text = StatusManager.Instance.Unten.ToString();
                inputworkp[24] = unten;
                Afterstatus[24] = StatusManager.Instance.Unten;
                break;
            case 201:        //機械修理
                if ((int.Parse(InputWorkPKikaisyuri.text) + int.Parse(InputHobbyPKikaisyuri.text) + status[25]) > limit)
                {
                    InputWorkPKikaisyuri.text = (limit - status[25] - int.Parse(InputHobbyPKikaisyuri.text)).ToString();
                }
                else if (int.Parse(InputWorkPKikaisyuri.text) < 0)
                {
                    InputWorkPKikaisyuri.text = "0";
                }
                kikaisyuri = int.Parse(InputWorkPKikaisyuri.text);
                if (StatusManager.Instance.WorkP < kikaisyuri)
                {
                    kikaisyuri = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kikaisyuri += kikaisyuri;
                    InputWorkPKikaisyuri.text = kikaisyuri.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kikaisyuri;
                    StatusManager.Instance.Kikaisyuri -= inputworkp[25];
                    StatusManager.Instance.Kikaisyuri += kikaisyuri;
                    StatusManager.Instance.WorkP += inputworkp[25];
                }
                NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                inputworkp[25] = kikaisyuri;
                Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                break;
            case 202:        //重機械操作
                if ((int.Parse(InputWorkPZyukikaisosa.text) + int.Parse(InputHobbyPZyukikaisosa.text) + status[26]) > limit)
                {
                    InputWorkPZyukikaisosa.text = (limit - status[26] - int.Parse(InputHobbyPZyukikaisosa.text)).ToString();
                }
                else if (int.Parse(InputWorkPZyukikaisosa.text) < 0)
                {
                    InputWorkPZyukikaisosa.text = "0";
                }
                zyukikaisosa = int.Parse(InputWorkPZyukikaisosa.text);
                if (StatusManager.Instance.WorkP < zyukikaisosa)
                {
                    zyukikaisosa = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Zyukikaisosa += zyukikaisosa;
                    InputWorkPZyukikaisosa.text = zyukikaisosa.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= zyukikaisosa;
                    StatusManager.Instance.Zyukikaisosa -= inputworkp[26];
                    StatusManager.Instance.Zyukikaisosa += zyukikaisosa;
                    StatusManager.Instance.WorkP += inputworkp[26];
                }
                NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                inputworkp[26] = zyukikaisosa;
                Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                break;
            case 203:        //乗馬
                if ((int.Parse(InputWorkPZyoba.text) + int.Parse(InputHobbyPZyoba.text) + status[27]) > limit)
                {
                    InputWorkPZyoba.text = (limit - status[27] - int.Parse(InputHobbyPZyoba.text)).ToString();
                }
                else if (int.Parse(InputWorkPZyoba.text) < 0)
                {
                    InputWorkPZyoba.text = "0";
                }
                zyoba = int.Parse(InputWorkPZyoba.text);
                if (StatusManager.Instance.WorkP < zyoba)
                {
                    zyoba = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Zyoba += zyoba;
                    InputWorkPZyoba.text = zyoba.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= zyoba;
                    StatusManager.Instance.Zyoba = inputworkp[27];
                    StatusManager.Instance.Zyoba += zyoba;
                    StatusManager.Instance.WorkP += inputworkp[27];
                }
                NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                inputworkp[27] = zyoba;
                Afterstatus[27] = StatusManager.Instance.Zyoba;
                break;
            case 204:        //水泳
                if ((int.Parse(InputWorkPSuiei.text) + int.Parse(InputHobbyPSuiei.text) + status[28]) > limit)
                {
                    InputWorkPSuiei.text = (limit - status[28] - int.Parse(InputHobbyPSuiei.text)).ToString();
                }
                else if (int.Parse(InputWorkPSuiei.text) < 0)
                {
                    InputWorkPSuiei.text = "0";
                }
                suiei = int.Parse(InputWorkPSuiei.text);
                if (StatusManager.Instance.WorkP < suiei)
                {
                    suiei = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Suiei += suiei;
                    InputWorkPSuiei.text = suiei.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= suiei;
                    StatusManager.Instance.Suiei -= inputworkp[28];
                    StatusManager.Instance.Suiei += suiei;
                    StatusManager.Instance.WorkP += inputworkp[28];
                }
                NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                inputworkp[28] = suiei;
                Afterstatus[28] = StatusManager.Instance.Suiei;
                break;
            case 205:        //制作
                if ((int.Parse(InputWorkPSesaku.text) + int.Parse(InputHobbyPSesaku.text) + status[29]) > limit)
                {
                    InputWorkPSesaku.text = (limit - status[29] - int.Parse(InputHobbyPSesaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPSesaku.text) < 0)
                {
                    InputWorkPSesaku.text = "0";
                }
                sesaku = int.Parse(InputWorkPSesaku.text);
                if (StatusManager.Instance.WorkP < sesaku)
                {
                    sesaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Sesaku += sesaku;
                    InputWorkPSesaku.text = sesaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= sesaku;
                    StatusManager.Instance.Sesaku -= inputworkp[29];
                    StatusManager.Instance.Sesaku += sesaku;
                    StatusManager.Instance.WorkP += inputworkp[29];
                }
                NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                inputworkp[29] = sesaku;
                Afterstatus[29] = StatusManager.Instance.Sesaku;
                break;
            case 206:        //操縦
                if ((int.Parse(InputWorkPSozyu.text) + int.Parse(InputHobbyPSozyu.text) + status[30]) > limit)
                {
                    InputWorkPSozyu.text = (limit - status[30] - int.Parse(InputHobbyPSozyu.text)).ToString();
                }
                else if (int.Parse(InputWorkPSozyu.text) < 0)
                {
                    InputWorkPSozyu.text = "0";
                }
                sozyu = int.Parse(InputWorkPSozyu.text);
                if (StatusManager.Instance.WorkP < sozyu)
                {
                    sozyu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Sozyu += sozyu;
                    InputWorkPSozyu.text = sozyu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= sozyu;
                    StatusManager.Instance.Sozyu -= inputworkp[30];
                    StatusManager.Instance.Sozyu += sozyu;
                    StatusManager.Instance.WorkP += inputworkp[30];
                }
                NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                inputworkp[30] = sozyu;
                Afterstatus[30] = StatusManager.Instance.Sozyu;
                break;
            case 207:        //跳躍
                if ((int.Parse(InputWorkPTyoyaku.text) + int.Parse(InputHobbyPTyoyaku.text) + status[31]) > limit)
                {
                    InputWorkPTyoyaku.text = (limit - status[31] - int.Parse(InputHobbyPTyoyaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPTyoyaku.text) < 0)
                {
                    InputWorkPTyoyaku.text = "0";
                }
                tyoyaku = int.Parse(InputWorkPTyoyaku.text);
                if (StatusManager.Instance.WorkP < tyoyaku)
                {
                    tyoyaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Tyoyaku += tyoyaku;
                    InputWorkPTyoyaku.text = tyoyaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= tyoyaku;
                    StatusManager.Instance.Tyoyaku -= inputworkp[31];
                    StatusManager.Instance.Tyoyaku += tyoyaku;
                    StatusManager.Instance.WorkP += inputworkp[31];
                }
                NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                inputworkp[31] = tyoyaku;
                Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                break;
            case 208:        //電気修理
                if ((int.Parse(InputWorkPDenkisyuri.text) + int.Parse(InputHobbyPDenkisyuri.text) + status[32]) > limit)
                {
                    InputWorkPDenkisyuri.text = (limit - status[32] - int.Parse(InputHobbyPDenkisyuri.text)).ToString();
                }
                else if (int.Parse(InputWorkPDenkisyuri.text) < 0)
                {
                    InputWorkPDenkisyuri.text = "0";
                }
                denkisyuri = int.Parse(InputWorkPDenkisyuri.text);
                if (StatusManager.Instance.WorkP < denkisyuri)
                {
                    denkisyuri = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Denkisyuri += denkisyuri;
                    InputWorkPDenkisyuri.text = denkisyuri.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= denkisyuri;
                    StatusManager.Instance.Denkisyuri -= inputworkp[32];
                    StatusManager.Instance.Denkisyuri += denkisyuri;
                    StatusManager.Instance.WorkP += inputworkp[32];
                }
                NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                inputworkp[32] = denkisyuri;
                Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                break;
            case 209:        //ナビゲート
                if ((int.Parse(InputWorkPNabigeto.text) + int.Parse(InputHobbyPNabigeto.text) + status[33]) > limit)
                {
                    InputWorkPNabigeto.text = (limit - status[33] - int.Parse(InputHobbyPNabigeto.text)).ToString();
                }
                else if (int.Parse(InputWorkPNabigeto.text) < 0)
                {
                    InputWorkPNabigeto.text = "0";
                }
                nabigeto = int.Parse(InputWorkPNabigeto.text);
                if (StatusManager.Instance.WorkP < nabigeto)
                {
                    nabigeto = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Nabigeto += nabigeto;
                    InputWorkPNabigeto.text = nabigeto.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= nabigeto;
                    StatusManager.Instance.Nabigeto -= inputworkp[33];
                    StatusManager.Instance.Nabigeto += nabigeto;
                    StatusManager.Instance.WorkP += inputworkp[33];
                }
                NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                inputworkp[33] = nabigeto;
                Afterstatus[33] = StatusManager.Instance.Nabigeto;
                break;
            case 210:        //変装
                if ((int.Parse(InputWorkPHensou.text) + int.Parse(InputHobbyPHensou.text) + status[34]) > limit)
                {
                    InputWorkPHensou.text = (limit - status[34] - int.Parse(InputHobbyPHensou.text)).ToString();
                }
                else if (int.Parse(InputWorkPHensou.text) < 0)
                {
                    InputWorkPHensou.text = "0";
                }
                hensou = int.Parse(InputWorkPHensou.text);
                if (StatusManager.Instance.WorkP < hensou)
                {
                    hensou = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Hensou += hensou;
                    InputWorkPHensou.text = hensou.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= hensou;
                    StatusManager.Instance.Hensou -= inputworkp[34];
                    StatusManager.Instance.Hensou += hensou;
                    StatusManager.Instance.WorkP += inputworkp[34];
                }
                NowHensou.text = StatusManager.Instance.Hensou.ToString();
                inputworkp[34] = hensou;
                Afterstatus[34] = StatusManager.Instance.Hensou;
                break;

            //交渉技能ステータス
            case 300:        //言いくるめ
                if ((int.Parse(InputWorkPIikurume.text) + int.Parse(InputHobbyPIikurume.text) + status[35]) > limit)
                {
                    InputWorkPIikurume.text = (limit - status[35] - int.Parse(InputHobbyPIikurume.text)).ToString();
                }
                else if (int.Parse(InputWorkPIikurume.text) < 0)
                {
                    InputWorkPIikurume.text = "0";
                }
                iikurume = int.Parse(InputWorkPIikurume.text);
                if (StatusManager.Instance.WorkP < iikurume)
                {
                    iikurume = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Iikurume += iikurume;
                    InputWorkPIikurume.text = iikurume.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= iikurume;
                    StatusManager.Instance.Iikurume -= inputworkp[35];
                    StatusManager.Instance.Iikurume += iikurume;
                    StatusManager.Instance.WorkP += inputworkp[35];
                }
                NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                inputworkp[35] = iikurume;
                Afterstatus[35] = StatusManager.Instance.Iikurume;
                break;
            case 301:        //信用
                if ((int.Parse(InputWorkPShinyou.text) + int.Parse(InputHobbyPShinyou.text) + status[35]) > limit)
                {
                    InputWorkPShinyou.text = (limit - status[35] - int.Parse(InputHobbyPShinyou.text)).ToString();
                }
                else if (int.Parse(InputWorkPShinyou.text) < 0)
                {
                    InputWorkPShinyou.text = "0";
                }
                shinyou = int.Parse(InputWorkPShinyou.text);
                if (StatusManager.Instance.WorkP < shinyou)
                {
                    shinyou = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Shinyou += shinyou;
                    InputWorkPShinyou.text = shinyou.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= shinyou;
                    StatusManager.Instance.Shinyou -= inputworkp[36];
                    StatusManager.Instance.Shinyou += shinyou;
                    StatusManager.Instance.WorkP += inputworkp[36];
                }
                NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                inputworkp[36] = shinyou;
                Afterstatus[36] = StatusManager.Instance.Shinyou;
                break;
            case 302:        //説得
                if ((int.Parse(InputWorkPSettoku.text) + int.Parse(InputHobbyPSettoku.text) + status[37]) > limit)
                {
                    InputWorkPSettoku.text = (limit - status[37] - int.Parse(InputHobbyPSettoku.text)).ToString();
                }
                else if (int.Parse(InputWorkPSettoku.text) < 0)
                {
                    InputWorkPSettoku.text = "0";
                }
                settoku = int.Parse(InputWorkPSettoku.text);
                if (StatusManager.Instance.WorkP < settoku)
                {
                    settoku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Settoku += settoku;
                    InputWorkPSettoku.text = settoku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= settoku;
                    StatusManager.Instance.Settoku -= inputworkp[37];
                    StatusManager.Instance.Settoku += settoku;
                    StatusManager.Instance.WorkP += inputworkp[37];
                }
                NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                inputworkp[37] = settoku;
                Afterstatus[37] = StatusManager.Instance.Settoku;
                break;
            case 303:        //値切り
                if ((int.Parse(InputWorkPNegiri.text) + int.Parse(InputHobbyPNegiri.text) + status[38]) > limit)
                {
                    InputWorkPNegiri.text = (limit - status[38] - int.Parse(InputHobbyPNegiri.text)).ToString();
                }
                else if (int.Parse(InputWorkPNegiri.text) < 0)
                {
                    InputWorkPNegiri.text = "0";
                }
                negiri = int.Parse(InputWorkPNegiri.text);
                if (StatusManager.Instance.WorkP < negiri)
                {
                    negiri = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Negiri += negiri;
                    InputWorkPNegiri.text = negiri.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= negiri;
                    StatusManager.Instance.Negiri -= inputworkp[38];
                    StatusManager.Instance.Negiri += negiri;
                    StatusManager.Instance.WorkP += inputworkp[38];
                }
                NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                inputworkp[38] = negiri;
                Afterstatus[38] = StatusManager.Instance.Negiri;
                break;
            case 304:        //母国語
                if ((int.Parse(InputWorkPBokokugo.text) + int.Parse(InputHobbyPBokokugo.text) + status[39]) > limit)
                {
                    InputWorkPBokokugo.text = (limit - status[39] - int.Parse(InputHobbyPBokokugo.text)).ToString();
                }
                else if (int.Parse(InputWorkPBokokugo.text) < 0)
                {
                    InputWorkPBokokugo.text = "0";
                }
                bokokugo = int.Parse(InputWorkPBokokugo.text);
                if (StatusManager.Instance.WorkP < bokokugo)
                {
                    bokokugo = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Bokokugo += bokokugo;
                    InputWorkPBokokugo.text = bokokugo.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= bokokugo;
                    StatusManager.Instance.Bokokugo -= inputworkp[39];
                    StatusManager.Instance.Bokokugo += bokokugo;
                    StatusManager.Instance.WorkP += inputworkp[39];
                }
                NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                inputworkp[39] = bokokugo;
                Afterstatus[39] = StatusManager.Instance.Bokokugo;
                break;

            //知識技能ステータス
            case 400:        //医学
                if ((int.Parse(InputWorkPIgaku.text) + int.Parse(InputHobbyPIgaku.text) + status[40]) > limit)
                {
                    InputWorkPIgaku.text = (limit - status[40] - int.Parse(InputHobbyPIgaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPIgaku.text) < 0)
                {
                    InputWorkPIgaku.text = "0";
                }
                igaku = int.Parse(InputWorkPIgaku.text);
                if (StatusManager.Instance.WorkP < igaku)
                {
                    igaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Igaku += igaku;
                    InputWorkPIgaku.text = igaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= igaku;
                    StatusManager.Instance.Igaku -= inputworkp[40];
                    StatusManager.Instance.Igaku += igaku;
                    StatusManager.Instance.WorkP += inputworkp[40];
                }
                NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                inputworkp[40] = igaku;
                Afterstatus[40] = StatusManager.Instance.Igaku;
                break;
            case 401:        //オカルト
                if ((int.Parse(InputWorkPOkaruto.text) + int.Parse(InputHobbyPOkaruto.text) + status[41]) > limit)
                {
                    InputWorkPOkaruto.text = (limit - status[41] - int.Parse(InputHobbyPOkaruto.text)).ToString();
                }
                else if (int.Parse(InputWorkPOkaruto.text) < 0)
                {
                    InputWorkPOkaruto.text = "0";
                }
                okaruto = int.Parse(InputWorkPOkaruto.text);
                if (StatusManager.Instance.WorkP < okaruto)
                {
                    okaruto = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Okaruto += okaruto;
                    InputWorkPOkaruto.text = okaruto.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= okaruto;
                    StatusManager.Instance.Okaruto -= inputworkp[41];
                    StatusManager.Instance.Okaruto += okaruto;
                    StatusManager.Instance.WorkP += inputworkp[41];
                }
                NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                inputworkp[41] = okaruto;
                Afterstatus[41] = StatusManager.Instance.Okaruto;
                break;
            case 402:        //化学
                if ((int.Parse(InputWorkPKagaku.text) + int.Parse(InputHobbyPKagaku.text) + status[42]) > limit)
                {
                    InputWorkPKagaku.text = (limit - status[42] - int.Parse(InputHobbyPKagaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPKagaku.text) < 0)
                {
                    InputWorkPKagaku.text = "0";
                }
                kagaku = int.Parse(InputWorkPKagaku.text);
                if (StatusManager.Instance.WorkP < kagaku)
                {
                    kagaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kagaku += kagaku;
                    InputWorkPKagaku.text = kagaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kagaku;
                    StatusManager.Instance.Kagaku -= inputworkp[42];
                    StatusManager.Instance.Kagaku += kagaku;
                    StatusManager.Instance.WorkP += inputworkp[42];
                }
                NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                inputworkp[42] = kagaku;
                Afterstatus[42] = StatusManager.Instance.Kagaku;
                break;
            case 403:        //クトゥルフ神話
                if ((int.Parse(InputWorkPShinwa.text) + int.Parse(InputHobbyPShinwa.text) + status[43]) > limit)
                {
                    InputWorkPShinwa.text = (limit - status[43] - int.Parse(InputHobbyPShinwa.text)).ToString();
                }
                else if (int.Parse(InputWorkPShinwa.text) < 0)
                {
                    InputWorkPShinwa.text = "0";
                }
                shinwa = int.Parse(InputWorkPShinwa.text);
                if (StatusManager.Instance.WorkP < shinwa)
                {
                    shinwa = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Shinwa += shinwa;
                    InputWorkPShinwa.text = shinwa.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= shinwa;
                    StatusManager.Instance.Shinwa -= inputworkp[43];
                    StatusManager.Instance.Shinwa += shinwa;
                    StatusManager.Instance.WorkP += inputworkp[43];
                }
                NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                inputworkp[43] = shinwa;
                Afterstatus[43] = StatusManager.Instance.Shinwa;
                break;
            case 404:        //芸術
                if ((int.Parse(InputWorkPGezyutsu.text) + int.Parse(InputHobbyPGezyutsu.text) + status[44]) > limit)
                {
                    InputWorkPGezyutsu.text = (limit - status[44] - int.Parse(InputHobbyPGezyutsu.text)).ToString();
                }
                else if (int.Parse(InputWorkPGezyutsu.text) < 0)
                {
                    InputWorkPGezyutsu.text = "0";
                }
                gezyutsu = int.Parse(InputWorkPGezyutsu.text);
                if (StatusManager.Instance.WorkP < gezyutsu)
                {
                    gezyutsu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Gezyutsu += gezyutsu;
                    InputWorkPGezyutsu.text = gezyutsu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= gezyutsu;
                    StatusManager.Instance.Gezyutsu -= inputworkp[44];
                    StatusManager.Instance.Gezyutsu += gezyutsu;
                    StatusManager.Instance.WorkP += inputworkp[44];
                }
                NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                inputworkp[44] = gezyutsu;
                Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                break;
            case 405:        //経理
                if ((int.Parse(InputWorkPKeiri.text) + int.Parse(InputHobbyPKeiri.text) + status[45]) > limit)
                {
                    InputWorkPKeiri.text = (limit - status[45] - int.Parse(InputHobbyPKeiri.text)).ToString();
                }
                else if (int.Parse(InputWorkPKeiri.text) < 0)
                {
                    InputWorkPKeiri.text = "0";
                }
                keiri = int.Parse(InputWorkPKeiri.text);
                if (StatusManager.Instance.WorkP < keiri)
                {
                    keiri = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Keiri += keiri;
                    InputWorkPKeiri.text = keiri.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= keiri;
                    StatusManager.Instance.Keiri -= inputworkp[45];
                    StatusManager.Instance.Keiri += keiri;
                    StatusManager.Instance.WorkP += inputworkp[45];
                }
                NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                inputworkp[45] = keiri;
                Afterstatus[45] = StatusManager.Instance.Keiri;
                break;
            case 406:        //考古学
                if ((int.Parse(InputWorkPKokogaku.text) + int.Parse(InputHobbyPKokogaku.text) + status[46]) > limit)
                {
                    InputWorkPKokogaku.text = (limit - status[46] - int.Parse(InputHobbyPKokogaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPKokogaku.text) < 0)
                {
                    InputWorkPKokogaku.text = "0";
                }
                kokogaku = int.Parse(InputWorkPKokogaku.text);
                if (StatusManager.Instance.WorkP < kokogaku)
                {
                    kokogaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Kokogaku += kokogaku;
                    InputWorkPKokogaku.text = kokogaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= kokogaku;
                    StatusManager.Instance.Kokogaku -= inputworkp[46];
                    StatusManager.Instance.Kokogaku += kokogaku;
                    StatusManager.Instance.WorkP += inputworkp[46];
                }
                NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                inputworkp[46] = kokogaku;
                Afterstatus[46] = StatusManager.Instance.Kokogaku;
                break;
            case 407:        //コンピュータ
                if ((int.Parse(InputWorkPPC.text) + int.Parse(InputHobbyPPC.text) + status[47]) > limit)
                {
                    InputWorkPPC.text = (limit - status[47] - int.Parse(InputHobbyPPC.text)).ToString();
                }
                else if (int.Parse(InputWorkPPC.text) < 0)
                {
                    InputWorkPPC.text = "0";
                }
                pc = int.Parse(InputWorkPPC.text);
                if (StatusManager.Instance.WorkP < pc)
                {
                    pc = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.PC += pc;
                    InputWorkPPC.text = pc.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= pc;
                    StatusManager.Instance.PC -= inputworkp[47];
                    StatusManager.Instance.PC += pc;
                    StatusManager.Instance.WorkP += inputworkp[47];
                }
                NowPC.text = StatusManager.Instance.PC.ToString();
                inputworkp[47] = pc;
                Afterstatus[47] = StatusManager.Instance.PC;
                break;
            case 408:        //心理学
                if ((int.Parse(InputWorkPShinrigaku.text) + int.Parse(InputHobbyPShinrigaku.text) + status[48]) > limit)
                {
                    InputWorkPShinrigaku.text = (limit - status[48] - int.Parse(InputHobbyPShinrigaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPShinrigaku.text) < 0)
                {
                    InputWorkPShinrigaku.text = "0";
                }
                shinrigaku = int.Parse(InputWorkPShinrigaku.text);
                if (StatusManager.Instance.WorkP < shinrigaku)
                {
                    shinrigaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Shinrigaku += shinrigaku;
                    InputWorkPShinrigaku.text = shinrigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= shinrigaku;
                    StatusManager.Instance.Shinrigaku -= inputworkp[48];
                    StatusManager.Instance.Shinrigaku += shinrigaku;
                    StatusManager.Instance.WorkP += inputworkp[48];
                }
                NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                inputworkp[48] = shinrigaku;
                Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                break;
            case 409:        //人類学
                if ((int.Parse(InputWorkPZinruigaku.text) + int.Parse(InputHobbyPZinruigaku.text) + status[49]) > limit)
                {
                    InputWorkPZinruigaku.text = (limit - status[49] - int.Parse(InputHobbyPZinruigaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPZinruigaku.text) < 0)
                {
                    InputWorkPZinruigaku.text = "0";
                }
                zinruigaku = int.Parse(InputWorkPZinruigaku.text);
                if (StatusManager.Instance.WorkP < zinruigaku)
                {
                    zinruigaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Zinruigaku += zinruigaku;
                    InputWorkPZinruigaku.text = zinruigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= zinruigaku;
                    StatusManager.Instance.Zinruigaku -= inputworkp[49];
                    StatusManager.Instance.Zinruigaku += zinruigaku;
                    StatusManager.Instance.WorkP += inputworkp[49];
                }
                NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                inputworkp[49] = zinruigaku;
                Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                break;
            case 410:        //生物学
                if ((int.Parse(InputWorkPSeibutsugaku.text) + int.Parse(InputHobbyPSeibutsugaku.text) + status[50]) > limit)
                {
                    InputWorkPSeibutsugaku.text = (limit - status[50] - int.Parse(InputHobbyPSeibutsugaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPSeibutsugaku.text) < 0)
                {
                    InputWorkPSeibutsugaku.text = "0";
                }
                seibutsugaku = int.Parse(InputWorkPSeibutsugaku.text);
                if (StatusManager.Instance.WorkP < seibutsugaku)
                {
                    seibutsugaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Seibutsugaku += seibutsugaku;
                    InputWorkPSeibutsugaku.text = seibutsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= seibutsugaku;
                    StatusManager.Instance.Seibutsugaku -= inputworkp[50];
                    StatusManager.Instance.Seibutsugaku += seibutsugaku;
                    StatusManager.Instance.WorkP += inputworkp[50];
                }
                NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                inputworkp[50] = seibutsugaku;
                Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                break;
            case 411:        //地質学
                if ((int.Parse(InputWorkPTishitsugaku.text) + int.Parse(InputHobbyPTishitsugaku.text) + status[51]) > limit)
                {
                    InputWorkPTishitsugaku.text = (limit - status[51] - int.Parse(InputHobbyPTishitsugaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPTishitsugaku.text) < 0)
                {
                    InputWorkPTishitsugaku.text = "0";
                }
                tishitsugaku = int.Parse(InputWorkPTishitsugaku.text);
                if (StatusManager.Instance.WorkP < tishitsugaku)
                {
                    tishitsugaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Tishitsugaku += tishitsugaku;
                    InputWorkPTishitsugaku.text = tishitsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= tishitsugaku;
                    StatusManager.Instance.Tishitsugaku -= inputworkp[51];
                    StatusManager.Instance.Tishitsugaku += tishitsugaku;
                    StatusManager.Instance.WorkP += inputworkp[51];
                }
                NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                inputworkp[51] = tishitsugaku;
                Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                break;
            case 412:        //電子工学
                if ((int.Parse(InputWorkPDenshikougaku.text) + int.Parse(InputHobbyPDenshikougaku.text) + status[52]) > limit)
                {
                    InputWorkPDenshikougaku.text = (limit - status[52] - int.Parse(InputHobbyPDenshikougaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPDenshikougaku.text) < 0)
                {
                    InputWorkPDenshikougaku.text = "0";
                }
                denshikougaku = int.Parse(InputWorkPDenshikougaku.text);
                if (StatusManager.Instance.WorkP < denshikougaku)
                {
                    denshikougaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Denshikougaku += denshikougaku;
                    InputWorkPDenshikougaku.text = denshikougaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= denshikougaku;
                    StatusManager.Instance.Denshikougaku -= inputworkp[52];
                    StatusManager.Instance.Denshikougaku += denshikougaku;
                    StatusManager.Instance.WorkP += inputworkp[52];
                }
                NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                inputworkp[52] = denshikougaku;
                Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                break;
            case 413:        //天文学
                if ((int.Parse(InputWorkPTenmongaku.text) + int.Parse(InputHobbyPTenmongaku.text) + status[53]) > limit)
                {
                    InputWorkPTenmongaku.text = (limit - status[53] - int.Parse(InputHobbyPTenmongaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPTenmongaku.text) < 0)
                {
                    InputWorkPTenmongaku.text = "0";
                }
                tenmongaku = int.Parse(InputWorkPTenmongaku.text);
                if (StatusManager.Instance.WorkP < tenmongaku)
                {
                    tenmongaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Tenmongaku += tenmongaku;
                    InputWorkPTenmongaku.text = tenmongaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= tenmongaku;
                    StatusManager.Instance.Tenmongaku -= inputworkp[53];
                    StatusManager.Instance.Tenmongaku += tenmongaku;
                    StatusManager.Instance.WorkP += inputworkp[53];
                }
                NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                inputworkp[53] = tenmongaku;
                Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                break;
            case 414:        //博物学
                if ((int.Parse(InputWorkPHakubutsugaku.text) + int.Parse(InputHobbyPHakubutsugaku.text) + status[54]) > limit)
                {
                    InputWorkPHakubutsugaku.text = (limit - status[54] - int.Parse(InputHobbyPHakubutsugaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPHakubutsugaku.text) < 0)
                {
                    InputWorkPHakubutsugaku.text = "0";
                }
                hakubutsugaku = int.Parse(InputWorkPHakubutsugaku.text);
                if (StatusManager.Instance.WorkP < hakubutsugaku)
                {
                    hakubutsugaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Hakubutsugaku += hakubutsugaku;
                    InputWorkPHakubutsugaku.text = hakubutsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= hakubutsugaku;
                    StatusManager.Instance.Hakubutsugaku -= inputworkp[54];
                    StatusManager.Instance.Hakubutsugaku += hakubutsugaku;
                    StatusManager.Instance.WorkP += inputworkp[54];
                }
                NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                inputworkp[54] = hakubutsugaku;
                Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                break;
            case 415:        //物理学
                if ((int.Parse(InputWorkPButsurigaku.text) + int.Parse(InputHobbyPButsurigaku.text) + status[55]) > limit)
                {
                    InputWorkPButsurigaku.text = (limit - status[55] - int.Parse(InputHobbyPButsurigaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPButsurigaku.text) < 0)
                {
                    InputWorkPButsurigaku.text = "0";
                }
                butsurigaku = int.Parse(InputWorkPButsurigaku.text);
                if (StatusManager.Instance.WorkP < butsurigaku)
                {
                    butsurigaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Butsurigaku += butsurigaku;
                    InputWorkPButsurigaku.text = butsurigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= butsurigaku;
                    StatusManager.Instance.Butsurigaku -= inputworkp[55];
                    StatusManager.Instance.Butsurigaku += butsurigaku;
                    StatusManager.Instance.WorkP += inputworkp[55];
                }
                NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                inputworkp[55] = butsurigaku;
                Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                break;
            case 416:        //法律
                if ((int.Parse(InputWorkPHouritsu.text) + int.Parse(InputHobbyPHouritsu.text) + status[56]) > limit)
                {
                    InputWorkPHouritsu.text = (limit - status[56] - int.Parse(InputHobbyPHouritsu.text)).ToString();
                }
                else if (int.Parse(InputWorkPHouritsu.text) < 0)
                {
                    InputWorkPHouritsu.text = "0";
                }
                houritsu = int.Parse(InputWorkPHouritsu.text);
                if (StatusManager.Instance.WorkP < houritsu)
                {
                    houritsu = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Houritsu += houritsu;
                    InputWorkPHouritsu.text = houritsu.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= houritsu;
                    StatusManager.Instance.Houritsu -= inputworkp[56];
                    StatusManager.Instance.Houritsu += houritsu;
                    StatusManager.Instance.WorkP += inputworkp[56];
                }
                NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                inputworkp[56] = houritsu;
                Afterstatus[56] = StatusManager.Instance.Houritsu;
                break;
            case 417:        //薬学
                if ((int.Parse(InputWorkPYakugaku.text) + int.Parse(InputHobbyPYakugaku.text) + status[57]) > limit)
                {
                    InputWorkPYakugaku.text = (limit - status[57] - int.Parse(InputHobbyPYakugaku.text)).ToString();
                }
                else if (int.Parse(InputWorkPYakugaku.text) < 0)
                {
                    InputWorkPYakugaku.text = "0";
                }
                yakugaku = int.Parse(InputWorkPYakugaku.text);
                if (StatusManager.Instance.WorkP < yakugaku)
                {
                    yakugaku = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Yakugaku += yakugaku;
                    InputWorkPYakugaku.text = yakugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= yakugaku;
                    StatusManager.Instance.Yakugaku -= inputworkp[57];
                    StatusManager.Instance.Yakugaku += yakugaku;
                    StatusManager.Instance.WorkP += inputworkp[57];
                }
                NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                inputworkp[57] = yakugaku;
                Afterstatus[57] = StatusManager.Instance.Yakugaku;
                break;
            case 418:        //歴史
                if ((int.Parse(InputWorkPRekishi.text) + int.Parse(InputHobbyPRekishi.text) + status[58]) > limit)
                {
                    InputWorkPRekishi.text = (limit - status[58] - int.Parse(InputHobbyPRekishi.text)).ToString();
                }
                else if (int.Parse(InputWorkPRekishi.text) < 0)
                {
                    InputWorkPRekishi.text = "0";
                }
                rekishi = int.Parse(InputWorkPRekishi.text);
                if (StatusManager.Instance.WorkP < rekishi)
                {
                    rekishi = StatusManager.Instance.WorkP;
                    StatusManager.Instance.WorkP = 0;
                    StatusManager.Instance.Rekishi += rekishi;
                    InputWorkPRekishi.text = rekishi.ToString();
                }
                else
                {
                    StatusManager.Instance.WorkP -= rekishi;
                    StatusManager.Instance.Rekishi -= inputworkp[58];
                    StatusManager.Instance.Rekishi += rekishi;
                    StatusManager.Instance.WorkP += inputworkp[58];
                }
                NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                inputworkp[58] = rekishi;
                Afterstatus[58] = StatusManager.Instance.Rekishi;
                break;
        }
    }

    //趣味技能ポイント入力
    public void InputHobbyP(int InputHobbyPNo)
    {
        switch (InputHobbyPNo)
        {
            case 0:     //回避
                if ((int.Parse(InputWorkPKaihi.text) + int.Parse(InputHobbyPKaihi.text) + status[0]) > limit)
                {
                    InputHobbyPKaihi.text = (limit - status[0] - int.Parse(InputWorkPKaihi.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKaihi.text) < 0)
                {
                    InputHobbyPKaihi.text = "0";
                }
                kaihi = int.Parse(InputHobbyPKaihi.text);
                if (StatusManager.Instance.HobbyP < kaihi)
                {
                    kaihi = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kaihi += kaihi;
                    InputHobbyPKaihi.text = kaihi.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kaihi;
                    StatusManager.Instance.Kaihi -= inputhobbyp[0];
                    StatusManager.Instance.Kaihi += kaihi;
                    StatusManager.Instance.HobbyP += inputhobbyp[0];
                }
                NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                inputhobbyp[0] = kaihi;
                Afterstatus[0] = StatusManager.Instance.Kaihi;
                break;
            case 1:     //キック
                if ((int.Parse(InputWorkPKikku.text) + int.Parse(InputHobbyPKikku.text) + status[1]) > limit)
                {
                    InputHobbyPKikku.text = (limit - status[1] - int.Parse(InputWorkPKikku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKikku.text) < 0)
                {
                    InputHobbyPKikku.text = "0";
                }
                kikku = int.Parse(InputHobbyPKikku.text);
                if (StatusManager.Instance.HobbyP < kikku)
                {
                    kikku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kikku += kikku;
                    InputHobbyPKikku.text = kikku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kikku;
                    StatusManager.Instance.Kikku -= inputhobbyp[1];
                    StatusManager.Instance.Kikku += kikku;
                    StatusManager.Instance.HobbyP += inputhobbyp[1];
                }
                NowKikku.text = StatusManager.Instance.Kikku.ToString();
                inputhobbyp[1] = kikku;
                Afterstatus[1] = StatusManager.Instance.Kikku;
                break;
            case 2:     //組み付き
                if ((int.Parse(InputWorkPKumitsuki.text) + int.Parse(InputHobbyPKumitsuki.text) + status[2]) > limit)
                {
                    InputHobbyPKumitsuki.text = (limit - status[2] - int.Parse(InputWorkPKumitsuki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKumitsuki.text) < 0)
                {
                    InputHobbyPKumitsuki.text = "0";
                }
                kumitsuki = int.Parse(InputHobbyPKumitsuki.text);
                if (StatusManager.Instance.HobbyP < kumitsuki)
                {
                    kumitsuki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kumitsuki += kumitsuki;
                    InputHobbyPKumitsuki.text = kumitsuki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kumitsuki;
                    StatusManager.Instance.Kumitsuki -= inputhobbyp[2];
                    StatusManager.Instance.Kumitsuki += kumitsuki;
                    StatusManager.Instance.HobbyP += inputhobbyp[2];
                }
                NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                inputhobbyp[2] = kumitsuki;
                Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                break;
            case 3:     //こぶし
                if ((int.Parse(InputWorkPKobushi.text) + int.Parse(InputHobbyPKobushi.text) + status[3]) > limit)
                {
                    InputHobbyPKobushi.text = (limit - status[3] - int.Parse(InputWorkPKobushi.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKobushi.text) < 0)
                {
                    InputHobbyPKobushi.text = "0";
                }
                kobushi = int.Parse(InputHobbyPKobushi.text);
                if (StatusManager.Instance.HobbyP < kobushi)
                {
                    kobushi = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kobushi += kobushi;
                    InputHobbyPKobushi.text = kobushi.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kobushi;
                    StatusManager.Instance.Kobushi -= inputhobbyp[3];
                    StatusManager.Instance.Kobushi += kobushi;
                    StatusManager.Instance.HobbyP += inputhobbyp[3];
                }
                NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                inputhobbyp[3] = kobushi;
                Afterstatus[3] = StatusManager.Instance.Kobushi;
                break;
            case 4:     //頭突き
                if ((int.Parse(InputWorkPZutsuki.text) + int.Parse(InputHobbyPZutsuki.text) + status[4]) > limit)
                {
                    InputHobbyPZutsuki.text = (limit - status[4] - int.Parse(InputWorkPZutsuki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPZutsuki.text) < 0)
                {
                    InputHobbyPZutsuki.text = "0";
                }
                zutsuki = int.Parse(InputHobbyPZutsuki.text);
                if (StatusManager.Instance.HobbyP < zutsuki)
                {
                    zutsuki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Zutsuki += zutsuki;
                    InputHobbyPZutsuki.text = zutsuki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= zutsuki;
                    StatusManager.Instance.Zutsuki -= inputhobbyp[4];
                    StatusManager.Instance.Zutsuki += zutsuki;
                    StatusManager.Instance.HobbyP += inputhobbyp[4];
                }
                NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                inputhobbyp[4] = zutsuki;
                Afterstatus[4] = StatusManager.Instance.Zutsuki;
                break;
            case 5:     //投擲
                if ((int.Parse(InputWorkPToteki.text) + int.Parse(InputHobbyPToteki.text) + status[5]) > limit)
                {
                    InputHobbyPToteki.text = (limit - status[5] - int.Parse(InputWorkPToteki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPToteki.text) < 0)
                {
                    InputHobbyPToteki.text = "0";
                }
                toteki = int.Parse(InputHobbyPToteki.text);
                if (StatusManager.Instance.HobbyP < toteki)
                {
                    toteki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Toteki += toteki;
                    InputHobbyPToteki.text = toteki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= toteki;
                    StatusManager.Instance.Toteki -= inputhobbyp[5];
                    StatusManager.Instance.Toteki += toteki;
                    StatusManager.Instance.HobbyP += inputhobbyp[5];
                }
                NowToteki.text = StatusManager.Instance.Toteki.ToString();
                inputhobbyp[5] = toteki;
                Afterstatus[5] = StatusManager.Instance.Toteki;
                break;
            case 6:     //マーシャルアーツ
                if ((int.Parse(InputWorkPMSA.text) + int.Parse(InputHobbyPMSA.text) + status[6]) > limit)
                {
                    InputHobbyPMSA.text = (limit - status[6] - int.Parse(InputWorkPMSA.text)).ToString();
                }
                else if (int.Parse(InputHobbyPMSA.text) < 0)
                {
                    InputHobbyPMSA.text = "0";
                }
                msa = int.Parse(InputHobbyPMSA.text);
                if (StatusManager.Instance.HobbyP < msa)
                {
                    msa = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.MSA += msa;
                    InputHobbyPMSA.text = msa.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= msa;
                    StatusManager.Instance.MSA -= inputhobbyp[6];
                    StatusManager.Instance.MSA += msa;
                    StatusManager.Instance.HobbyP += inputhobbyp[6];
                }
                NowMSA.text = StatusManager.Instance.MSA.ToString();
                inputhobbyp[6] = msa;
                Afterstatus[6] = StatusManager.Instance.MSA;
                break;
            case 7:     //拳銃
                if ((int.Parse(InputWorkPKenzyu.text) + int.Parse(InputHobbyPKenzyu.text) + status[7]) > limit)
                {
                    InputHobbyPKenzyu.text = (limit - status[7] - int.Parse(InputWorkPKenzyu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKenzyu.text) < 0)
                {
                    InputHobbyPKenzyu.text = "0";
                }
                kenzyu = int.Parse(InputHobbyPKenzyu.text);
                if (StatusManager.Instance.HobbyP < kenzyu)
                {
                    kenzyu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kenzyu += kenzyu;
                    InputHobbyPKenzyu.text = kenzyu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kenzyu;
                    StatusManager.Instance.Kenzyu -= inputhobbyp[7];
                    StatusManager.Instance.Kenzyu += kenzyu;
                    StatusManager.Instance.HobbyP += inputhobbyp[7];
                }
                NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                inputhobbyp[7] = kenzyu;
                Afterstatus[7] = StatusManager.Instance.Kenzyu;
                break;
            case 8:     //サブマシンガン
                if ((int.Parse(InputWorkPSMG.text) + int.Parse(InputHobbyPSMG.text) + status[8]) > limit)
                {
                    InputHobbyPSMG.text = (limit - status[8] - int.Parse(InputWorkPSMG.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSMG.text) < 0)
                {
                    InputHobbyPSMG.text = "0";
                }
                smg = int.Parse(InputHobbyPSMG.text);
                if (StatusManager.Instance.HobbyP < smg)
                {
                    smg = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.SMG += smg;
                    InputHobbyPSMG.text = smg.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= smg;
                    StatusManager.Instance.SMG -= inputhobbyp[8];
                    StatusManager.Instance.SMG += smg;
                    StatusManager.Instance.HobbyP += inputhobbyp[8];
                }
                NowSMG.text = StatusManager.Instance.SMG.ToString();
                inputhobbyp[8] = smg;
                Afterstatus[8] = StatusManager.Instance.SMG;
                break;
            case 9:     //ショットガン
                if ((int.Parse(InputWorkPSG.text) + int.Parse(InputHobbyPSG.text) + status[9]) > limit)
                {
                    InputHobbyPSG.text = (limit - status[9] - int.Parse(InputWorkPSG.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSG.text) < 0)
                {
                    InputHobbyPSG.text = "0";
                }
                sg = int.Parse(InputHobbyPSG.text);
                if (StatusManager.Instance.HobbyP < sg)
                {
                    sg = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.SG += sg;
                    InputHobbyPSG.text = sg.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= sg;
                    StatusManager.Instance.SG -= inputhobbyp[9];
                    StatusManager.Instance.SG += sg;
                    StatusManager.Instance.HobbyP += inputhobbyp[9];
                }
                NowSG.text = StatusManager.Instance.SG.ToString();
                inputhobbyp[9] = sg;
                Afterstatus[9] = StatusManager.Instance.SG;
                break;
            case 10:        //マシンガン
                if ((int.Parse(InputWorkPMG.text) + int.Parse(InputHobbyPMG.text) + status[10]) > limit)
                {
                    InputHobbyPMG.text = (limit - status[10] - int.Parse(InputWorkPMG.text)).ToString();
                }
                else if (int.Parse(InputHobbyPMG.text) < 0)
                {
                    InputHobbyPMG.text = "0";
                }
                mg = int.Parse(InputHobbyPMG.text);
                if (StatusManager.Instance.HobbyP < mg)
                {
                    mg = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.MG += mg;
                    InputHobbyPMG.text = mg.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= mg;
                    StatusManager.Instance.MG -= inputhobbyp[10];
                    StatusManager.Instance.MG += mg;
                    StatusManager.Instance.HobbyP += inputhobbyp[10];
                }
                NowMG.text = StatusManager.Instance.MG.ToString();
                inputhobbyp[10] = mg;
                Afterstatus[10] = StatusManager.Instance.MG;
                break;
            case 11:        //ライフル
                if ((int.Parse(InputWorkPR.text) + int.Parse(InputHobbyPR.text) + status[11]) > limit)
                {
                    InputHobbyPR.text = (limit - status[11] - int.Parse(InputWorkPR.text)).ToString();
                }
                else if (int.Parse(InputHobbyPR.text) < 0)
                {
                    InputHobbyPR.text = "0";
                }
                r = int.Parse(InputHobbyPR.text);
                if (StatusManager.Instance.HobbyP < r)
                {
                    r = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.R += r;
                    InputHobbyPR.text = r.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= r;
                    StatusManager.Instance.R -= inputhobbyp[11];
                    StatusManager.Instance.R += r;
                    StatusManager.Instance.HobbyP += inputhobbyp[11];
                }
                NowR.text = StatusManager.Instance.R.ToString();
                inputhobbyp[11] = r;
                Afterstatus[11] = StatusManager.Instance.R;
                break;
            //探索技能ステータス
            case 100:        //応急手当
                if ((int.Parse(InputWorkPOkyuteate.text) + int.Parse(InputHobbyPOkyuteate.text) + status[12]) > limit)
                {
                    InputHobbyPOkyuteate.text = (limit - status[12] - int.Parse(InputWorkPOkyuteate.text)).ToString();
                }
                else if (int.Parse(InputHobbyPOkyuteate.text) < 0)
                {
                    InputHobbyPOkyuteate.text = "0";
                }
                okyuteate = int.Parse(InputHobbyPOkyuteate.text);
                if (StatusManager.Instance.HobbyP < okyuteate)
                {
                    okyuteate = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Okyuteate += okyuteate;
                    InputHobbyPOkyuteate.text = okyuteate.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= okyuteate;
                    StatusManager.Instance.Okyuteate -= inputhobbyp[12];
                    StatusManager.Instance.Okyuteate += okyuteate;
                    StatusManager.Instance.HobbyP += inputhobbyp[12];
                }
                NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                inputhobbyp[12] = okyuteate;
                Afterstatus[12] = StatusManager.Instance.Okyuteate;
                break;
            case 101:        //鍵開け
                if ((int.Parse(InputWorkPKagiake.text) + int.Parse(InputHobbyPKagiake.text) + status[13]) > limit)
                {
                    InputHobbyPKagiake.text = (limit - status[13] - int.Parse(InputWorkPKagiake.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKagiake.text) < 0)
                {
                    InputHobbyPKagiake.text = "0";
                }
                kagiake = int.Parse(InputHobbyPKagiake.text);
                if (StatusManager.Instance.HobbyP < kagiake)
                {
                    kagiake = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kagiake += kagiake;
                    InputHobbyPKagiake.text = kagiake.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kagiake;
                    StatusManager.Instance.Kagiake -= inputhobbyp[13];
                    StatusManager.Instance.Kagiake += kagiake;
                    StatusManager.Instance.HobbyP += inputhobbyp[13];
                }
                NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                inputhobbyp[13] = kagiake;
                Afterstatus[13] = StatusManager.Instance.Kagiake;
                break;
            case 102:        //隠す
                if ((int.Parse(InputWorkPKakusu.text) + int.Parse(InputHobbyPKakusu.text) + status[14]) > limit)
                {
                    InputHobbyPKakusu.text = (limit - status[14] - int.Parse(InputWorkPKakusu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKakusu.text) < 0)
                {
                    InputHobbyPKakusu.text = "0";
                }
                kakusu = int.Parse(InputHobbyPKakusu.text);
                if (StatusManager.Instance.HobbyP < kakusu)
                {
                    kakusu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kakusu += kakusu;
                    InputHobbyPKakusu.text = kakusu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kakusu;
                    StatusManager.Instance.Kakusu -= inputhobbyp[14];
                    StatusManager.Instance.Kakusu += kakusu;
                    StatusManager.Instance.HobbyP += inputhobbyp[14];
                }
                NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                inputhobbyp[14] = kakusu;
                Afterstatus[14] = StatusManager.Instance.Kakusu;
                break;
            case 103:        //隠れる
                if ((int.Parse(InputWorkPKakureru.text) + int.Parse(InputHobbyPKakureru.text) + status[15]) > limit)
                {
                    InputHobbyPKakureru.text = (limit - status[15] - int.Parse(InputWorkPKakureru.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKakureru.text) < 0)
                {
                    InputHobbyPKakureru.text = "0";
                }
                kakureru = int.Parse(InputHobbyPKakureru.text);
                if (StatusManager.Instance.HobbyP < kakureru)
                {
                    kakureru = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kakureru += kakureru;
                    InputHobbyPKakureru.text = kakureru.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kakureru;
                    StatusManager.Instance.Kakureru -= inputhobbyp[15];
                    StatusManager.Instance.Kakureru += kakureru;
                    StatusManager.Instance.HobbyP += inputhobbyp[15];
                }
                NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                inputhobbyp[15] = kakureru;
                Afterstatus[15] = StatusManager.Instance.Kakureru;
                break;
            case 104:        //聞き耳
                if ((int.Parse(InputWorkPKikimimi.text) + int.Parse(InputHobbyPKikimimi.text) + status[16]) > limit)
                {
                    InputHobbyPKikimimi.text = (limit - status[16] - int.Parse(InputWorkPKikimimi.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKikimimi.text) < 0)
                {
                    InputHobbyPKikimimi.text = "0";
                }
                kikimimi = int.Parse(InputHobbyPKikimimi.text);
                if (StatusManager.Instance.HobbyP < kikimimi)
                {
                    kikimimi = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kikimimi += kikimimi;
                    InputHobbyPKikimimi.text = kikimimi.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kikimimi;
                    StatusManager.Instance.Kikimimi -= inputhobbyp[16];
                    StatusManager.Instance.Kikimimi += kikimimi;
                    StatusManager.Instance.HobbyP += inputhobbyp[16];
                }
                NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                inputhobbyp[16] = kikimimi;
                Afterstatus[16] = StatusManager.Instance.Kikimimi;
                break;
            case 105:        //忍び歩き
                if ((int.Parse(InputWorkPShinobiaruki.text) + int.Parse(InputHobbyPShinobiaruki.text) + status[17]) > limit)
                {
                    InputHobbyPShinobiaruki.text = (limit - status[17] - int.Parse(InputWorkPShinobiaruki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPShinobiaruki.text) < 0)
                {
                    InputHobbyPShinobiaruki.text = "0";
                }
                shinobiaruki = int.Parse(InputHobbyPShinobiaruki.text);
                if (StatusManager.Instance.HobbyP < shinobiaruki)
                {
                    shinobiaruki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Shinobiaruki += shinobiaruki;
                    InputHobbyPShinobiaruki.text = shinobiaruki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= shinobiaruki;
                    StatusManager.Instance.Shinobiaruki -= inputhobbyp[17];
                    StatusManager.Instance.Shinobiaruki += shinobiaruki;
                    StatusManager.Instance.HobbyP += inputhobbyp[17];
                }
                NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                inputhobbyp[17] = shinobiaruki;
                Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                break;
            case 106:        //写真術
                if ((int.Parse(InputWorkPSyashinzyutsu.text) + int.Parse(InputHobbyPSyashinzyutsu.text) + status[18]) > limit)
                {
                    InputHobbyPSyashinzyutsu.text = (limit - status[18] - int.Parse(InputWorkPSyashinzyutsu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSyashinzyutsu.text) < 0)
                {
                    InputHobbyPSyashinzyutsu.text = "0";
                }
                syashinzyutsu = int.Parse(InputHobbyPSyashinzyutsu.text);
                if (StatusManager.Instance.HobbyP < syashinzyutsu)
                {
                    syashinzyutsu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Syashinzyutsu += syashinzyutsu;
                    InputHobbyPSyashinzyutsu.text = syashinzyutsu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= syashinzyutsu;
                    StatusManager.Instance.Syashinzyutsu -= inputhobbyp[18];
                    StatusManager.Instance.Syashinzyutsu += syashinzyutsu;
                    StatusManager.Instance.HobbyP += inputhobbyp[18];
                }
                NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                inputhobbyp[18] = syashinzyutsu;
                Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                break;
            case 107:        //精神分析
                if ((int.Parse(InputWorkPSeshinbunseki.text) + int.Parse(InputHobbyPSeshinbunseki.text) + status[19]) > limit)
                {
                    InputHobbyPSeshinbunseki.text = (limit - status[19] - int.Parse(InputWorkPSeshinbunseki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSeshinbunseki.text) < 0)
                {
                    InputHobbyPSeshinbunseki.text = "0";
                }
                seshinbunseki = int.Parse(InputHobbyPSeshinbunseki.text);
                if (StatusManager.Instance.WorkP < seshinbunseki)
                {
                    seshinbunseki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Seshinbunseki += seshinbunseki;
                    InputHobbyPSeshinbunseki.text = seshinbunseki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= seshinbunseki;
                    StatusManager.Instance.Seshinbunseki -= inputhobbyp[19];
                    StatusManager.Instance.Seshinbunseki += seshinbunseki;
                    StatusManager.Instance.HobbyP += inputhobbyp[19];
                }
                NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                inputhobbyp[19] = seshinbunseki;
                Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                break;
            case 108:        //追跡
                if ((int.Parse(InputWorkPTsuiseki.text) + int.Parse(InputHobbyPTsuiseki.text) + status[20]) > limit)
                {
                    InputHobbyPTsuiseki.text = (limit - status[20] - int.Parse(InputWorkPTsuiseki.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTsuiseki.text) < 0)
                {
                    InputHobbyPTsuiseki.text = "0";
                }
                tsuiseki = int.Parse(InputHobbyPTsuiseki.text);
                if (StatusManager.Instance.HobbyP < tsuiseki)
                {
                    tsuiseki = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Tsuiseki += tsuiseki;
                    InputHobbyPTsuiseki.text = tsuiseki.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= tsuiseki;
                    StatusManager.Instance.Tsuiseki -= inputhobbyp[20];
                    StatusManager.Instance.Tsuiseki += tsuiseki;
                    StatusManager.Instance.HobbyP += inputhobbyp[20];
                }
                NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                inputhobbyp[20] = tsuiseki;
                Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                break;
            case 109:        //登攀
                if ((int.Parse(InputWorkPTouhan.text) + int.Parse(InputHobbyPTouhan.text) + status[21]) > limit)
                {
                    InputHobbyPTouhan.text = (limit - status[21] - int.Parse(InputWorkPTouhan.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTouhan.text) < 0)
                {
                    InputHobbyPTouhan.text = "0";
                }
                touhan = int.Parse(InputHobbyPTouhan.text);
                if (StatusManager.Instance.HobbyP < touhan)
                {
                    touhan = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Touhan += touhan;
                    InputHobbyPTouhan.text = touhan.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= touhan;
                    StatusManager.Instance.Touhan -= inputhobbyp[21];
                    StatusManager.Instance.Touhan += touhan;
                    StatusManager.Instance.HobbyP += inputhobbyp[21];
                }
                NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                inputhobbyp[21] = touhan;
                Afterstatus[21] = StatusManager.Instance.Touhan;
                break;
            case 110:        //図書館
                if ((int.Parse(InputWorkPTosyokan.text) + int.Parse(InputHobbyPTosyokan.text) + status[22]) > limit)
                {
                    InputHobbyPTosyokan.text = (limit - status[22] - int.Parse(InputWorkPTosyokan.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTosyokan.text) < 0)
                {
                    InputHobbyPTosyokan.text = "0";
                }
                tosyokan = int.Parse(InputHobbyPTosyokan.text);
                if (StatusManager.Instance.HobbyP < tosyokan)
                {
                    tosyokan = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Tosyokan += tosyokan;
                    InputHobbyPTosyokan.text = tosyokan.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= tosyokan;
                    StatusManager.Instance.Tosyokan -= inputhobbyp[22];
                    StatusManager.Instance.Tosyokan += tosyokan;
                    StatusManager.Instance.HobbyP += inputhobbyp[22];
                }
                NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                inputhobbyp[22] = tosyokan;
                Afterstatus[22] = StatusManager.Instance.Tosyokan;
                break;
            case 111:        //目星
                if ((int.Parse(InputWorkPMeboshi.text) + int.Parse(InputHobbyPMeboshi.text) + status[23]) > limit)
                {
                    InputHobbyPMeboshi.text = (limit - status[23] - int.Parse(InputWorkPMeboshi.text)).ToString();
                }
                else if (int.Parse(InputHobbyPMeboshi.text) < 0)
                {
                    InputHobbyPMeboshi.text = "0";
                }
                meboshi = int.Parse(InputHobbyPMeboshi.text);
                if (StatusManager.Instance.HobbyP < meboshi)
                {
                    meboshi = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Meboshi += meboshi;
                    InputHobbyPMeboshi.text = meboshi.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= meboshi;
                    StatusManager.Instance.Meboshi -= inputhobbyp[23];
                    StatusManager.Instance.Meboshi += meboshi;
                    StatusManager.Instance.HobbyP += inputhobbyp[23];
                }
                NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                inputhobbyp[23] = meboshi;
                Afterstatus[23] = StatusManager.Instance.Meboshi;
                break;

            //行動技能ステータス
            case 200:        //運転
                if ((int.Parse(InputWorkPUnten.text) + int.Parse(InputHobbyPUnten.text) + status[24]) > limit)
                {
                    InputHobbyPUnten.text = (limit - status[24] - int.Parse(InputWorkPUnten.text)).ToString();
                }
                else if (int.Parse(InputHobbyPUnten.text) < 0)
                {
                    InputHobbyPUnten.text = "0";
                }
                unten = int.Parse(InputHobbyPUnten.text);
                if (StatusManager.Instance.HobbyP < unten)
                {
                    unten = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Unten += unten;
                    InputHobbyPUnten.text = unten.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= unten;
                    StatusManager.Instance.Unten -= inputhobbyp[24];
                    StatusManager.Instance.Unten += unten;
                    StatusManager.Instance.HobbyP += inputhobbyp[24];
                }
                NowUnten.text = StatusManager.Instance.Unten.ToString();
                inputhobbyp[24] = unten;
                Afterstatus[24] = StatusManager.Instance.Unten;
                break;
            case 201:        //機械修理
                if ((int.Parse(InputWorkPKikaisyuri.text) + int.Parse(InputHobbyPKikaisyuri.text) + status[25]) > limit)
                {
                    InputHobbyPKikaisyuri.text = (limit - status[25] - int.Parse(InputWorkPKikaisyuri.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKikaisyuri.text) < 0)
                {
                    InputHobbyPKikaisyuri.text = "0";
                }
                kikaisyuri = int.Parse(InputHobbyPKikaisyuri.text);
                if (StatusManager.Instance.HobbyP < kikaisyuri)
                {
                    kikaisyuri = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kikaisyuri += kikaisyuri;
                    InputHobbyPKikaisyuri.text = kikaisyuri.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kikaisyuri;
                    StatusManager.Instance.Kikaisyuri -= inputhobbyp[25];
                    StatusManager.Instance.Kikaisyuri += kikaisyuri;
                    StatusManager.Instance.HobbyP += inputhobbyp[25];
                }
                NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                inputhobbyp[25] = kikaisyuri;
                Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                break;
            case 202:        //重機械操作
                if ((int.Parse(InputWorkPZyukikaisosa.text) + int.Parse(InputHobbyPZyukikaisosa.text) + status[26]) > limit)
                {
                    InputHobbyPZyukikaisosa.text = (limit - status[26] - int.Parse(InputWorkPZyukikaisosa.text)).ToString();
                }
                else if (int.Parse(InputHobbyPZyukikaisosa.text) < 0)
                {
                    InputHobbyPZyukikaisosa.text = "0";
                }
                zyukikaisosa = int.Parse(InputHobbyPZyukikaisosa.text);
                if (StatusManager.Instance.HobbyP < zyukikaisosa)
                {
                    zyukikaisosa = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Zyukikaisosa += zyukikaisosa;
                    InputHobbyPZyukikaisosa.text = zyukikaisosa.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= zyukikaisosa;
                    StatusManager.Instance.Zyukikaisosa -= inputhobbyp[26];
                    StatusManager.Instance.Zyukikaisosa += zyukikaisosa;
                    StatusManager.Instance.HobbyP += inputhobbyp[26];
                }
                NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                inputhobbyp[26] = zyukikaisosa;
                Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                break;
            case 203:        //乗馬
                if ((int.Parse(InputWorkPZyoba.text) + int.Parse(InputHobbyPZyoba.text) + status[27]) > limit)
                {
                    InputHobbyPZyoba.text = (limit - status[27] - int.Parse(InputWorkPZyoba.text)).ToString();
                }
                else if (int.Parse(InputHobbyPZyoba.text) < 0)
                {
                    InputHobbyPZyoba.text = "0";
                }
                zyoba = int.Parse(InputHobbyPZyoba.text);
                if (StatusManager.Instance.HobbyP < zyoba)
                {
                    zyoba = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Zyoba += zyoba;
                    InputHobbyPZyoba.text = zyoba.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= zyoba;
                    StatusManager.Instance.Zyoba -= inputhobbyp[27];
                    StatusManager.Instance.Zyoba += zyoba;
                    StatusManager.Instance.HobbyP += inputhobbyp[27];
                }
                NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                inputhobbyp[27] = zyoba;
                Afterstatus[27] = StatusManager.Instance.Zyoba;
                break;
            case 204:        //水泳
                if ((int.Parse(InputWorkPSuiei.text) + int.Parse(InputHobbyPSuiei.text) + status[28]) > limit)
                {
                    InputHobbyPSuiei.text = (limit - status[28] - int.Parse(InputWorkPSuiei.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSuiei.text) < 0)
                {
                    InputHobbyPSuiei.text = "0";
                }
                suiei = int.Parse(InputHobbyPSuiei.text);
                if (StatusManager.Instance.HobbyP < suiei)
                {
                    suiei = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Suiei += suiei;
                    InputHobbyPSuiei.text = suiei.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= suiei;
                    StatusManager.Instance.Suiei -= inputhobbyp[28];
                    StatusManager.Instance.Suiei += suiei;
                    StatusManager.Instance.HobbyP += inputhobbyp[28];
                }
                NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                inputhobbyp[28] = suiei;
                Afterstatus[28] = StatusManager.Instance.Suiei;
                break;
            case 205:        //制作
                if ((int.Parse(InputWorkPSesaku.text) + int.Parse(InputHobbyPSesaku.text) + status[29]) > limit)
                {
                    InputHobbyPSesaku.text = (limit - status[29] - int.Parse(InputWorkPSesaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSesaku.text) < 0)
                {
                    InputHobbyPSesaku.text = "0";
                }
                sesaku = int.Parse(InputHobbyPSesaku.text);
                if (StatusManager.Instance.HobbyP < sesaku)
                {
                    sesaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Sesaku += sesaku;
                    InputHobbyPSesaku.text = sesaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= sesaku;
                    StatusManager.Instance.Sesaku -= inputhobbyp[29];
                    StatusManager.Instance.Sesaku += sesaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[29];
                }
                NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                inputhobbyp[29] = sesaku;
                Afterstatus[29] = StatusManager.Instance.Sesaku;
                break;
            case 206:        //操縦
                if ((int.Parse(InputWorkPSozyu.text) + int.Parse(InputHobbyPSozyu.text) + status[30]) > limit)
                {
                    InputHobbyPSozyu.text = (limit - status[30] - int.Parse(InputWorkPSozyu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSozyu.text) < 0)
                {
                    InputHobbyPSozyu.text = "0";
                }
                sozyu = int.Parse(InputHobbyPSozyu.text);
                if (StatusManager.Instance.HobbyP < sozyu)
                {
                    sozyu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Sozyu += sozyu;
                    InputHobbyPSozyu.text = sozyu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= sozyu;
                    StatusManager.Instance.Sozyu -= inputhobbyp[30];
                    StatusManager.Instance.Sozyu += sozyu;
                    StatusManager.Instance.HobbyP += inputhobbyp[30];
                }
                NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                inputhobbyp[30] = sozyu;
                Afterstatus[30] = StatusManager.Instance.Sozyu;
                break;
            case 207:        //跳躍
                if ((int.Parse(InputWorkPTyoyaku.text) + int.Parse(InputHobbyPTyoyaku.text) + status[31]) > limit)
                {
                    InputHobbyPTyoyaku.text = (limit - status[31] - int.Parse(InputWorkPTyoyaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTyoyaku.text) < 0)
                {
                    InputHobbyPTyoyaku.text = "0";
                }
                tyoyaku = int.Parse(InputHobbyPTyoyaku.text);
                if (StatusManager.Instance.HobbyP < tyoyaku)
                {
                    tyoyaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Tyoyaku += tyoyaku;
                    InputHobbyPTyoyaku.text = tyoyaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= tyoyaku;
                    StatusManager.Instance.Tyoyaku -= inputhobbyp[31];
                    StatusManager.Instance.Tyoyaku += tyoyaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[31];
                }
                NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                inputhobbyp[31] = tyoyaku;
                Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                break;
            case 208:        //電気修理
                if ((int.Parse(InputWorkPDenkisyuri.text) + int.Parse(InputHobbyPDenkisyuri.text) + status[32]) > limit)
                {
                    InputHobbyPDenkisyuri.text = (limit - status[32] - int.Parse(InputWorkPDenkisyuri.text)).ToString();
                }
                else if (int.Parse(InputWorkPDenkisyuri.text) < 0)
                {
                    InputHobbyPDenkisyuri.text = "0";
                }
                denkisyuri = int.Parse(InputHobbyPDenkisyuri.text);
                if (StatusManager.Instance.HobbyP < denkisyuri)
                {
                    denkisyuri = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Denkisyuri += denkisyuri;
                    InputHobbyPDenkisyuri.text = denkisyuri.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= denkisyuri;
                    StatusManager.Instance.Denkisyuri -= inputhobbyp[32];
                    StatusManager.Instance.Denkisyuri += denkisyuri;
                    StatusManager.Instance.HobbyP += inputhobbyp[32];
                }
                NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                inputhobbyp[32] = denkisyuri;
                Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                break;
            case 209:        //ナビゲート
                if ((int.Parse(InputWorkPNabigeto.text) + int.Parse(InputHobbyPNabigeto.text) + status[33]) > limit)
                {
                    InputHobbyPNabigeto.text = (limit - status[33] - int.Parse(InputWorkPNabigeto.text)).ToString();
                }
                else if (int.Parse(InputHobbyPNabigeto.text) < 0)
                {
                    InputHobbyPNabigeto.text = "0";
                }
                nabigeto = int.Parse(InputHobbyPNabigeto.text);
                if (StatusManager.Instance.HobbyP < nabigeto)
                {
                    nabigeto = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Nabigeto += nabigeto;
                    InputHobbyPNabigeto.text = nabigeto.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= nabigeto;
                    StatusManager.Instance.Nabigeto -= inputhobbyp[33];
                    StatusManager.Instance.Nabigeto += nabigeto;
                    StatusManager.Instance.HobbyP += inputhobbyp[33];
                }
                NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                inputhobbyp[33] = nabigeto;
                Afterstatus[33] = StatusManager.Instance.Nabigeto;
                break;
            case 210:        //変装
                if ((int.Parse(InputWorkPHensou.text) + int.Parse(InputHobbyPHensou.text) + status[34]) > limit)
                {
                    InputHobbyPHensou.text = (limit - status[34] - int.Parse(InputWorkPHensou.text)).ToString();
                }
                else if (int.Parse(InputHobbyPHensou.text) < 0)
                {
                    InputHobbyPHensou.text = "0";
                }
                hensou = int.Parse(InputHobbyPHensou.text);
                if (StatusManager.Instance.HobbyP < hensou)
                {
                    hensou = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Hensou += hensou;
                    InputHobbyPHensou.text = hensou.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= hensou;
                    StatusManager.Instance.Hensou -= inputhobbyp[34];
                    StatusManager.Instance.Hensou += hensou;
                    StatusManager.Instance.HobbyP += inputhobbyp[34];
                }
                NowHensou.text = StatusManager.Instance.Hensou.ToString();
                inputhobbyp[34] = hensou;
                Afterstatus[34] = StatusManager.Instance.Hensou;
                break;

            //交渉技能ステータス
            case 300:        //言いくるめ
                if ((int.Parse(InputWorkPIikurume.text) + int.Parse(InputHobbyPIikurume.text) + status[35]) > limit)
                {
                    InputHobbyPIikurume.text = (limit - status[35] - int.Parse(InputWorkPIikurume.text)).ToString();
                }
                else if (int.Parse(InputHobbyPIikurume.text) < 0)
                {
                    InputHobbyPIikurume.text = "0";
                }
                iikurume = int.Parse(InputHobbyPIikurume.text);
                if (StatusManager.Instance.HobbyP < iikurume)
                {
                    iikurume = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Iikurume += iikurume;
                    InputHobbyPIikurume.text = iikurume.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= iikurume;
                    StatusManager.Instance.Iikurume -= inputhobbyp[35];
                    StatusManager.Instance.Iikurume += iikurume;
                    StatusManager.Instance.HobbyP += inputhobbyp[35];
                }
                NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                inputhobbyp[35] = iikurume;
                Afterstatus[35] = StatusManager.Instance.Iikurume;
                break;
            case 301:        //信用
                if ((int.Parse(InputWorkPShinyou.text) + int.Parse(InputHobbyPShinyou.text) + status[36]) > limit)
                {
                    InputHobbyPShinyou.text = (limit - status[36] - int.Parse(InputWorkPShinyou.text)).ToString();
                }
                else if (int.Parse(InputHobbyPShinyou.text) < 0)
                {
                    InputHobbyPShinyou.text = "0";
                }
                shinyou = int.Parse(InputHobbyPShinyou.text);
                if (StatusManager.Instance.HobbyP < shinyou)
                {
                    shinyou = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Shinyou += shinyou;
                    InputHobbyPShinyou.text = shinyou.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= shinyou;
                    StatusManager.Instance.Shinyou -= inputhobbyp[36];
                    StatusManager.Instance.Shinyou += shinyou;
                    StatusManager.Instance.HobbyP += inputhobbyp[36];
                }
                NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                inputhobbyp[36] = shinyou;
                Afterstatus[36] = StatusManager.Instance.Shinyou;
                break;
            case 302:        //説得
                if ((int.Parse(InputWorkPSettoku.text) + int.Parse(InputHobbyPSettoku.text) + status[37]) > limit)
                {
                    InputHobbyPSettoku.text = (limit - status[37] - int.Parse(InputWorkPSettoku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSettoku.text) < 0)
                {
                    InputHobbyPSettoku.text = "0";
                }
                settoku = int.Parse(InputHobbyPSettoku.text);
                if (StatusManager.Instance.HobbyP < settoku)
                {
                    settoku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Settoku += settoku;
                    InputHobbyPSettoku.text = settoku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= settoku;
                    StatusManager.Instance.Settoku -= inputhobbyp[37];
                    StatusManager.Instance.Settoku += settoku;
                    StatusManager.Instance.HobbyP += inputhobbyp[37];
                }
                NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                inputhobbyp[37] = settoku;
                Afterstatus[37] = StatusManager.Instance.Settoku;
                break;
            case 303:        //値切り
                if ((int.Parse(InputWorkPNegiri.text) + int.Parse(InputHobbyPNegiri.text) + status[38]) > limit)
                {
                    InputHobbyPNegiri.text = (limit - status[38] - int.Parse(InputWorkPNegiri.text)).ToString();
                }
                else if (int.Parse(InputHobbyPNegiri.text) < 0)
                {
                    InputHobbyPNegiri.text = "0";
                }
                negiri = int.Parse(InputHobbyPNegiri.text);
                if (StatusManager.Instance.HobbyP < negiri)
                {
                    negiri = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Negiri += negiri;
                    InputHobbyPNegiri.text = negiri.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= negiri;
                    StatusManager.Instance.Negiri -= inputhobbyp[38];
                    StatusManager.Instance.Negiri += negiri;
                    StatusManager.Instance.HobbyP += inputhobbyp[38];
                }
                NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                inputhobbyp[38] = negiri;
                Afterstatus[38] = StatusManager.Instance.Negiri;
                break;
            case 304:        //母国語
                if ((int.Parse(InputWorkPBokokugo.text) + int.Parse(InputHobbyPBokokugo.text) + status[39]) > limit)
                {
                    InputHobbyPBokokugo.text = (limit - status[39] - int.Parse(InputWorkPBokokugo.text)).ToString();
                }
                else if (int.Parse(InputHobbyPBokokugo.text) < 0)
                {
                    InputHobbyPBokokugo.text = "0";
                }
                bokokugo = int.Parse(InputHobbyPBokokugo.text);
                if (StatusManager.Instance.HobbyP < bokokugo)
                {
                    bokokugo = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Bokokugo += bokokugo;
                    InputHobbyPBokokugo.text = bokokugo.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= bokokugo;
                    StatusManager.Instance.Bokokugo -= inputhobbyp[39];
                    StatusManager.Instance.Bokokugo += bokokugo;
                    StatusManager.Instance.HobbyP += inputhobbyp[39];
                }
                NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                inputhobbyp[39] = bokokugo;
                Afterstatus[39] = StatusManager.Instance.Bokokugo;
                break;

            //知識技能ステータス
            case 400:        //医学
                if ((int.Parse(InputWorkPIgaku.text) + int.Parse(InputHobbyPIgaku.text) + status[40]) > limit)
                {
                    InputHobbyPIgaku.text = (limit - status[40] - int.Parse(InputWorkPIgaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPIgaku.text) < 0)
                {
                    InputHobbyPIgaku.text = "0";
                }
                igaku = int.Parse(InputHobbyPIgaku.text);
                if (StatusManager.Instance.HobbyP < igaku)
                {
                    igaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Igaku += igaku;
                    InputHobbyPIgaku.text = igaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= igaku;
                    StatusManager.Instance.Igaku -= inputhobbyp[40];
                    StatusManager.Instance.Igaku += igaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[40];
                }
                NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                inputhobbyp[40] = igaku;
                Afterstatus[40] = StatusManager.Instance.Igaku;
                break;
            case 401:        //オカルト
                if ((int.Parse(InputWorkPOkaruto.text) + int.Parse(InputHobbyPOkaruto.text) + status[41]) > limit)
                {
                    InputHobbyPOkaruto.text = (limit - status[41] - int.Parse(InputWorkPOkaruto.text)).ToString();
                }
                else if (int.Parse(InputHobbyPOkaruto.text) < 0)
                {
                    InputHobbyPOkaruto.text = "0";
                }
                okaruto = int.Parse(InputHobbyPOkaruto.text);
                if (StatusManager.Instance.HobbyP < okaruto)
                {
                    okaruto = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Okaruto += okaruto;
                    InputHobbyPOkaruto.text = okaruto.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= okaruto;
                    StatusManager.Instance.Okaruto -= inputhobbyp[41];
                    StatusManager.Instance.Okaruto += okaruto;
                    StatusManager.Instance.HobbyP += inputhobbyp[41];
                }
                NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                inputhobbyp[41] = okaruto;
                Afterstatus[41] = StatusManager.Instance.Okaruto;
                break;
            case 402:        //化学
                if ((int.Parse(InputWorkPKagaku.text) + int.Parse(InputHobbyPKagaku.text) + status[42]) > limit)
                {
                    InputHobbyPKagaku.text = (limit - status[42] - int.Parse(InputWorkPKagaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKagaku.text) < 0)
                {
                    InputHobbyPKagaku.text = "0";
                }
                kagaku = int.Parse(InputHobbyPKagaku.text);
                if (StatusManager.Instance.HobbyP < kagaku)
                {
                    kagaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kagaku += kagaku;
                    InputHobbyPKagaku.text = kagaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kagaku;
                    StatusManager.Instance.Kagaku -= inputhobbyp[42];
                    StatusManager.Instance.Kagaku += kagaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[42];
                }
                NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                inputhobbyp[42] = kagaku;
                Afterstatus[42] = StatusManager.Instance.Kagaku;
                break;
            case 403:        //クトゥルフ神話
                if ((int.Parse(InputWorkPShinwa.text) + int.Parse(InputHobbyPShinwa.text) + status[43]) > limit)
                {
                    InputHobbyPShinwa.text = (limit - status[43] - int.Parse(InputWorkPShinwa.text)).ToString();
                }
                else if (int.Parse(InputHobbyPShinwa.text) < 0)
                {
                    InputHobbyPShinwa.text = "0";
                }
                shinwa = int.Parse(InputHobbyPShinwa.text);
                if (StatusManager.Instance.HobbyP < shinwa)
                {
                    shinwa = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Shinwa += shinwa;
                    InputHobbyPShinwa.text = shinwa.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= shinwa;
                    StatusManager.Instance.Shinwa -= inputhobbyp[43];
                    StatusManager.Instance.Shinwa += shinwa;
                    StatusManager.Instance.HobbyP += inputhobbyp[43];
                }
                NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                inputhobbyp[43] = shinwa;
                Afterstatus[43] = StatusManager.Instance.Shinwa;
                break;
            case 404:        //芸術
                if ((int.Parse(InputWorkPGezyutsu.text) + int.Parse(InputHobbyPGezyutsu.text) + status[44]) > limit)
                {
                    InputHobbyPGezyutsu.text = (limit - status[44] - int.Parse(InputWorkPGezyutsu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPGezyutsu.text) < 0)
                {
                    InputHobbyPGezyutsu.text = "0";
                }
                gezyutsu = int.Parse(InputHobbyPGezyutsu.text);
                if (StatusManager.Instance.HobbyP < gezyutsu)
                {
                    gezyutsu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Gezyutsu += gezyutsu;
                    InputHobbyPGezyutsu.text = gezyutsu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= gezyutsu;
                    StatusManager.Instance.Gezyutsu -= inputhobbyp[44];
                    StatusManager.Instance.Gezyutsu += gezyutsu;
                    StatusManager.Instance.HobbyP += inputhobbyp[44];
                }
                NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                inputhobbyp[44] = gezyutsu;
                Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                break;
            case 405:        //経理
                if ((int.Parse(InputWorkPKeiri.text) + int.Parse(InputHobbyPKeiri.text) + status[45]) > limit)
                {
                    InputHobbyPKeiri.text = (limit - status[45] - int.Parse(InputWorkPKeiri.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKeiri.text) < 0)
                {
                    InputHobbyPKeiri.text = "0";
                }
                keiri = int.Parse(InputHobbyPKeiri.text);
                if (StatusManager.Instance.HobbyP < keiri)
                {
                    keiri = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Keiri += keiri;
                    InputHobbyPKeiri.text = keiri.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= keiri;
                    StatusManager.Instance.Keiri -= inputhobbyp[45];
                    StatusManager.Instance.Keiri += keiri;
                    StatusManager.Instance.HobbyP += inputhobbyp[45];
                }
                NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                inputhobbyp[45] = keiri;
                Afterstatus[45] = StatusManager.Instance.Keiri;
                break;
            case 406:        //考古学
                if ((int.Parse(InputWorkPKokogaku.text) + int.Parse(InputHobbyPKokogaku.text) + status[46]) > limit)
                {
                    InputHobbyPKokogaku.text = (limit - status[46] - int.Parse(InputWorkPKokogaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPKokogaku.text) < 0)
                {
                    InputHobbyPKokogaku.text = "0";
                }
                kokogaku = int.Parse(InputHobbyPKokogaku.text);
                if (StatusManager.Instance.HobbyP < kokogaku)
                {
                    kokogaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Kokogaku += kokogaku;
                    InputHobbyPKokogaku.text = kokogaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= kokogaku;
                    StatusManager.Instance.Kokogaku -= inputhobbyp[46];
                    StatusManager.Instance.Kokogaku += kokogaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[46];
                }
                NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                inputhobbyp[46] = kokogaku;
                Afterstatus[46] = StatusManager.Instance.Kokogaku;
                break;
            case 407:        //コンピュータ
                if ((int.Parse(InputWorkPPC.text) + int.Parse(InputHobbyPPC.text) + status[47]) > limit)
                {
                    InputHobbyPPC.text = (limit - status[47] - int.Parse(InputWorkPPC.text)).ToString();
                }
                else if (int.Parse(InputHobbyPPC.text) < 0)
                {
                    InputHobbyPPC.text = "0";
                }
                pc = int.Parse(InputHobbyPPC.text);
                if (StatusManager.Instance.HobbyP < pc)
                {
                    pc = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.PC += pc;
                    InputHobbyPPC.text = pc.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= pc;
                    StatusManager.Instance.PC -= inputhobbyp[47];
                    StatusManager.Instance.PC += pc;
                    StatusManager.Instance.HobbyP += inputhobbyp[47];
                }
                NowPC.text = StatusManager.Instance.PC.ToString();
                inputhobbyp[47] = pc;
                Afterstatus[47] = StatusManager.Instance.PC;
                break;
            case 408:        //心理学
                if ((int.Parse(InputWorkPShinrigaku.text) + int.Parse(InputHobbyPShinrigaku.text) + status[48]) > limit)
                {
                    InputHobbyPShinrigaku.text = (limit - status[48] - int.Parse(InputWorkPShinrigaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPShinrigaku.text) < 0)
                {
                    InputHobbyPShinrigaku.text = "0";
                }
                shinrigaku = int.Parse(InputHobbyPShinrigaku.text);
                if (StatusManager.Instance.HobbyP < shinrigaku)
                {
                    shinrigaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Shinrigaku += shinrigaku;
                    InputHobbyPShinrigaku.text = shinrigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= shinrigaku;
                    StatusManager.Instance.Shinrigaku -= inputhobbyp[48];
                    StatusManager.Instance.Shinrigaku += shinrigaku;
                    StatusManager.Instance.WorkP += inputhobbyp[48];
                }
                NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                inputhobbyp[48] = shinrigaku;
                Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                break;
            case 409:        //人類学
                if ((int.Parse(InputWorkPZinruigaku.text) + int.Parse(InputHobbyPZinruigaku.text) + status[49]) > limit)
                {
                    InputHobbyPZinruigaku.text = (limit - status[49] - int.Parse(InputWorkPZinruigaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPZinruigaku.text) < 0)
                {
                    InputHobbyPZinruigaku.text = "0";
                }
                zinruigaku = int.Parse(InputHobbyPZinruigaku.text);
                if (StatusManager.Instance.HobbyP < zinruigaku)
                {
                    zinruigaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Zinruigaku += zinruigaku;
                    InputHobbyPZinruigaku.text = zinruigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= zinruigaku;
                    StatusManager.Instance.Zinruigaku -= inputhobbyp[49];
                    StatusManager.Instance.Zinruigaku += zinruigaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[49];
                }
                NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                inputhobbyp[49] = zinruigaku;
                Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                break;
            case 410:        //生物学
                if ((int.Parse(InputWorkPSeibutsugaku.text) + int.Parse(InputHobbyPSeibutsugaku.text) + status[50]) > limit)
                {
                    InputHobbyPSeibutsugaku.text = (limit - status[50] - int.Parse(InputWorkPSeibutsugaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPSeibutsugaku.text) < 0)
                {
                    InputHobbyPSeibutsugaku.text = "0";
                }
                seibutsugaku = int.Parse(InputHobbyPSeibutsugaku.text);
                if (StatusManager.Instance.HobbyP < seibutsugaku)
                {
                    seibutsugaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Seibutsugaku += seibutsugaku;
                    InputHobbyPSeibutsugaku.text = seibutsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= seibutsugaku;
                    StatusManager.Instance.Seibutsugaku -= inputhobbyp[50];
                    StatusManager.Instance.Seibutsugaku += seibutsugaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[50];
                }
                NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                inputhobbyp[50] = seibutsugaku;
                Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                break;
            case 411:        //地質学
                if ((int.Parse(InputWorkPTishitsugaku.text) + int.Parse(InputHobbyPTishitsugaku.text) + status[51]) > limit)
                {
                    InputHobbyPTishitsugaku.text = (limit - status[51] - int.Parse(InputWorkPTishitsugaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTishitsugaku.text) < 0)
                {
                    InputHobbyPTishitsugaku.text = "0";
                }
                tishitsugaku = int.Parse(InputHobbyPTishitsugaku.text);
                if (StatusManager.Instance.HobbyP < tishitsugaku)
                {
                    tishitsugaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Tishitsugaku += tishitsugaku;
                    InputHobbyPTishitsugaku.text = tishitsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= tishitsugaku;
                    StatusManager.Instance.Tishitsugaku -= inputhobbyp[51];
                    StatusManager.Instance.Tishitsugaku += tishitsugaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[51];
                }
                NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                inputhobbyp[51] = tishitsugaku;
                Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                break;
            case 412:        //電子工学
                if ((int.Parse(InputWorkPDenshikougaku.text) + int.Parse(InputHobbyPDenshikougaku.text) + status[52]) > limit)
                {
                    InputHobbyPDenshikougaku.text = (limit - status[52] - int.Parse(InputWorkPDenshikougaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPDenshikougaku.text) < 0)
                {
                    InputHobbyPDenshikougaku.text = "0";
                }
                denshikougaku = int.Parse(InputHobbyPDenshikougaku.text);
                if (StatusManager.Instance.HobbyP < denshikougaku)
                {
                    denshikougaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Denshikougaku += denshikougaku;
                    InputHobbyPDenshikougaku.text = denshikougaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= denshikougaku;
                    StatusManager.Instance.Denshikougaku -= inputhobbyp[52];
                    StatusManager.Instance.Denshikougaku += denshikougaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[52];
                }
                NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                inputhobbyp[52] = denshikougaku;
                Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                break;
            case 413:        //天文学
                if ((int.Parse(InputWorkPTenmongaku.text) + int.Parse(InputHobbyPTenmongaku.text) + status[53]) > limit)
                {
                    InputHobbyPTenmongaku.text = (limit - status[53] - int.Parse(InputWorkPTenmongaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPTenmongaku.text) < 0)
                {
                    InputHobbyPTenmongaku.text = "0";
                }
                tenmongaku = int.Parse(InputHobbyPTenmongaku.text);
                if (StatusManager.Instance.HobbyP < tenmongaku)
                {
                    tenmongaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Tenmongaku += tenmongaku;
                    InputHobbyPTenmongaku.text = tenmongaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= tenmongaku;
                    StatusManager.Instance.Tenmongaku -= inputhobbyp[53];
                    StatusManager.Instance.Tenmongaku += tenmongaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[53];
                }
                NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                inputhobbyp[53] = tenmongaku;
                Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                break;
            case 414:        //博物学
                if ((int.Parse(InputWorkPHakubutsugaku.text) + int.Parse(InputHobbyPHakubutsugaku.text) + status[54]) > limit)
                {
                    InputHobbyPHakubutsugaku.text = (limit - status[54] - int.Parse(InputWorkPHakubutsugaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPHakubutsugaku.text) < 0)
                {
                    InputHobbyPHakubutsugaku.text = "0";
                }
                hakubutsugaku = int.Parse(InputHobbyPHakubutsugaku.text);
                if (StatusManager.Instance.HobbyP < hakubutsugaku)
                {
                    hakubutsugaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Hakubutsugaku += hakubutsugaku;
                    InputHobbyPHakubutsugaku.text = hakubutsugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= hakubutsugaku;
                    StatusManager.Instance.Hakubutsugaku -= inputhobbyp[54];
                    StatusManager.Instance.Hakubutsugaku += hakubutsugaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[54];
                }
                NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                inputhobbyp[54] = hakubutsugaku;
                Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                break;
            case 415:        //物理学
                if ((int.Parse(InputWorkPButsurigaku.text) + int.Parse(InputHobbyPButsurigaku.text) + status[55]) > limit)
                {
                    InputHobbyPButsurigaku.text = (limit - status[55] - int.Parse(InputWorkPButsurigaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPButsurigaku.text) < 0)
                {
                    InputHobbyPButsurigaku.text = "0";
                }
                butsurigaku = int.Parse(InputHobbyPButsurigaku.text);
                if (StatusManager.Instance.HobbyP < butsurigaku)
                {
                    butsurigaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Butsurigaku += butsurigaku;
                    InputHobbyPButsurigaku.text = butsurigaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= butsurigaku;
                    StatusManager.Instance.Butsurigaku -= inputhobbyp[55];
                    StatusManager.Instance.Butsurigaku += butsurigaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[55];
                }
                NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                inputhobbyp[55] = butsurigaku;
                Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                break;
            case 416:        //法律
                if ((int.Parse(InputWorkPHouritsu.text) + int.Parse(InputHobbyPHouritsu.text) + status[56]) > limit)
                {
                    InputHobbyPHouritsu.text = (limit - status[56] - int.Parse(InputWorkPHouritsu.text)).ToString();
                }
                else if (int.Parse(InputHobbyPHouritsu.text) < 0)
                {
                    InputHobbyPHouritsu.text = "0";
                }
                houritsu = int.Parse(InputHobbyPHouritsu.text);
                if (StatusManager.Instance.HobbyP < houritsu)
                {
                    houritsu = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Houritsu += houritsu;
                    InputHobbyPHouritsu.text = houritsu.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= houritsu;
                    StatusManager.Instance.Houritsu -= inputhobbyp[56];
                    StatusManager.Instance.Houritsu += houritsu;
                    StatusManager.Instance.HobbyP += inputhobbyp[56];
                }
                NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                inputhobbyp[56] = houritsu;
                Afterstatus[56] = StatusManager.Instance.Houritsu;
                break;
            case 417:        //薬学
                if ((int.Parse(InputWorkPYakugaku.text) + int.Parse(InputHobbyPYakugaku.text) + status[57]) > limit)
                {
                    InputHobbyPYakugaku.text = (limit - status[57] - int.Parse(InputWorkPYakugaku.text)).ToString();
                }
                else if (int.Parse(InputHobbyPYakugaku.text) < 0)
                {
                    InputHobbyPYakugaku.text = "0";
                }
                yakugaku = int.Parse(InputHobbyPYakugaku.text);
                if (StatusManager.Instance.HobbyP < yakugaku)
                {
                    yakugaku = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Yakugaku += yakugaku;
                    InputHobbyPYakugaku.text = yakugaku.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= yakugaku;
                    StatusManager.Instance.Yakugaku -= inputhobbyp[57];
                    StatusManager.Instance.Yakugaku += yakugaku;
                    StatusManager.Instance.HobbyP += inputhobbyp[57];
                }
                NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                inputhobbyp[57] = yakugaku;
                Afterstatus[57] = StatusManager.Instance.Yakugaku;
                break;
            case 418:        //歴史
                if ((int.Parse(InputWorkPRekishi.text) + int.Parse(InputHobbyPRekishi.text) + status[58]) > limit)
                {
                    InputHobbyPRekishi.text = (limit - status[58] - int.Parse(InputWorkPRekishi.text)).ToString();
                }
                else if (int.Parse(InputHobbyPRekishi.text) < 0)
                {
                    InputHobbyPRekishi.text = "0";
                }
                rekishi = int.Parse(InputHobbyPRekishi.text);
                if (StatusManager.Instance.HobbyP < rekishi)
                {
                    rekishi = StatusManager.Instance.HobbyP;
                    StatusManager.Instance.HobbyP = 0;
                    StatusManager.Instance.Rekishi += rekishi;
                    InputHobbyPRekishi.text = rekishi.ToString();
                }
                else
                {
                    StatusManager.Instance.HobbyP -= rekishi;
                    StatusManager.Instance.Rekishi -= inputhobbyp[58];
                    StatusManager.Instance.Rekishi += rekishi;
                    StatusManager.Instance.HobbyP += inputhobbyp[58];
                }
                NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                inputhobbyp[58] = rekishi;
                Afterstatus[58] = StatusManager.Instance.Rekishi;
                break;
        }
    }

    //職業技能ポイント振り分けUPボタン
    public void UpWorkP(int BottunNo)
    {
        switch (BottunNo)
        {
            //戦闘技能ステータス
            case 0:     //回避
                if ((StatusManager.Instance.Kaihi < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kaihi += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[0] += 1;
                    InputWorkPKaihi.text = inputworkp[0].ToString();
                    NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.Instance.Kaihi;
                }
                else { return; }
                break;
            case 1:     //キック
                if ((StatusManager.Instance.Kikku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kikku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[1] += 1;
                    InputWorkPKikku.text = inputworkp[1].ToString();
                    NowKikku.text = StatusManager.Instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.Instance.Kikku;
                }
                else { return; }
                break;
            case 2:     //組み付き
                if ((StatusManager.Instance.Kumitsuki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kumitsuki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[2] += 1;
                    InputWorkPKumitsuki.text = inputworkp[2].ToString();
                    NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                }
                else { return; }
                break;
            case 3:     //こぶし
                if ((StatusManager.Instance.Kobushi < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kobushi += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[3] += 1;
                    InputWorkPKobushi.text = inputworkp[3].ToString();
                    NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.Instance.Kobushi;
                }
                else { return; }
                break;
            case 4:     //頭突き
                if ((StatusManager.Instance.Zutsuki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Zutsuki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[4] += 1;
                    InputWorkPZutsuki.text = inputworkp[4].ToString();
                    NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.Instance.Zutsuki;
                }
                else { return; }
                break;
            case 5:     //投擲
                if ((StatusManager.Instance.Toteki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Toteki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[5] += 1;
                    InputWorkPToteki.text = inputworkp[5].ToString();
                    NowToteki.text = StatusManager.Instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.Instance.Toteki;
                }
                else { return; }
                break;
            case 6:     //マーシャルアーツ
                if ((StatusManager.Instance.MSA < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.MSA += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[6] += 1;
                    InputWorkPMSA.text = inputworkp[6].ToString();
                    NowMSA.text = StatusManager.Instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.Instance.MSA;
                }
                else { return; }
                break;
            case 7:     //拳銃
                if ((StatusManager.Instance.Kenzyu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kenzyu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[7] += 1;
                    InputWorkPKenzyu.text = inputworkp[7].ToString();
                    NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.Instance.Kenzyu;
                }
                else { return; }
                break;
            case 8:     //サブマシンガン
                if ((StatusManager.Instance.SMG < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.SMG += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[8] += 1;
                    InputWorkPSMG.text = inputworkp[8].ToString();
                    NowSMG.text = StatusManager.Instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.Instance.SMG;
                }
                else { return; }
                break;
            case 9:     //ショットガン
                if ((StatusManager.Instance.SG < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.SG += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[9] += 1;
                    InputWorkPSG.text = inputworkp[9].ToString();
                    NowSG.text = StatusManager.Instance.SG.ToString();
                    Afterstatus[9] = StatusManager.Instance.SG;
                }
                else { return; }
                break;
            case 10:    //マシンガン
                if ((StatusManager.Instance.MG < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.MG += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[10] += 1;
                    InputWorkPMG.text = inputworkp[10].ToString();
                    NowMG.text = StatusManager.Instance.MG.ToString();
                    Afterstatus[10] = StatusManager.Instance.MG;
                }
                else { return; }
                break;
            case 11:    //ライフル
                if ((StatusManager.Instance.R < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.R += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[11] += 1;
                    InputWorkPR.text = inputworkp[11].ToString();
                    NowR.text = StatusManager.Instance.R.ToString();
                    Afterstatus[11] = StatusManager.Instance.R;
                }
                else { return; }
                break;

            //探索技能ステータス
            case 100:    //応急手当
                if ((StatusManager.Instance.Okyuteate < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Okyuteate += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[12] += 1;
                    InputWorkPOkyuteate.text = inputworkp[12].ToString();
                    NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.Instance.Okyuteate;
                }
                else { return; }
                break;
            case 101:    //鍵開け
                if ((StatusManager.Instance.Kagiake < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kagiake += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[13] += 1;
                    InputWorkPKagiake.text = inputworkp[13].ToString();
                    NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.Instance.Kagiake;
                }
                else { return; }
                break;
            case 102:    //隠す
                if ((StatusManager.Instance.Kakusu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kakusu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[14] += 1;
                    InputWorkPKakusu.text = inputworkp[14].ToString();
                    NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.Instance.Kakusu;
                }
                else { return; }
                break;
            case 103:    //隠れる
                if ((StatusManager.Instance.Kakureru < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kakureru += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[15] += 1;
                    InputWorkPKakureru.text = inputworkp[15].ToString();
                    NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.Instance.Kakureru;
                }
                else { return; }
                break;
            case 104:    //聞き耳
                if ((StatusManager.Instance.Kikimimi < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kikimimi += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[16] += 1;
                    InputWorkPKikimimi.text = inputworkp[16].ToString();
                    NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.Instance.Kikimimi;
                }
                else { return; }
                break;
            case 105:    //忍び歩き
                if ((StatusManager.Instance.Shinobiaruki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Shinobiaruki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[17] += 1;
                    InputWorkPShinobiaruki.text = inputworkp[17].ToString();
                    NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                }
                else { return; }
                break;
            case 106:    //写真術
                if ((StatusManager.Instance.Syashinzyutsu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Syashinzyutsu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[18] += 1;
                    InputWorkPSyashinzyutsu.text = inputworkp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                }
                else { return; }
                break;
            case 107:    //精神分析
                if ((StatusManager.Instance.Seshinbunseki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Seshinbunseki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[19] += 1;
                    InputWorkPSeshinbunseki.text = inputworkp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                }
                else { return; }
                break;
            case 108:    //追跡
                if ((StatusManager.Instance.Tsuiseki < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Tsuiseki += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[20] += 1;
                    InputWorkPTsuiseki.text = inputworkp[20].ToString();
                    NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                }
                else { return; }
                break;
            case 109:    //登攀
                if ((StatusManager.Instance.Touhan < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Touhan += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[21] += 1;
                    InputWorkPTouhan.text = inputworkp[21].ToString();
                    NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.Instance.Touhan;
                }
                else { return; }
                break;
            case 110:    //図書館
                if ((StatusManager.Instance.Tosyokan < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Tosyokan += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[22] += 1;
                    InputWorkPTosyokan.text = inputworkp[22].ToString();
                    NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.Instance.Tosyokan;
                }
                else { return; }
                break;
            case 111:    //目星
                if ((StatusManager.Instance.Meboshi < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Meboshi += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[23] += 1;
                    InputWorkPMeboshi.text = inputworkp[23].ToString();
                    NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.Instance.Meboshi;
                }
                else { return; }
                break;

            //行動技能ステータス
            case 200:    //運転
                if ((StatusManager.Instance.Unten < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Unten += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[24] += 1;
                    InputWorkPUnten.text = inputworkp[24].ToString();
                    NowUnten.text = StatusManager.Instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.Instance.Unten;
                }
                else { return; }
                break;
            case 201:    //機械修理
                if ((StatusManager.Instance.Kikaisyuri < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kikaisyuri += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[25] += 1;
                    InputWorkPKikaisyuri.text = inputworkp[25].ToString();
                    NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                }
                else { return; }
                break;
            case 202:    //重機械操作
                if ((StatusManager.Instance.Zyukikaisosa < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Zyukikaisosa += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[26] += 1;
                    InputWorkPZyukikaisosa.text = inputworkp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                }
                else { return; }
                break;
            case 203:    //乗馬
                if ((StatusManager.Instance.Zyoba < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Zyoba += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[27] += 1;
                    InputWorkPZyoba.text = inputworkp[27].ToString();
                    NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.Instance.Zyoba;
                }
                else { return; }
                break;
            case 204:    //水泳
                if ((StatusManager.Instance.Suiei < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Suiei += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[28] += 1;
                    InputWorkPSuiei.text = inputworkp[28].ToString();
                    NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.Instance.Suiei;
                }
                else { return; }
                break;
            case 205:    //制作
                if ((StatusManager.Instance.Sesaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Sesaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[29] += 1;
                    InputWorkPSesaku.text = inputworkp[29].ToString();
                    NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.Instance.Sesaku;
                }
                else { return; }
                break;
            case 206:    //操縦
                if ((StatusManager.Instance.Sozyu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Sozyu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[30] += 1;
                    InputWorkPSozyu.text = inputworkp[30].ToString();
                    NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.Instance.Sozyu;
                }
                else { return; }
                break;
            case 207:    //跳躍
                if ((StatusManager.Instance.Tyoyaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Tyoyaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[31] += 1;
                    InputWorkPTyoyaku.text = inputworkp[31].ToString();
                    NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                }
                else { return; }
                break;
            case 208:    //電気修理
                if ((StatusManager.Instance.Denkisyuri < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Denkisyuri += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[32] += 1;
                    InputWorkPDenkisyuri.text = inputworkp[32].ToString();
                    NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                }
                else { return; }
                break;
            case 209:    //ナビゲート
                if ((StatusManager.Instance.Nabigeto < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Nabigeto += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[33] += 1;
                    InputWorkPNabigeto.text = inputworkp[33].ToString();
                    NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.Instance.Nabigeto;
                }
                else { return; }
                break;
            case 210:    //変装
                if ((StatusManager.Instance.Hensou < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Hensou += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[34] += 1;
                    InputWorkPHensou.text = inputworkp[34].ToString();
                    NowHensou.text = StatusManager.Instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.Instance.Hensou;
                }
                else { return; }
                break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if ((StatusManager.Instance.Iikurume < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Iikurume += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[35] += 1;
                    InputWorkPIikurume.text = inputworkp[35].ToString();
                    NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.Instance.Iikurume;
                }
                else { return; }
                break;
            case 301:    //信用
                if ((StatusManager.Instance.Shinyou < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Shinyou += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[36] += 1;
                    InputWorkPShinyou.text = inputworkp[36].ToString();
                    NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.Instance.Shinyou;
                }
                else { return; }
                break;
            case 302:    //説得
                if ((StatusManager.Instance.Settoku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Settoku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[37] += 1;
                    InputWorkPSettoku.text = inputworkp[37].ToString();
                    NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.Instance.Settoku;
                }
                else { return; }
                break;
            case 303:    //値切り
                if ((StatusManager.Instance.Negiri < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Negiri += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[38] += 1;
                    InputWorkPNegiri.text = inputworkp[38].ToString();
                    NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.Instance.Negiri;
                }
                else { return; }
                break;
            case 304:    //母国語
                if ((StatusManager.Instance.Bokokugo < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Bokokugo += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[39] += 1;
                    InputWorkPBokokugo.text = inputworkp[39].ToString();
                    NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.Instance.Bokokugo;
                }
                else { return; }
                break;

            //知識技能ステータス
            case 400:    //医学
                if ((StatusManager.Instance.Igaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Igaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[40] += 1;
                    InputWorkPIgaku.text = inputworkp[40].ToString();
                    NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.Instance.Igaku;
                }
                else { return; }
                break;
            case 401:    //オカルト
                if ((StatusManager.Instance.Okaruto < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Okaruto += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[41] += 1;
                    InputWorkPOkaruto.text = inputworkp[41].ToString();
                    NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.Instance.Okaruto;
                }
                else { return; }
                break;
            case 402:    //化学
                if ((StatusManager.Instance.Kagaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kagaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[42] += 1;
                    InputWorkPKagaku.text = inputworkp[42].ToString();
                    NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.Instance.Kagaku;
                }
                else { return; }
                break;
            case 403:    //クトゥルフ神話
                if ((StatusManager.Instance.Shinwa < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Shinwa += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[43] += 1;
                    InputWorkPShinwa.text = inputworkp[43].ToString();
                    NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.Instance.Shinwa;
                }
                else { return; }
                break;
            case 404:    //芸術
                if ((StatusManager.Instance.Gezyutsu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Gezyutsu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[44] += 1;
                    InputWorkPGezyutsu.text = inputworkp[44].ToString();
                    NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                }
                else { return; }
                break;
            case 405:    //経理
                if ((StatusManager.Instance.Keiri < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Keiri += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[45] += 1;
                    InputWorkPKeiri.text = inputworkp[45].ToString();
                    NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.Instance.Keiri;
                }
                else { return; }
                break;
            case 406:    //考古学
                if ((StatusManager.Instance.Kokogaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Kokogaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[46] += 1;
                    InputWorkPKokogaku.text = inputworkp[46].ToString();
                    NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.Instance.Kokogaku;
                }
                else { return; }
                break;
            case 407:    //コンピューター
                if ((StatusManager.Instance.PC < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.PC += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[47] += 1;
                    InputWorkPPC.text = inputworkp[47].ToString();
                    NowPC.text = StatusManager.Instance.PC.ToString();
                    Afterstatus[47] = StatusManager.Instance.PC;
                }
                else { return; }
                break;
            case 408:    //心理学
                if ((StatusManager.Instance.Shinrigaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Shinrigaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[48] += 1;
                    InputWorkPShinrigaku.text = inputworkp[48].ToString();
                    NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                }
                else { return; }
                break;
            case 409:    //人類学
                if ((StatusManager.Instance.Zinruigaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Zinruigaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[49] += 1;
                    InputWorkPZinruigaku.text = inputworkp[49].ToString();
                    NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                }
                else { return; }
                break;
            case 410:    //生物学
                if ((StatusManager.Instance.Seibutsugaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Seibutsugaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[50] += 1;
                    InputWorkPSeibutsugaku.text = inputworkp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                }
                else { return; }
                break;
            case 411:    //地質学
                if ((StatusManager.Instance.Tishitsugaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Tishitsugaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[51] += 1;
                    InputWorkPTishitsugaku.text = inputworkp[51].ToString();
                    NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                }
                else { return; }
                break;
            case 412:    //電子工学
                if ((StatusManager.Instance.Denshikougaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Denshikougaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[52] += 1;
                    InputWorkPDenshikougaku.text = inputworkp[52].ToString();
                    NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                }
                else { return; }
                break;
            case 413:    //天文学
                if ((StatusManager.Instance.Tenmongaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Tenmongaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[53] += 1;
                    InputWorkPTenmongaku.text = inputworkp[53].ToString();
                    NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                }
                else { return; }
                break;
            case 414:    //博物学
                if ((StatusManager.Instance.Hakubutsugaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Hakubutsugaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[54] += 1;
                    InputWorkPHakubutsugaku.text = inputworkp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                }
                else { return; }
                break;
            case 415:    //物理学
                if ((StatusManager.Instance.Butsurigaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Butsurigaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[55] += 1;
                    InputWorkPButsurigaku.text = inputworkp[55].ToString();
                    NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                }
                else { return; }
                break;
            case 416:    //法律
                if ((StatusManager.Instance.Houritsu < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Houritsu += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[56] += 1;
                    InputWorkPHouritsu.text = inputworkp[56].ToString();
                    NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.Instance.Houritsu;
                }
                else { return; }
                break;
            case 417:    //薬学
                if ((StatusManager.Instance.Yakugaku < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Yakugaku += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[57] += 1;
                    InputWorkPYakugaku.text = inputworkp[57].ToString();
                    NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.Instance.Yakugaku;
                }
                else { return; }
                break;
            case 418:    //歴史
                if ((StatusManager.Instance.Rekishi < limit) && (StatusManager.Instance.WorkP != 0))
                {
                    StatusManager.Instance.Rekishi += 1;
                    StatusManager.Instance.WorkP -= 1;
                    inputworkp[58] += 1;
                    InputWorkPRekishi.text = inputworkp[58].ToString();
                    NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.Instance.Rekishi;
                }
                else { return; }
                break;
        }
    }

    //職業技能ポイント振り分けDownボタン
    public void DownWorkP(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:     //回避
                if (int.Parse(InputWorkPKaihi.text) > 0)
                {
                    StatusManager.Instance.Kaihi -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[0] -= 1;
                    InputWorkPKaihi.text = inputworkp[0].ToString();
                    NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.Instance.Kaihi;
                }
                else { return; }
                break;
            case 1:     //キック
                if (int.Parse(InputWorkPKikku.text) > 0)
                {
                    StatusManager.Instance.Kikku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[1] -= 1;
                    InputWorkPKikku.text = inputworkp[1].ToString();
                    NowKikku.text = StatusManager.Instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.Instance.Kikku;
                }
                else { return; }
                break;
            case 2:     //組み付き
                if (int.Parse(InputWorkPKumitsuki.text) > 0)
                {
                    StatusManager.Instance.Kumitsuki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[2] -= 1;
                    InputWorkPKumitsuki.text = inputworkp[2].ToString();
                    NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                }
                else { return; }
                break;
            case 3:     //こぶし
                if (int.Parse(InputWorkPKobushi.text) > 0)
                {
                    StatusManager.Instance.Kobushi -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[3] -= 1;
                    InputWorkPKobushi.text = inputworkp[3].ToString();
                    NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.Instance.Kobushi;
                }
                else { return; }
                break;
            case 4:     //頭突き
                if (int.Parse(InputWorkPZutsuki.text) > 0)
                {
                    StatusManager.Instance.Zutsuki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[4] -= 1;
                    InputWorkPZutsuki.text = inputworkp[4].ToString();
                    NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.Instance.Zutsuki;
                }
                else { return; }
                break;
            case 5:     //投擲
                if (int.Parse(InputWorkPToteki.text) > 0)
                {
                    StatusManager.Instance.Toteki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[5] -= 1;
                    InputWorkPToteki.text = inputworkp[5].ToString();
                    NowToteki.text = StatusManager.Instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.Instance.Toteki;
                }
                else { return; }
                break;
            case 6:     //マーシャルアーツ
                if (int.Parse(InputWorkPMSA.text) > 0)
                {
                    StatusManager.Instance.MSA -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[6] -= 1;
                    InputWorkPMSA.text = inputworkp[6].ToString();
                    NowMSA.text = StatusManager.Instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.Instance.MSA;
                }
                else { return; }
                break;
            case 7:     //拳銃
                if (int.Parse(InputWorkPKenzyu.text) > 0)
                {
                    StatusManager.Instance.Kenzyu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[7] -= 1;
                    InputWorkPKenzyu.text = inputworkp[7].ToString();
                    NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.Instance.Kenzyu;
                }
                else { return; }
                break;
            case 8:     //サブマシンガン
                if (int.Parse(InputWorkPSMG.text) > 0)
                {
                    StatusManager.Instance.SMG -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[8] -= 1;
                    InputWorkPSMG.text = inputworkp[8].ToString();
                    NowSMG.text = StatusManager.Instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.Instance.SMG;
                }
                else { return; }
                break;
            case 9:     //ショットガン
                if (int.Parse(InputWorkPSG.text) > 0)
                {
                    StatusManager.Instance.SG -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[9] -= 1;
                    InputWorkPSG.text = inputworkp[9].ToString();
                    NowSG.text = StatusManager.Instance.SG.ToString();
                    Afterstatus[9] = StatusManager.Instance.SG;
                }
                else { return; }
                break;
            case 10:    //マシンガン
                if (int.Parse(InputWorkPMG.text) > 0)
                {
                    StatusManager.Instance.MG -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[10] -= 1;
                    InputWorkPMG.text = inputworkp[10].ToString();
                    NowMG.text = StatusManager.Instance.MG.ToString();
                    Afterstatus[10] = StatusManager.Instance.MG;
                }
                else { return; }
                break;
            case 11:    //ライフル
                if (int.Parse(InputWorkPR.text) > 0)
                {
                    StatusManager.Instance.R -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[11] -= 1;
                    InputWorkPR.text = inputworkp[11].ToString();
                    NowR.text = StatusManager.Instance.R.ToString();
                    Afterstatus[11] = StatusManager.Instance.R;
                }
                else { return; }
                break;

            //探索技能ステータス
            case 100:    //応急手当
                if (int.Parse(InputWorkPOkyuteate.text) > 0)
                {
                    StatusManager.Instance.Okyuteate -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[12] -= 1;
                    InputWorkPOkyuteate.text = inputworkp[12].ToString();
                    NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.Instance.Okyuteate;
                }
                else { return; }
                break;
            case 101:    //鍵開け
                if (int.Parse(InputWorkPKagiake.text) > 0)
                {
                    StatusManager.Instance.Kagiake -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[13] -= 1;
                    InputWorkPKagiake.text = inputworkp[13].ToString();
                    NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.Instance.Kagiake;
                }
                else { return; }
                break;
            case 102:    //隠す
                if (int.Parse(InputWorkPKakusu.text) > 0)
                {
                    StatusManager.Instance.Kakusu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[14] -= 1;
                    InputWorkPKakusu.text = inputworkp[14].ToString();
                    NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.Instance.Kakusu;
                }
                else { return; }
                break;
            case 103:    //隠れる
                if (int.Parse(InputWorkPKakureru.text) > 0)
                {
                    StatusManager.Instance.Kakureru -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[15] -= 1;
                    InputWorkPKakureru.text = inputworkp[15].ToString();
                    NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.Instance.Kakureru;
                }
                else { return; }
                break;
            case 104:    //聞き耳
                if (int.Parse(InputWorkPKikimimi.text) > 0)
                {
                    StatusManager.Instance.Kikimimi -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[16] -= 1;
                    InputWorkPKikimimi.text = inputworkp[16].ToString();
                    NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.Instance.Kikimimi;
                }
                else { return; }
                break;
            case 105:    //忍び歩き
                if (int.Parse(InputWorkPShinobiaruki.text) > 0)
                {
                    StatusManager.Instance.Shinobiaruki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[17] -= 1;
                    InputWorkPShinobiaruki.text = inputworkp[17].ToString();
                    NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                }
                else { return; }
                break;
            case 106:    //写真術
                if (int.Parse(InputWorkPSyashinzyutsu.text) > 0)
                {
                    StatusManager.Instance.Syashinzyutsu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[18] -= 1;
                    InputWorkPSyashinzyutsu.text = inputworkp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                }
                else { return; }
                break;
            case 107:    //精神分析
                if (int.Parse(InputWorkPSeshinbunseki.text) > 0)
                {
                    StatusManager.Instance.Seshinbunseki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[19] -= 1;
                    InputWorkPSeshinbunseki.text = inputworkp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                }
                else { return; }
                break;
            case 108:    //追跡
                if (int.Parse(InputWorkPTsuiseki.text) > 0)
                {
                    StatusManager.Instance.Tsuiseki -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[20] -= 1;
                    InputWorkPTsuiseki.text = inputworkp[20].ToString();
                    NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                }
                else { return; }
                break;
            case 109:    //登攀
                if (int.Parse(InputWorkPTouhan.text) > 0)
                {
                    StatusManager.Instance.Touhan -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[21] -= 1;
                    InputWorkPTouhan.text = inputworkp[21].ToString();
                    NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.Instance.Touhan;
                }
                else { return; }
                break;
            case 110:    //図書館
                if (int.Parse(InputWorkPTosyokan.text) > 0)
                {
                    StatusManager.Instance.Tosyokan -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[22] -= 1;
                    InputWorkPTosyokan.text = inputworkp[22].ToString();
                    NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.Instance.Tosyokan;
                }
                else { return; }
                break;
            case 111:    //目星
                if (int.Parse(InputWorkPMeboshi.text) > 0)
                {
                    StatusManager.Instance.Meboshi -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[23] -= 1;
                    InputWorkPMeboshi.text = inputworkp[23].ToString();
                    NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.Instance.Meboshi;
                }
                else { return; }
                break;

            //行動技能ステータス
            case 200:    //運転
                if (int.Parse(InputWorkPUnten.text) > 0)
                {
                    StatusManager.Instance.Unten -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[24] -= 1;
                    InputWorkPUnten.text = inputworkp[24].ToString();
                    NowUnten.text = StatusManager.Instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.Instance.Unten;
                }
                else { return; }
                break;
            case 201:    //機械修理
                if (int.Parse(InputWorkPKikaisyuri.text) > 0)
                {
                    StatusManager.Instance.Kikaisyuri -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[25] -= 1;
                    InputWorkPKikaisyuri.text = inputworkp[25].ToString();
                    NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                }
                else { return; }
                break;
            case 202:    //重機械操作
                if (int.Parse(InputWorkPZyukikaisosa.text) > 0)
                {
                    StatusManager.Instance.Zyukikaisosa -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[26] -= 1;
                    InputWorkPZyukikaisosa.text = inputworkp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                }
                else { return; }
                break;
            case 203:    //乗馬
                if (int.Parse(InputWorkPZyoba.text) > 0)
                {
                    StatusManager.Instance.Zyoba -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[27] -= 1;
                    InputWorkPZyoba.text = inputworkp[27].ToString();
                    NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.Instance.Zyoba;
                }
                else { return; }
                break;
            case 204:    //水泳
                if (int.Parse(InputWorkPSuiei.text) > 0)
                {
                    StatusManager.Instance.Suiei -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[28] -= 1;
                    InputWorkPSuiei.text = inputworkp[28].ToString();
                    NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.Instance.Suiei;
                }
                else { return; }
                break;
            case 205:    //制作
                if (int.Parse(InputWorkPSesaku.text) > 0)
                {
                    StatusManager.Instance.Sesaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[29] -= 1;
                    InputWorkPSesaku.text = inputworkp[29].ToString();
                    NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.Instance.Sesaku;
                }
                else { return; }
                break;
            case 206:    //操縦
                if (int.Parse(InputWorkPSozyu.text) > 0)
                {
                    StatusManager.Instance.Sozyu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[30] -= 1;
                    InputWorkPSozyu.text = inputworkp[30].ToString();
                    NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.Instance.Sozyu;
                }
                else { return; }
                break;
            case 207:    //跳躍
                if (int.Parse(InputWorkPTyoyaku.text) > 0)
                {
                    StatusManager.Instance.Tyoyaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[31] -= 1;
                    InputWorkPTyoyaku.text = inputworkp[31].ToString();
                    NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                }
                else { return; }
                break;
            case 208:    //電気修理
                if (int.Parse(InputWorkPDenkisyuri.text) > 0)
                {
                    StatusManager.Instance.Denkisyuri -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[32] -= 1;
                    InputWorkPDenkisyuri.text = inputworkp[32].ToString();
                    NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                }
                else { return; }
                break;
            case 209:    //ナビゲート
                if (int.Parse(InputWorkPNabigeto.text) > 0)
                {
                    StatusManager.Instance.Nabigeto -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[33] -= 1;
                    InputWorkPNabigeto.text = inputworkp[33].ToString();
                    NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.Instance.Nabigeto;
                }
                else { return; }
                break;
            case 210:    //変装
                if (int.Parse(InputWorkPHensou.text) > 0)
                {
                    StatusManager.Instance.Hensou -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[34] -= 1;
                    InputWorkPHensou.text = inputworkp[34].ToString();
                    NowHensou.text = StatusManager.Instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.Instance.Hensou;
                }
                else { return; }
                break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if (int.Parse(InputWorkPIikurume.text) > 0)
                {
                    StatusManager.Instance.Iikurume -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[35] -= 1;
                    InputWorkPIikurume.text = inputworkp[35].ToString();
                    NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.Instance.Iikurume;
                }
                else { return; }
                break;
            case 301:    //信用
                if (int.Parse(InputWorkPShinyou.text) > 0)
                {
                    StatusManager.Instance.Shinyou -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[36] -= 1;
                    InputWorkPShinyou.text = inputworkp[36].ToString();
                    NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.Instance.Shinyou;
                }
                else { return; }
                break;
            case 302:    //説得
                if (int.Parse(InputWorkPSettoku.text) > 0)
                {
                    StatusManager.Instance.Settoku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[37] -= 1;
                    InputWorkPSettoku.text = inputworkp[37].ToString();
                    NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.Instance.Settoku;
                }
                else { return; }
                break;
            case 303:    //値切り
                if (int.Parse(InputWorkPNegiri.text) > 0)
                {
                    StatusManager.Instance.Negiri -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[38] -= 1;
                    InputWorkPNegiri.text = inputworkp[38].ToString();
                    NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.Instance.Negiri;
                }
                else { return; }
                break;
            case 304:    //母国語
                if (int.Parse(InputWorkPBokokugo.text) > 0)
                {
                    StatusManager.Instance.Bokokugo -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[39] -= 1;
                    InputWorkPBokokugo.text = inputworkp[39].ToString();
                    NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.Instance.Bokokugo;
                }
                else { return; }
                break;

            //知識技能ステータス
            case 400:    //医学
                if (int.Parse(InputWorkPIgaku.text) > 0)
                {
                    StatusManager.Instance.Igaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[40] -= 1;
                    InputWorkPIgaku.text = inputworkp[40].ToString();
                    NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.Instance.Igaku;
                }
                else { return; }
                break;
            case 401:    //オカルト
                if (int.Parse(InputWorkPOkaruto.text) > 0)
                {
                    StatusManager.Instance.Okaruto -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[41] -= 1;
                    InputWorkPOkaruto.text = inputworkp[41].ToString();
                    NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.Instance.Okaruto;
                }
                else { return; }
                break;
            case 402:    //化学
                if (int.Parse(InputWorkPKagaku.text) > 0)
                {
                    StatusManager.Instance.Kagaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[42] -= 1;
                    InputWorkPKagaku.text = inputworkp[42].ToString();
                    NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.Instance.Kagaku;
                }
                else { return; }
                break;
            case 403:    //クトゥルフ神話
                if (int.Parse(InputWorkPShinwa.text) > 0)
                {
                    StatusManager.Instance.Shinwa -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[43] -= 1;
                    InputWorkPShinwa.text = inputworkp[43].ToString();
                    NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.Instance.Shinwa;
                }
                else { return; }
                break;
            case 404:    //芸術
                if (int.Parse(InputWorkPGezyutsu.text) > 0)
                {
                    StatusManager.Instance.Gezyutsu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[44] -= 1;
                    InputWorkPGezyutsu.text = inputworkp[44].ToString();
                    NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                }
                else { return; }
                break;
            case 405:    //経理
                if (int.Parse(InputWorkPKeiri.text) > 0)
                {
                    StatusManager.Instance.Keiri -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[45] -= 1;
                    InputWorkPKeiri.text = inputworkp[45].ToString();
                    NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.Instance.Keiri;
                }
                else { return; }
                break;
            case 406:    //考古学
                if (int.Parse(InputWorkPKokogaku.text) > 0)
                {
                    StatusManager.Instance.Kokogaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[46] -= 1;
                    InputWorkPKokogaku.text = inputworkp[46].ToString();
                    NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.Instance.Kokogaku
                        ;
                }
                else { return; }
                break;
            case 407:    //コンピューター
                if (int.Parse(InputWorkPPC.text) > 0)
                {
                    StatusManager.Instance.PC -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[47] -= 1;
                    InputWorkPPC.text = inputworkp[47].ToString();
                    NowPC.text = StatusManager.Instance.PC.ToString();
                    Afterstatus[47] = StatusManager.Instance.PC;
                }
                else { return; }
                break;
            case 408:    //心理学
                if (int.Parse(InputWorkPShinrigaku.text) > 0)
                {
                    StatusManager.Instance.Shinrigaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[48] -= 1;
                    InputWorkPShinrigaku.text = inputworkp[48].ToString();
                    NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                }
                else { return; }
                break;
            case 409:    //人類学
                if (int.Parse(InputWorkPZinruigaku.text) > 0)
                {
                    StatusManager.Instance.Zinruigaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[49] -= 1;
                    InputWorkPZinruigaku.text = inputworkp[149].ToString();
                    NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                }
                else { return; }
                break;
            case 410:    //生物学
                if (int.Parse(InputWorkPSeibutsugaku.text) > 0)
                {
                    StatusManager.Instance.Seibutsugaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[50] -= 1;
                    InputWorkPSeibutsugaku.text = inputworkp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                }
                else { return; }
                break;
            case 411:    //地質学
                if (int.Parse(InputWorkPTishitsugaku.text) > 0)
                {
                    StatusManager.Instance.Tishitsugaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[51] -= 1;
                    InputWorkPTishitsugaku.text = inputworkp[51].ToString();
                    NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                }
                else { return; }
                break;
            case 412:    //電子工学
                if (int.Parse(InputWorkPDenshikougaku.text) > 0)
                {
                    StatusManager.Instance.Denshikougaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[52] -= 1;
                    InputWorkPDenshikougaku.text = inputworkp[52].ToString();
                    NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                }
                else { return; }
                break;
            case 413:    //天文学
                if (int.Parse(InputWorkPTenmongaku.text) > 0)
                {
                    StatusManager.Instance.Tenmongaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[53] -= 1;
                    InputWorkPTenmongaku.text = inputworkp[53].ToString();
                    NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                }
                else { return; }
                break;
            case 414:    //博物学
                if (int.Parse(InputWorkPHakubutsugaku.text) > 0)
                {
                    StatusManager.Instance.Hakubutsugaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[54] -= 1;
                    InputWorkPHakubutsugaku.text = inputworkp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                }
                else { return; }
                break;
            case 415:    //物理学
                if (int.Parse(InputWorkPButsurigaku.text) > 0)
                {
                    StatusManager.Instance.Butsurigaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    InputWorkPButsurigaku.text = inputworkp[55].ToString();
                    inputworkp[55] = StatusManager.Instance.Butsurigaku;
                    NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                }
                else { return; }
                break;
            case 416:    //法律
                if (int.Parse(InputWorkPHouritsu.text) > 0)
                {
                    StatusManager.Instance.Houritsu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[56] -= 1;
                    InputWorkPHouritsu.text = inputworkp[56].ToString();
                    NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.Instance.Houritsu;
                }
                else { return; }
                break;
            case 417:    //薬学
                if (int.Parse(InputWorkPYakugaku.text) > 0)
                {
                    StatusManager.Instance.Yakugaku -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[57] -= 1;
                    InputWorkPYakugaku.text = inputworkp[57].ToString();
                    NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.Instance.Yakugaku;
                }
                else { return; }
                break;
            case 418:    //歴史
                if (int.Parse(InputWorkPRekishi.text) > 0)
                {
                    StatusManager.Instance.Rekishi -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputworkp[58] -= 1;
                    InputWorkPRekishi.text = inputworkp[58].ToString();
                    NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.Instance.Rekishi;
                }
                else { return; }
                break;
        }
    }

    //趣味技能ポイント振り分けUPボタン
    public void UpHobbyP(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:     //回避
                if ((StatusManager.Instance.Kaihi < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kaihi += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[0] += 1;
                    InputHobbyPKaihi.text = inputhobbyp[0].ToString();
                    NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.Instance.Kaihi;
                }
                else { return; }
                break;
            case 1:     //キック
                if ((StatusManager.Instance.Kikku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kikku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[1] += 1;
                    InputHobbyPKikku.text = inputhobbyp[1].ToString();
                    NowKikku.text = StatusManager.Instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.Instance.Kikku;
                }
                else { return; }
                break;
            case 2:     //組み付き
                if ((StatusManager.Instance.Kumitsuki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kumitsuki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[2] += 1;
                    InputHobbyPKumitsuki.text = inputhobbyp[2].ToString();
                    NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                }
                else { return; }
                break;
            case 3:     //こぶし
                if ((StatusManager.Instance.Kobushi < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kobushi += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[3] += 1;
                    InputHobbyPKobushi.text = inputhobbyp[3].ToString();
                    NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.Instance.Kobushi;
                }
                else { return; }
                break;
            case 4:     //頭突き
                if ((StatusManager.Instance.Zutsuki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Zutsuki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[4] += 1;
                    InputHobbyPZutsuki.text = inputhobbyp[4].ToString();
                    NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.Instance.Zutsuki;
                }
                else { return; }
                break;
            case 5:     //投擲
                if ((StatusManager.Instance.Toteki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Toteki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[5] += 1;
                    InputHobbyPToteki.text = inputhobbyp[5].ToString();
                    NowToteki.text = StatusManager.Instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.Instance.Toteki;
                }
                else { return; }
                break;
            case 6:     //マーシャルアーツ
                if ((StatusManager.Instance.MSA < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.MSA += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[6] += 1;
                    InputHobbyPMSA.text = inputhobbyp[6].ToString();
                    NowMSA.text = StatusManager.Instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.Instance.MSA;
                }
                else { return; }
                break;
            case 7:     //拳銃
                if ((StatusManager.Instance.Kenzyu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kenzyu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[7] += 1;
                    InputHobbyPKenzyu.text = inputhobbyp[7].ToString();
                    NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.Instance.Kenzyu;
                }
                else { return; }
                break;
            case 8:     //サブマシンガン
                if ((StatusManager.Instance.SMG < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.SMG += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[8] += 1;
                    InputHobbyPSMG.text = inputhobbyp[8].ToString();
                    NowSMG.text = StatusManager.Instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.Instance.SMG;
                }
                else { return; }
                break;
            case 9:     //ショットガン
                if ((StatusManager.Instance.SG < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.SG += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[9] += 1;
                    InputHobbyPSG.text = inputhobbyp[9].ToString();
                    NowSG.text = StatusManager.Instance.SG.ToString();
                    Afterstatus[9] = StatusManager.Instance.SG;
                }
                else { return; }
                break;
            case 10:    //マシンガン
                if ((StatusManager.Instance.MG < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.MG += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[10] += 1;
                    InputHobbyPMG.text = inputhobbyp[10].ToString();
                    NowMG.text = StatusManager.Instance.MG.ToString();
                    Afterstatus[10] = StatusManager.Instance.MG;
                }
                else { return; }
                break;
            case 11:    //ライフル
                if ((StatusManager.Instance.R < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.R += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[11] += 1;
                    InputHobbyPR.text = inputhobbyp[11].ToString();
                    NowR.text = StatusManager.Instance.R.ToString();
                    Afterstatus[11] = StatusManager.Instance.R;
                }
                else { return; }
                break;

            //探索技能ステータス
            case 100:    //応急手当
                if ((StatusManager.Instance.Okyuteate < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Okyuteate += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[12] += 1;
                    InputHobbyPOkyuteate.text = inputhobbyp[12].ToString();
                    NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.Instance.Okyuteate;
                }
                else { return; }
                break;
            case 101:    //鍵開け
                if ((StatusManager.Instance.Kagiake < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kagiake += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[13] += 1;
                    InputHobbyPKagiake.text = inputhobbyp[14].ToString();
                    NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.Instance.Kagiake;
                }
                else { return; }
                break;
            case 102:    //隠す
                if ((StatusManager.Instance.Kakusu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kakusu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[14] += 1;
                    InputHobbyPKakusu.text = inputhobbyp[14].ToString();
                    NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.Instance.Kakusu;
                }
                else { return; }
                break;
            case 103:    //隠れる
                if ((StatusManager.Instance.Kakureru < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kakureru += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[15] += 1;
                    InputHobbyPKakureru.text = inputhobbyp[15].ToString();
                    NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.Instance.Kakureru;
                }
                else { return; }
                break;
            case 104:    //聞き耳
                if ((StatusManager.Instance.Kikimimi < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kikimimi += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[16] += 1;
                    InputHobbyPKikimimi.text = inputhobbyp[16].ToString();
                    NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.Instance.Kikimimi;
                }
                else { return; }
                break;
            case 105:    //忍び歩き
                if ((StatusManager.Instance.Shinobiaruki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Shinobiaruki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[17] += 1;
                    InputHobbyPShinobiaruki.text = inputhobbyp[17].ToString();
                    NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                }
                else { return; }
                break;
            case 106:    //写真術
                if ((StatusManager.Instance.Syashinzyutsu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Syashinzyutsu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[18] += 1;
                    InputHobbyPSyashinzyutsu.text = inputhobbyp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                }
                else { return; }
                break;
            case 107:    //精神分析
                if ((StatusManager.Instance.Seshinbunseki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Seshinbunseki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[19] += 1;
                    InputHobbyPSeshinbunseki.text = inputhobbyp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                }
                else { return; }
                break;
            case 108:    //追跡
                if ((StatusManager.Instance.Tsuiseki < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Tsuiseki += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[20] += 1;
                    InputHobbyPTsuiseki.text = inputhobbyp[20].ToString();
                    NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                }
                else { return; }
                break;
            case 109:    //登攀
                if ((StatusManager.Instance.Touhan < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Touhan += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[21] += 1;
                    InputHobbyPTouhan.text = inputhobbyp[21].ToString();
                    NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.Instance.Touhan;
                }
                else { return; }
                break;
            case 110:    //図書館
                if ((StatusManager.Instance.Tosyokan < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Tosyokan += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[22] += 1;
                    InputHobbyPTosyokan.text = inputhobbyp[22].ToString();
                    NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.Instance.Tosyokan;
                }
                else { return; }
                break;
            case 111:    //目星
                if ((StatusManager.Instance.Meboshi < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Meboshi += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[23] += 1;
                    InputHobbyPMeboshi.text = inputhobbyp[23].ToString();
                    NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.Instance.Meboshi;
                }
                else { return; }
                break;

            //行動技能ステータス
            case 200:    //運転
                if ((StatusManager.Instance.Unten < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Unten += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[24] += 1;
                    InputHobbyPUnten.text = inputhobbyp[24].ToString();
                    NowUnten.text = StatusManager.Instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.Instance.Unten;
                }
                else { return; }
                break;
            case 201:    //機械修理
                if ((StatusManager.Instance.Kikaisyuri < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kikaisyuri += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[25] += 1;
                    InputHobbyPKikaisyuri.text = inputhobbyp[25].ToString();
                    NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                }
                else { return; }
                break;
            case 202:    //重機械操作
                if ((StatusManager.Instance.Zyukikaisosa < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Zyukikaisosa += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[26] += 1;
                    InputHobbyPZyukikaisosa.text = inputhobbyp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                }
                else { return; }
                break;
            case 203:    //乗馬
                if ((StatusManager.Instance.Zyoba < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Zyoba += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[27] += 1;
                    InputHobbyPZyoba.text = inputhobbyp[27].ToString();
                    NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.Instance.Zyoba;
                }
                else { return; }
                break;
            case 204:    //水泳
                if ((StatusManager.Instance.Suiei < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Suiei += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[28] += 1;
                    InputHobbyPSuiei.text = inputhobbyp[28].ToString();
                    NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.Instance.Suiei;
                }
                else { return; }
                break;
            case 205:    //制作
                if ((StatusManager.Instance.Sesaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Sesaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[29] += 1;
                    InputHobbyPSesaku.text = inputhobbyp[29].ToString();
                    NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.Instance.Sesaku;
                }
                else { return; }
                break;
            case 206:    //操縦
                if ((StatusManager.Instance.Sozyu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Sozyu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[30] += 1;
                    InputHobbyPSozyu.text = inputhobbyp[30].ToString();
                    NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.Instance.Sozyu;
                }
                else { return; }
                break;
            case 207:    //跳躍
                if ((StatusManager.Instance.Tyoyaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Tyoyaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[31] += 1;
                    InputHobbyPTyoyaku.text = inputhobbyp[31].ToString();
                    NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                }
                else { return; }
                break;
            case 208:    //電気修理
                if ((StatusManager.Instance.Denkisyuri < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Denkisyuri += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[32] += 1;
                    InputHobbyPDenkisyuri.text = inputhobbyp[32].ToString();
                    NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                }
                else { return; }
                break;
            case 209:    //ナビゲート
                if ((StatusManager.Instance.Nabigeto < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Nabigeto += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[33] += 1;
                    InputHobbyPNabigeto.text = inputhobbyp[33].ToString();
                    NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.Instance.Nabigeto;
                }
                else { return; }
                break;
            case 210:    //変装
                if ((StatusManager.Instance.Hensou < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Hensou += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[34] += 1;
                    InputHobbyPHensou.text = inputhobbyp[34].ToString();
                    NowHensou.text = StatusManager.Instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.Instance.Hensou;
                }
                else { return; }
                break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if ((StatusManager.Instance.Iikurume < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Iikurume += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[35] += 1;
                    InputHobbyPIikurume.text = inputhobbyp[35].ToString();
                    NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.Instance.Iikurume;
                }
                else { return; }
                break;
            case 301:    //信用
                if ((StatusManager.Instance.Shinyou < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Shinyou += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[36] += 1;
                    InputHobbyPShinyou.text = inputhobbyp[36].ToString();
                    NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.Instance.Shinyou;
                }
                else { return; }
                break;
            case 302:    //説得
                if ((StatusManager.Instance.Settoku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Settoku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[37] += 1;
                    InputHobbyPSettoku.text = inputhobbyp[37].ToString();
                    NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.Instance.Settoku;
                }
                else { return; }
                break;
            case 303:    //値切り
                if ((StatusManager.Instance.Negiri < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Negiri += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[38] += 1;
                    InputHobbyPNegiri.text = inputhobbyp[38].ToString();
                    NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.Instance.Negiri;
                }
                else { return; }
                break;
            case 304:    //母国語
                if ((StatusManager.Instance.Bokokugo < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Bokokugo += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[39] += 1;
                    InputHobbyPBokokugo.text = inputhobbyp[39].ToString();
                    NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.Instance.Bokokugo;
                }
                else { return; }
                break;

            //知識技能ステータス
            case 400:    //医学
                if ((StatusManager.Instance.Igaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Igaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[40] += 1;
                    InputHobbyPIgaku.text = inputhobbyp[40].ToString();
                    NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.Instance.Igaku;
                }
                else { return; }
                break;
            case 401:    //オカルト
                if ((StatusManager.Instance.Okaruto < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Okaruto += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[41] += 1;
                    InputHobbyPOkaruto.text = inputhobbyp[41].ToString();
                    NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.Instance.Okaruto;
                }
                else { return; }
                break;
            case 402:    //化学
                if ((StatusManager.Instance.Kagaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kagaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[42] += 1;
                    InputHobbyPKagaku.text = inputhobbyp[42].ToString();
                    NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.Instance.Kagaku;
                }
                else { return; }
                break;
            case 403:    //クトゥルフ神話
                if ((StatusManager.Instance.Shinwa < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Shinwa += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[43] += 1;
                    InputHobbyPShinwa.text = inputhobbyp[43].ToString();
                    NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.Instance.Shinwa;
                }
                else { return; }
                break;
            case 404:    //芸術
                if ((StatusManager.Instance.Gezyutsu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Gezyutsu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[44] += 1;
                    InputHobbyPGezyutsu.text = inputhobbyp[44].ToString();
                    NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                }
                else { return; }
                break;
            case 405:    //経理
                if ((StatusManager.Instance.Keiri < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Keiri += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[45] += 1;
                    InputHobbyPKeiri.text = inputhobbyp[45].ToString();
                    NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.Instance.Keiri;
                }
                else { return; }
                break;
            case 406:    //考古学
                if ((StatusManager.Instance.Kokogaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Kokogaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[46] += 1;
                    InputHobbyPKokogaku.text = inputhobbyp[46].ToString();
                    NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.Instance.Kokogaku;
                }
                else { return; }
                break;
            case 407:    //コンピューター
                if ((StatusManager.Instance.PC < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.PC += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[47] += 1;
                    InputHobbyPPC.text = inputhobbyp[47].ToString();
                    NowPC.text = StatusManager.Instance.PC.ToString();
                    Afterstatus[47] = StatusManager.Instance.PC;
                }
                else { return; }
                break;
            case 408:    //心理学
                if ((StatusManager.Instance.Shinrigaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Shinrigaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[48] += 1;
                    InputHobbyPShinrigaku.text = inputhobbyp[48].ToString();
                    NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                }
                else { return; }
                break;
            case 409:    //人類学
                if ((StatusManager.Instance.Zinruigaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Zinruigaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[49] += 1;
                    InputHobbyPZinruigaku.text = inputhobbyp[49].ToString();
                    NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                }
                else { return; }
                break;
            case 410:    //生物学
                if ((StatusManager.Instance.Seibutsugaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Seibutsugaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[50] += 1;
                    InputHobbyPSeibutsugaku.text = inputhobbyp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                }
                else { return; }
                break;
            case 411:    //地質学
                if ((StatusManager.Instance.Tishitsugaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Tishitsugaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[51] += 1;
                    InputHobbyPTishitsugaku.text = inputhobbyp[51].ToString();
                    NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                }
                else { return; }
                break;
            case 412:    //電子工学
                if ((StatusManager.Instance.Denshikougaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Denshikougaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[52] += 1;
                    InputHobbyPDenshikougaku.text = inputhobbyp[52].ToString();
                    NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                }
                else { return; }
                break;
            case 413:    //天文学
                if ((StatusManager.Instance.Tenmongaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Tenmongaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[53] += 1;
                    InputHobbyPTenmongaku.text = inputhobbyp[53].ToString();
                    NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                }
                else { return; }
                break;
            case 414:    //博物学
                if ((StatusManager.Instance.Hakubutsugaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Hakubutsugaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[54] += 1;
                    InputHobbyPHakubutsugaku.text = inputhobbyp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                }
                else { return; }
                break;
            case 415:    //物理学
                if ((StatusManager.Instance.Butsurigaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Butsurigaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[55] += 1;
                    InputHobbyPButsurigaku.text = inputhobbyp[55].ToString();
                    NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                }
                else { return; }
                break;
            case 416:    //法律
                if ((StatusManager.Instance.Houritsu < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Houritsu += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[56] += 1;
                    InputHobbyPHouritsu.text = inputhobbyp[56].ToString();
                    NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.Instance.Houritsu;
                }
                else { return; }
                break;
            case 417:    //薬学
                if ((StatusManager.Instance.Yakugaku < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Yakugaku += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[57] += 1;
                    InputHobbyPYakugaku.text = inputhobbyp[57].ToString();
                    NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.Instance.Yakugaku;
                }
                else { return; }
                break;
            case 418:    //歴史
                if ((StatusManager.Instance.Rekishi < limit) && (StatusManager.Instance.HobbyP != 0))
                {
                    StatusManager.Instance.Rekishi += 1;
                    StatusManager.Instance.HobbyP -= 1;
                    inputhobbyp[58] += 1;
                    InputHobbyPRekishi.text = inputhobbyp[58].ToString();
                    NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.Instance.Rekishi;
                }
                else { return; }
                break;
        }
    }

    //趣味技能ポイント振り分けDownボタン
    public void DownHobbyP(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:
                if (int.Parse(InputHobbyPKaihi.text) > 0)
                {
                    StatusManager.Instance.Kaihi -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[0] -= 1;
                    InputHobbyPKaihi.text = inputhobbyp[0].ToString();
                    NowKaihi.text = StatusManager.Instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.Instance.Kaihi;
                }
                else { return; }
                break;
            case 1:     //キック
                if (int.Parse(InputHobbyPKikku.text) > 0)
                {
                    StatusManager.Instance.Kikku -= 1;
                    inputhobbyp[1] -= 1;
                    InputHobbyPKikku.text = inputhobbyp[1].ToString();
                    NowKikku.text = StatusManager.Instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.Instance.Kikku;
                }
                else { return; }
                break;
            case 2:     //組み付き
                if (int.Parse(InputHobbyPKumitsuki.text) > 0)
                {
                    StatusManager.Instance.Kumitsuki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[2] -= 1;
                    InputHobbyPKumitsuki.text = inputhobbyp[2].ToString();
                    NowKumitsuki.text = StatusManager.Instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.Instance.Kumitsuki;
                }
                else { return; }
                break;
            case 3:     //こぶし
                if (int.Parse(InputHobbyPKobushi.text) > 0)
                {
                    StatusManager.Instance.Kobushi -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[3] -= 1;
                    InputHobbyPKobushi.text = inputhobbyp[3].ToString();
                    NowKobushi.text = StatusManager.Instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.Instance.Kobushi;
                }
                else { return; }
                break;
            case 4:     //頭突き
                if (int.Parse(InputHobbyPZutsuki.text) > 0)
                {
                    StatusManager.Instance.Zutsuki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[4] -= 1;
                    InputHobbyPZutsuki.text = inputhobbyp[4].ToString();
                    NowZutsuki.text = StatusManager.Instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.Instance.Zutsuki;
                }
                else { return; }
                break;
            case 5:     //投擲
                if (int.Parse(InputHobbyPToteki.text) > 0)
                {
                    StatusManager.Instance.Toteki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[5] -= 1;
                    InputHobbyPToteki.text = inputhobbyp[5].ToString();
                    NowToteki.text = StatusManager.Instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.Instance.Toteki;
                }
                else { return; }
                break;
            case 6:     //マーシャルアーツ
                if (int.Parse(InputHobbyPMSA.text) > 0)
                {
                    StatusManager.Instance.MSA -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[6] -= 1;
                    InputHobbyPMSA.text = inputhobbyp[6].ToString();
                    NowMSA.text = StatusManager.Instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.Instance.MSA;
                }
                else { return; }
                break;
            case 7:     //拳銃
                if (int.Parse(InputHobbyPKenzyu.text) > 0)
                {
                    StatusManager.Instance.Kenzyu -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[7] -= 1;
                    InputHobbyPKenzyu.text = inputhobbyp[7].ToString();
                    NowKenzyu.text = StatusManager.Instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.Instance.Kenzyu;
                }
                else { return; }
                break;
            case 8:     //サブマシンガン
                if (int.Parse(InputHobbyPSMG.text) > 0)
                {
                    StatusManager.Instance.SMG -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[8] -= 1;
                    InputHobbyPSMG.text = inputhobbyp[8].ToString();
                    NowSMG.text = StatusManager.Instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.Instance.SMG;
                }
                else { return; }
                break;
            case 9:     //ショットガン
                if (int.Parse(InputHobbyPSG.text) > 0)
                {
                    StatusManager.Instance.SG -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[9] -= 1;
                    InputHobbyPSG.text = inputhobbyp[9].ToString();
                    NowSG.text = StatusManager.Instance.SG.ToString();
                    Afterstatus[9] = StatusManager.Instance.SG;
                }
                else { return; }
                break;
            case 10:    //マシンガン
                if (int.Parse(InputHobbyPMG.text) > 0)
                {
                    StatusManager.Instance.MG -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[10] -= 1;
                    InputHobbyPMG.text = inputhobbyp[10].ToString();
                    NowMG.text = StatusManager.Instance.MG.ToString();
                    Afterstatus[10] = StatusManager.Instance.MG;
                }
                else { return; }
                break;
            case 11:    //ライフル
                if (int.Parse(InputHobbyPR.text) > 0)
                {
                    StatusManager.Instance.R -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[11] -= 1;
                    InputHobbyPR.text = inputhobbyp[11].ToString();
                    NowR.text = StatusManager.Instance.R.ToString();
                    Afterstatus[11] = StatusManager.Instance.R;
                }
                else { return; }
                break;

            //探索技能ステータス
            case 100:    //応急手当
                if (int.Parse(InputHobbyPOkyuteate.text) > 0)
                {
                    StatusManager.Instance.Okyuteate -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[12] -= 1;
                    InputHobbyPOkyuteate.text = inputhobbyp[12].ToString();
                    NowOkyuteate.text = StatusManager.Instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.Instance.Okyuteate;
                }
                else { return; }
                break;
            case 101:    //鍵開け
                if (int.Parse(InputHobbyPKagiake.text) > 0)
                {
                    StatusManager.Instance.Kagiake -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[13] -= 1;
                    InputHobbyPKagiake.text = inputhobbyp[13].ToString();
                    NowKagiake.text = StatusManager.Instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.Instance.Kagiake;
                }
                else { return; }
                break;
            case 102:    //隠す
                if (int.Parse(InputHobbyPKakusu.text) > 0)
                {
                    StatusManager.Instance.Kakusu -= 1;
                    StatusManager.Instance.WorkP += 1;
                    inputhobbyp[14] -= 1;
                    InputHobbyPKakusu.text = inputhobbyp[14].ToString();
                    NowKakusu.text = StatusManager.Instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.Instance.Kakusu;
                }
                else { return; }
                break;
            case 103:    //隠れる
                if (int.Parse(InputHobbyPKakureru.text) > 0)
                {
                    StatusManager.Instance.Kakureru -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[15] -= 1;
                    InputHobbyPKakureru.text = inputhobbyp[15].ToString();
                    NowKakureru.text = StatusManager.Instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.Instance.Kakureru;
                }
                else { return; }
                break;
            case 104:    //聞き耳
                if (int.Parse(InputHobbyPKikimimi.text) > 0)
                {
                    StatusManager.Instance.Kikimimi -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[16] -= 1;
                    InputHobbyPKikimimi.text = inputhobbyp[16].ToString();
                    NowKikimimi.text = StatusManager.Instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.Instance.Kikimimi;
                }
                else { return; }
                break;
            case 105:    //忍び歩き
                if (int.Parse(InputHobbyPShinobiaruki.text) > 0)
                {
                    StatusManager.Instance.Shinobiaruki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[17] -= 1;
                    InputHobbyPShinobiaruki.text = inputhobbyp[17].ToString();
                    NowShinobiaruki.text = StatusManager.Instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.Instance.Shinobiaruki;
                }
                else { return; }
                break;
            case 106:    //写真術
                if (int.Parse(InputHobbyPSyashinzyutsu.text) > 0)
                {
                    StatusManager.Instance.Syashinzyutsu -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[18] -= 1;
                    InputHobbyPSyashinzyutsu.text = inputhobbyp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.Instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.Instance.Syashinzyutsu;
                }
                else { return; }
                break;
            case 107:    //精神分析
                if (int.Parse(InputHobbyPSeshinbunseki.text) > 0)
                {
                    StatusManager.Instance.Seshinbunseki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[19] -= 1;
                    InputHobbyPSeshinbunseki.text = inputhobbyp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.Instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.Instance.Seshinbunseki;
                }
                else { return; }
                break;
            case 108:    //追跡
                if (int.Parse(InputHobbyPTsuiseki.text) > 0)
                {
                    StatusManager.Instance.Tsuiseki -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[20] -= 1;
                    InputHobbyPTsuiseki.text = inputhobbyp[20].ToString();
                    NowTsuiseki.text = StatusManager.Instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.Instance.Tsuiseki;
                }
                else { return; }
                break;
            case 109:    //登攀
                if (int.Parse(InputHobbyPTouhan.text) > 0)
                {
                    StatusManager.Instance.Touhan -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[21] -= 1;
                    InputHobbyPTouhan.text = inputhobbyp[21].ToString();
                    NowTouhan.text = StatusManager.Instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.Instance.Touhan;
                }
                else { return; }
                break;
            case 110:    //図書館
                if (int.Parse(InputHobbyPTosyokan.text) > 0)
                {
                    StatusManager.Instance.Tosyokan -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[22] -= 1;
                    InputHobbyPTosyokan.text = inputhobbyp[22].ToString();
                    NowTosyokan.text = StatusManager.Instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.Instance.Tosyokan;
                }
                else { return; }
                break;
            case 111:    //目星
                if (int.Parse(InputHobbyPMeboshi.text) > 0)
                {
                    StatusManager.Instance.Meboshi -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[23] -= 1;
                    InputHobbyPMeboshi.text = inputhobbyp[23].ToString();
                    NowMeboshi.text = StatusManager.Instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.Instance.Meboshi;
                }
                else { return; }
                break;

            //行動技能ステータス
            case 200:    //運転
                if (int.Parse(InputHobbyPUnten.text) > 0)
                {
                    StatusManager.Instance.Unten -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[24] -= 1;
                    InputHobbyPUnten.text = inputhobbyp[24].ToString();
                    NowUnten.text = StatusManager.Instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.Instance.Unten;
                }
                else { return; }
                break;
            case 201:    //機械修理
                if (int.Parse(InputHobbyPKikaisyuri.text) > 0)
                {
                    StatusManager.Instance.Kikaisyuri -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[25] -= 1;
                    InputHobbyPKikaisyuri.text = inputhobbyp[25].ToString();
                    NowKikaisyuri.text = StatusManager.Instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.Instance.Kikaisyuri;
                }
                else { return; }
                break;
            case 202:    //重機械操作
                if (int.Parse(InputHobbyPZyukikaisosa.text) > 0)
                {
                    StatusManager.Instance.Zyukikaisosa -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[26] -= 1;
                    InputHobbyPZyukikaisosa.text = inputhobbyp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.Instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.Instance.Zyukikaisosa;
                }
                else { return; }
                break;
            case 203:    //乗馬
                if (int.Parse(InputHobbyPZyoba.text) > 0)
                {
                    StatusManager.Instance.Zyoba -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[27] -= 1;
                    InputHobbyPZyoba.text = inputhobbyp[27].ToString();
                    NowZyoba.text = StatusManager.Instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.Instance.Zyoba;
                }
                else { return; }
                break;
            case 204:    //水泳
                if (int.Parse(InputHobbyPSuiei.text) > 0)
                {
                    StatusManager.Instance.Suiei -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[28] -= 1;
                    InputHobbyPSuiei.text = inputhobbyp[28].ToString();
                    NowSuiei.text = StatusManager.Instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.Instance.Suiei;
                }
                else { return; }
                break;
            case 205:    //制作
                if (int.Parse(InputHobbyPSesaku.text) > 0)
                {
                    StatusManager.Instance.Sesaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[29] -= 1;
                    InputHobbyPSesaku.text = inputhobbyp[29].ToString();
                    NowSesaku.text = StatusManager.Instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.Instance.Sesaku;
                }
                else { return; }
                break;
            case 206:    //操縦
                if (int.Parse(InputHobbyPSozyu.text) > 0)
                {
                    StatusManager.Instance.Sozyu -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[30] -= 1;
                    InputHobbyPSozyu.text = inputhobbyp[30].ToString();
                    NowSozyu.text = StatusManager.Instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.Instance.Sozyu;
                }
                else { return; }
                break;
            case 207:    //跳躍
                if (int.Parse(InputHobbyPTyoyaku.text) > 0)
                {
                    StatusManager.Instance.Tyoyaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[31] -= 1;
                    InputHobbyPTyoyaku.text = inputhobbyp[31].ToString();
                    NowTyoyaku.text = StatusManager.Instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.Instance.Tyoyaku;
                }
                else { return; }
                break;
            case 208:    //電気修理
                if (int.Parse(InputHobbyPDenkisyuri.text) > 0)
                {
                    StatusManager.Instance.Denkisyuri -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[32] -= 1;
                    InputHobbyPDenkisyuri.text = inputhobbyp[32].ToString();
                    NowDenkisyuri.text = StatusManager.Instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.Instance.Denkisyuri;
                }
                else { return; }
                break;
            case 209:    //ナビゲート
                if (int.Parse(InputHobbyPNabigeto.text) > 0)
                {
                    StatusManager.Instance.Nabigeto -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[33] -= 1;
                    InputHobbyPNabigeto.text = inputhobbyp[33].ToString();
                    NowNabigeto.text = StatusManager.Instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.Instance.Nabigeto;
                }
                else { return; }
                break;
            case 210:    //変装
                if (int.Parse(InputHobbyPHensou.text) > 0)
                {
                    StatusManager.Instance.Hensou -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[34] -= 1;
                    InputHobbyPHensou.text = inputhobbyp[34].ToString();
                    NowHensou.text = StatusManager.Instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.Instance.Hensou;
                }
                else { return; }
                break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if (int.Parse(InputHobbyPIikurume.text) > 0)
                {
                    StatusManager.Instance.Iikurume -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[35] -= 1;
                    InputHobbyPIikurume.text = inputhobbyp[35].ToString();
                    NowIikurume.text = StatusManager.Instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.Instance.Iikurume;
                }
                else { return; }
                break;
            case 301:    //信用
                if (int.Parse(InputHobbyPShinyou.text) > 0)
                {
                    StatusManager.Instance.Shinyou -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[36] -= 1;
                    InputHobbyPShinyou.text = inputhobbyp[36].ToString();
                    NowShinyou.text = StatusManager.Instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.Instance.Shinyou;
                }
                else { return; }
                break;
            case 302:    //説得
                if (int.Parse(InputHobbyPSettoku.text) > 0)
                {
                    StatusManager.Instance.Settoku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[37] -= 1;
                    InputHobbyPSettoku.text = inputhobbyp[37].ToString();
                    NowSettoku.text = StatusManager.Instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.Instance.Settoku;
                }
                else { return; }
                break;
            case 303:    //値切り
                if (int.Parse(InputHobbyPNegiri.text) > 0)
                {
                    StatusManager.Instance.Negiri -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[38] -= 1;
                    InputHobbyPNegiri.text = inputhobbyp[38].ToString();
                    NowNegiri.text = StatusManager.Instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.Instance.Negiri;
                }
                else { return; }
                break;
            case 304:    //母国語
                if (int.Parse(InputHobbyPBokokugo.text) > 0)
                {
                    StatusManager.Instance.Bokokugo -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[39] -= 1;
                    InputHobbyPBokokugo.text = inputhobbyp[39].ToString();
                    NowBokokugo.text = StatusManager.Instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.Instance.Bokokugo;
                }
                else { return; }
                break;

            //知識技能ステータス
            case 400:    //医学
                if (int.Parse(InputHobbyPIgaku.text) > 0)
                {
                    StatusManager.Instance.Igaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[40] -= 1;
                    InputHobbyPIgaku.text = inputhobbyp[40].ToString();
                    NowIgaku.text = StatusManager.Instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.Instance.Igaku;
                }
                else { return; }
                break;
            case 401:    //オカルト
                if (int.Parse(InputHobbyPOkaruto.text) > 0)
                {
                    StatusManager.Instance.Okaruto -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[41] -= 1;
                    InputHobbyPOkaruto.text = inputhobbyp[41].ToString();
                    NowOkaruto.text = StatusManager.Instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.Instance.Okaruto;
                }
                else { return; }
                break;
            case 402:    //化学
                if (int.Parse(InputHobbyPKagaku.text) > 0)
                {
                    StatusManager.Instance.Kagaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[42] -= 1;
                    InputHobbyPKagaku.text = inputhobbyp[42].ToString();
                    NowKagaku.text = StatusManager.Instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.Instance.Kagaku;
                }
                else { return; }
                break;
            case 403:    //クトゥルフ神話
                if (int.Parse(InputHobbyPShinwa.text) > 0)
                {
                    StatusManager.Instance.Shinwa -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[43] -= 1;
                    InputHobbyPShinwa.text = inputhobbyp[43].ToString();
                    NowShinwa.text = StatusManager.Instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.Instance.Shinwa;
                }
                else { return; }
                break;
            case 404:    //芸術
                if (int.Parse(InputHobbyPGezyutsu.text) > 0)
                {
                    StatusManager.Instance.Gezyutsu -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[44] -= 1;
                    InputHobbyPGezyutsu.text = inputhobbyp[44].ToString();
                    NowGezyutsu.text = StatusManager.Instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.Instance.Gezyutsu;
                }
                else { return; }
                break;
            case 405:    //経理
                if (int.Parse(InputHobbyPKeiri.text) > 0)
                {
                    StatusManager.Instance.Keiri -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[45] -= 1;
                    InputHobbyPKeiri.text = inputhobbyp[45].ToString();
                    NowKeiri.text = StatusManager.Instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.Instance.Keiri;
                }
                else { return; }
                break;
            case 406:    //考古学
                if (int.Parse(InputHobbyPKokogaku.text) > 0)
                {
                    StatusManager.Instance.Kokogaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[46] -= 1;
                    InputHobbyPKokogaku.text = inputhobbyp[46].ToString();
                    NowKokogaku.text = StatusManager.Instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.Instance.Kokogaku;
                }
                else { return; }
                break;
            case 407:    //コンピューター
                if (int.Parse(InputHobbyPPC.text) > 0)
                {
                    StatusManager.Instance.PC -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[47] -= 1;
                    InputHobbyPPC.text = inputhobbyp[47].ToString();
                    NowPC.text = StatusManager.Instance.PC.ToString();
                    Afterstatus[47] = StatusManager.Instance.PC;
                }
                else { return; }
                break;
            case 408:    //心理学
                if (int.Parse(InputHobbyPShinrigaku.text) > 0)
                {
                    StatusManager.Instance.Shinrigaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[48] -= 1;
                    InputHobbyPShinrigaku.text = inputhobbyp[48].ToString();
                    NowShinrigaku.text = StatusManager.Instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.Instance.Shinrigaku;
                }
                else { return; }
                break;
            case 409:    //人類学
                if (int.Parse(InputHobbyPZinruigaku.text) > 0)
                {
                    StatusManager.Instance.Zinruigaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[49] -= 1;
                    InputHobbyPZinruigaku.text = inputhobbyp[49].ToString();
                    NowZinruigaku.text = StatusManager.Instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.Instance.Zinruigaku;
                }
                else { return; }
                break;
            case 410:    //生物学
                if (int.Parse(InputHobbyPSeibutsugaku.text) > 0)
                {
                    StatusManager.Instance.Seibutsugaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[50] -= 1;
                    InputHobbyPSeibutsugaku.text = inputhobbyp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.Instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.Instance.Seibutsugaku;
                }
                else { return; }
                break;
            case 411:    //地質学
                if (int.Parse(InputHobbyPTishitsugaku.text) > 0)
                {
                    StatusManager.Instance.Tishitsugaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[51] -= 1;
                    InputHobbyPTishitsugaku.text = inputhobbyp[51].ToString();
                    NowTishitsugaku.text = StatusManager.Instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.Instance.Tishitsugaku;
                }
                else { return; }
                break;
            case 412:    //電子工学
                if (int.Parse(InputHobbyPDenshikougaku.text) > 0)
                {
                    StatusManager.Instance.Denshikougaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[52] -= 1;
                    InputHobbyPDenshikougaku.text = inputhobbyp[52].ToString();
                    NowDenshikougaku.text = StatusManager.Instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.Instance.Denshikougaku;
                }
                else { return; }
                break;
            case 413:    //天文学
                if (int.Parse(InputHobbyPTenmongaku.text) > 0)
                {
                    StatusManager.Instance.Tenmongaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[53] -= 1;
                    InputHobbyPTenmongaku.text = inputhobbyp[53].ToString();
                    NowTenmongaku.text = StatusManager.Instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.Instance.Tenmongaku;
                }
                else { return; }
                break;
            case 414:    //博物学
                if (int.Parse(InputHobbyPHakubutsugaku.text) > 0)
                {
                    StatusManager.Instance.Hakubutsugaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[54] -= 1;
                    InputHobbyPHakubutsugaku.text = inputhobbyp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.Instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.Instance.Hakubutsugaku;
                }
                else { return; }
                break;
            case 415:    //物理学
                if (int.Parse(InputHobbyPButsurigaku.text) > 0)
                {
                    StatusManager.Instance.Butsurigaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[55] -= 1;
                    InputHobbyPButsurigaku.text = inputhobbyp[55].ToString();
                    NowButsurigaku.text = StatusManager.Instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.Instance.Butsurigaku;
                }
                else { return; }
                break;
            case 416:    //法律
                if (int.Parse(InputHobbyPHouritsu.text) > 0)
                {
                    StatusManager.Instance.Houritsu -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[56] -= 1;
                    InputHobbyPHouritsu.text = inputhobbyp[56].ToString();
                    NowHouritsu.text = StatusManager.Instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.Instance.Houritsu;
                }
                else { return; }
                break;
            case 417:    //薬学
                if (int.Parse(InputHobbyPYakugaku.text) > 0)
                {
                    StatusManager.Instance.Yakugaku -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[57] -= 1;
                    InputHobbyPYakugaku.text = inputhobbyp[57].ToString();
                    NowYakugaku.text = StatusManager.Instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.Instance.Yakugaku;
                }
                else { return; }
                break;
            case 418:    //歴史
                if (int.Parse(InputHobbyPRekishi.text) > 0)
                {
                    StatusManager.Instance.Rekishi -= 1;
                    StatusManager.Instance.HobbyP += 1;
                    inputhobbyp[58] -= 1;
                    InputHobbyPRekishi.text = inputhobbyp[58].ToString();
                    NowRekishi.text = StatusManager.Instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.Instance.Rekishi;
                }
                else { return; }
                break;
        }
    }

    //交渉技能ステータスの選択
    public void ChoiceTalkSkill(int SkillNo)
    {
        switch (SkillNo)
        {
            case 300:
                if (inputworkp[35] != 0)
                {
                    workShinyo.SetActive(false);
                    workSettoku.SetActive(false);
                    workNegiri.SetActive(false);
                    workBokokugo.SetActive(false);
                }
                else
                {
                    workShinyo.SetActive(true);
                    workSettoku.SetActive(true);
                    workNegiri.SetActive(true);
                    workBokokugo.SetActive(true);
                }
                break;
            case 301:
                if (inputworkp[36] != 0)
                {
                    workIikurume.SetActive(false);
                    workSettoku.SetActive(false);
                    workNegiri.SetActive(false);
                    workBokokugo.SetActive(false);
                }
                else
                {
                    workIikurume.SetActive(true);
                    workSettoku.SetActive(true);
                    workNegiri.SetActive(true);
                    workBokokugo.SetActive(true);
                }
                break;
            case 302:
                if (inputworkp[37] != 0)
                {
                    workIikurume.SetActive(false);
                    workShinyo.SetActive(false);
                    workNegiri.SetActive(false);
                    workBokokugo.SetActive(false);
                }
                else
                {
                    workIikurume.SetActive(true);
                    workShinyo.SetActive(true);
                    workNegiri.SetActive(true);
                    workBokokugo.SetActive(true);
                }
                break;
            case 303:
                if (inputworkp[38] != 0)
                {
                    workIikurume.SetActive(false);
                    workShinyo.SetActive(false);
                    workSettoku.SetActive(false);
                    workBokokugo.SetActive(false);
                }
                else
                {
                    workIikurume.SetActive(true);
                    workShinyo.SetActive(true);
                    workSettoku.SetActive(true);
                    workBokokugo.SetActive(true);
                }
                break;
            case 304:
                if (inputworkp[39] != 0)
                {
                    workIikurume.SetActive(false);
                    workShinyo.SetActive(false);
                    workSettoku.SetActive(false);
                    workNegiri.SetActive(false);
                }
                else
                {
                    workIikurume.SetActive(true);
                    workShinyo.SetActive(true);
                    workSettoku.SetActive(true);
                    workNegiri.SetActive(true);
                }
                break;
        }
    }

    //ボディーガードの取得スキル(聞き耳か目星)
    public void SPChoiceSkill(int SkillNo)
    {
        if (StatusManager.Instance.ChoiceProfession == 0)
        {
            switch (SkillNo)
            {
                case 0:
                    if (inputworkp[16] != 0)
                    {
                        workMeboshi.SetActive(false);
                        workKikimimi.SetActive(true);
                    }
                    else { workMeboshi.SetActive(true); }
                    break;
                case 1:
                    if (inputworkp[23] != 0)
                    {
                        workMeboshi.SetActive(true);
                        workKikimimi.SetActive(false);
                    }
                    else { workKikimimi.SetActive(true); }
                    break;
            }
        }
        else { return; }
    }

    //シーン移行
    public void NextScenechecker(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:
                if (StatusManager.Instance.ChoiceProfession != 3)
                {
                    if ((StatusManager.Instance.WorkP != 0) && (StatusManager.Instance.HobbyP != 0))
                    { DecisionPanel.SetActive(true); }
                    else { SkillCheckerPanel.SetActive(true); }
                }
                else
                {
                    if (StatusManager.Instance.HobbyP != 0)
                    { DecisionPanel.SetActive(true); }
                    else { SkillCheckerPanel.SetActive(true); }
                }
                break;
            case 1:
                TakeSkill();
                FadeManager.Instance.LoadScene("test", 1.0f);
                break;
            case 2:
                DecisionPanel.SetActive(false);
                break;
            case 3:
                SkillCheckerPanel.SetActive(false);
                break;
        }
    }

    //取得した技能をDictionaryに保存
    public void TakeSkill()
    {
        for (int i = 0; i < 58; i++)
        {
            StatusManager.Instance.SkillParameter.Add(SkillNames[i], status[i] + Afterstatus[i]);
        }
    }
}
