using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
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
    string[] SkillName = { "Kaihi","Kikku","Kumitsuki","Kobushi","Zutsuki","Toteki","MSA","Kenzyu","SMG","SG","MG","R",
                           "Okyuteate","Kagiake","Kakusu","Kakureru","Kikimimi","Shinobiaruki","Syashinzyutsu","Seshinbunseki","Tsuiseki","Touhan","Tosyokan","Meboshi",
                           "Unten","Kikaisyuri","Zyukikaisosa","Zyoba","Suiei","Sesaku","Sozyu","Tyoyaku","Denkisyuri","Nabige-to","Hensou",
                           "Iikurume","Shinyou","Settoku","Negiri","Bokokugo",
                           "Igaku","Okaruto","Shinwa","Gezyutsu","Keiri","Kokogaku","PC","Shinrigaku","Zinruigaku","Seibutsugaku","Tishitsugaku","Denshikougaku","Tenmongaku","Hakubutsugaku","Butsurigaku","Houritsu","Yakugaku","Rekishi"};
    

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

    private void Start()
    {
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
    int Dice(int a,int b)   //Dice(ダイスの数,ダイスのプラス値)
    {
        int x = Random.Range(1, 6);
        x = x * a + b;
        return x;
    }
    //ステータス決め
    public async void Status()
    {
        DiceButton.SetActive(false);
        StatusManager.instance.STR = Dice(3, 0);
        StatusManager.instance.CON = Dice(3, 0);
        StatusManager.instance.POW = Dice(3, 0);
        StatusManager.instance.DEX = Dice(3, 0);
        StatusManager.instance.APP = Dice(3, 0);
        StatusManager.instance.SIZ = Dice(2, 6);
        StatusManager.instance.INT = Dice(2, 6);
        StatusManager.instance.EDU = Dice(3, 3);
        StatusManager.instance.StatusPoints();
        STR.text = StatusManager.instance.STR.ToString();
        await Task.Delay(delay);
        CON.text = StatusManager.instance.CON.ToString();
        await Task.Delay(delay);
        POW.text = StatusManager.instance.POW.ToString();
        await Task.Delay(delay);
        DEX.text = StatusManager.instance.DEX.ToString();
        await Task.Delay(delay);
        APP.text = StatusManager.instance.APP.ToString();
        await Task.Delay(delay);
        SIZ.text = StatusManager.instance.SIZ.ToString();
        await Task.Delay(delay);
        INT.text = StatusManager.instance.INT.ToString();
        await Task.Delay(delay);
        EDU.text = StatusManager.instance.EDU.ToString();
        await Task.Delay(delay);
        SAN.text = StatusManager.instance.SAN.ToString();
        await Task.Delay(delay);
        Luck.text = StatusManager.instance.Luck.ToString();
        await Task.Delay(delay);
        Idea.text = StatusManager.instance.Idea.ToString();
        await Task.Delay(delay);
        Memory.text = StatusManager.instance.Memory.ToString();
        await Task.Delay(delay);
        Durability.text = StatusManager.instance.Durability.ToString();
        await Task.Delay(delay);
        MgcP.text = StatusManager.instance.MgcP.ToString();
        await Task.Delay(delay);
        StatusManager.instance.DecisionworkP = true;
        await Task.Delay(delay);
        StatusManager.instance.DecisionhobbyP = true;
        await Task.Delay(delay);
        if ((2 <= StatusManager.instance.DamagePCheck) && (StatusManager.instance.DamagePCheck <= 12))
        {
            DamegeP.text = "-1D6";
            StatusManager.instance.DamageP = -6;
        }else if ((13 <= StatusManager.instance.DamagePCheck) && (StatusManager.instance.DamagePCheck <= 16))
        {
            DamegeP.text = "-1D4";
            StatusManager.instance.DamageP = -4;
        }
        else if ((17 <= StatusManager.instance.DamagePCheck) && (StatusManager.instance.DamagePCheck <= 24))
        {
            DamegeP.text = "0";
            StatusManager.instance.DamageP = -0;
        }
        else if ((25 <= StatusManager.instance.DamagePCheck) && (StatusManager.instance.DamagePCheck <= 32))
        {
            DamegeP.text = "+1D4";
            StatusManager.instance.DamageP = 4;
        }
        else if ((33 <= StatusManager.instance.DamagePCheck) && (StatusManager.instance.DamagePCheck <= 40))
        {
            DamegeP.text = "+1D6";
            StatusManager.instance.DamageP = 6;
        }

        //戦闘技能ステータス
        NowKaihi.text = StatusManager.instance.Kaihi.ToString();
        status[0] = StatusManager.instance.Kaihi;
        NowKikku.text = StatusManager.instance.Kikku.ToString();
        status[1] = StatusManager.instance.Kikku;
        NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
        status[2] = StatusManager.instance.Kikimimi;
        NowKobushi.text = StatusManager.instance.Kobushi.ToString();
        status[3] = StatusManager.instance.Kobushi;
        NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
        status[4] = StatusManager.instance.Zutsuki;
        NowToteki.text = StatusManager.instance.Toteki.ToString();
        status[5] = StatusManager.instance.Toteki;
        NowMSA.text = StatusManager.instance.MSA.ToString();
        status[6] = StatusManager.instance.MSA;
        NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
        status[7] = StatusManager.instance.Kenzyu;
        NowSMG.text = StatusManager.instance.SMG.ToString();
        status[8] = StatusManager.instance.SMG;
        NowSG.text = StatusManager.instance.SG.ToString();
        status[9] = StatusManager.instance.SG;
        NowMG.text = StatusManager.instance.MG.ToString();
        status[10] = StatusManager.instance.MG;
        NowR.text = StatusManager.instance.R.ToString();
        status[11] = StatusManager.instance.R;

        //探索技能ステータス
        NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
        status[12] = StatusManager.instance.Okyuteate;
        NowKagiake.text = StatusManager.instance.Kagiake.ToString();
        status[13] = StatusManager.instance.Kagiake;
        NowKakusu.text = StatusManager.instance.Kakusu.ToString();
        status[14] = StatusManager.instance.Kakusu;
        NowKakureru.text = StatusManager.instance.Kakureru.ToString();
        status[15] = StatusManager.instance.Kakureru;
        NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
        status[16] = StatusManager.instance.Kikimimi;
        NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
        status[17] = StatusManager.instance.Shinobiaruki;
        NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
        status[18] = StatusManager.instance.Syashinzyutsu;
        NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
        status[19] = StatusManager.instance.Seshinbunseki;
        NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
        status[20] = StatusManager.instance.Tsuiseki;
        NowTouhan.text = StatusManager.instance.Touhan.ToString();
        status[21] = StatusManager.instance.Touhan;
        NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
        status[22] = StatusManager.instance.Tosyokan;
        NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
        status[23] = StatusManager.instance.Meboshi;

        //行動技能ステータス
        NowUnten.text = StatusManager.instance.Unten.ToString();
        status[24] = StatusManager.instance.Unten;
        NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
        status[25] = StatusManager.instance.Kikaisyuri;
        NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
        status[26] = StatusManager.instance.Zyukikaisosa;
        NowZyoba.text = StatusManager.instance.Zyoba.ToString();
        status[27] = StatusManager.instance.Zyoba;
        NowSuiei.text = StatusManager.instance.Suiei.ToString();
        status[28] = StatusManager.instance.Suiei;
        NowSesaku.text = StatusManager.instance.Sesaku.ToString();
        status[29] = StatusManager.instance.Sesaku;
        NowSozyu.text = StatusManager.instance.Sozyu.ToString();
        status[30] = StatusManager.instance.Sozyu;
        NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
        status[31] = StatusManager.instance.Tyoyaku;
        NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
        status[32] = StatusManager.instance.Denkisyuri;
        NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
        status[33] = StatusManager.instance.Nabigeto;
        NowHensou.text = StatusManager.instance.Hensou.ToString();
        status[34] = StatusManager.instance.Hensou;

        //交渉技能ステータス
        NowIikurume.text = StatusManager.instance.Iikurume.ToString();
        status[35] = StatusManager.instance.Iikurume;
        NowShinyou.text = StatusManager.instance.Shinyou.ToString();
        status[36] = StatusManager.instance.Shinyou;
        NowSettoku.text = StatusManager.instance.Settoku.ToString();
        status[37] = StatusManager.instance.Settoku;
        NowNegiri.text = StatusManager.instance.Negiri.ToString();
        status[38] = StatusManager.instance.Negiri;
        NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
        status[39] = StatusManager.instance.Bokokugo;

        //知識技能ステータス
        NowIgaku.text = StatusManager.instance.Igaku.ToString();
        status[40] = StatusManager.instance.Igaku;
        NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
        status[41] = StatusManager.instance.Okaruto;
        NowKagaku.text = StatusManager.instance.Kagaku.ToString();
        status[42] = StatusManager.instance.Kagaku;
        NowShinwa.text = StatusManager.instance.Shinwa.ToString();
        status[43] = StatusManager.instance.Shinwa;
        NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
        status[44] = StatusManager.instance.Gezyutsu;
        NowKeiri.text = StatusManager.instance.Keiri.ToString();
        status[45] = StatusManager.instance.Keiri;
        NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
        status[46] = StatusManager.instance.Kokogaku;
        NowPC.text = StatusManager.instance.PC.ToString();
        status[47] = StatusManager.instance.PC;
        NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
        status[48] = StatusManager.instance.Shinrigaku;
        NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
        status[49] = StatusManager.instance.Zinruigaku;
        NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
        status[50] = StatusManager.instance.Seibutsugaku;
        NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
        status[51] = StatusManager.instance.Tishitsugaku;
        NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
        status[52] = StatusManager.instance.Denshikougaku;
        NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
        status[53] = StatusManager.instance.Tenmongaku;
        NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
        status[54] = StatusManager.instance.Hakubutsugaku;
        NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
        status[55] = StatusManager.instance.Butsurigaku;
        NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
        status[56] = StatusManager.instance.Houritsu;
        NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
        status[57] = StatusManager.instance.Yakugaku;
        NowRekishi.text = StatusManager.instance.Rekishi.ToString();
        status[58] = StatusManager.instance.Rekishi;

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
                StatusManager.instance.ChoiceProfession = 0;
                break;
            case 1:
                StatusManager.instance.ChoiceProfession = 1;
                break;
            case 2:
                StatusManager.instance.ChoiceProfession = 2;
                break;
            case 3:
                StatusManager.instance.ChoiceProfession = 3;
                break;
        }
        WorkChoiceStatus();
        ProfessionPanel.SetActive(false);
        BattlePanel.SetActive(true);
    }

    //職業による習得できるスキル
    public void WorkChoiceStatus()
    {
        switch (StatusManager.instance.ChoiceProfession)
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
        }else if ((choicePanel == 1) && (!NRButton))
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
                if (StatusManager.instance.WorkP < kaihi)
                {
                    kaihi = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kaihi += kaihi;
                    InputWorkPKaihi.text = kaihi.ToString();
                }
                else { StatusManager.instance.WorkP -= kaihi;
                       StatusManager.instance.Kaihi -= inputworkp[0];
                       StatusManager.instance.Kaihi += kaihi;
                       StatusManager.instance.WorkP += inputworkp[0];
                }
                NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                inputworkp[0] = kaihi;
                Afterstatus[0] = StatusManager.instance.Kaihi;
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
                if (StatusManager.instance.WorkP < kikku)
                {
                    kikku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kikku += kikku;
                    InputWorkPKikku.text = kikku.ToString();
                }
                else { StatusManager.instance.WorkP -= kikku;
                       StatusManager.instance.Kikku -= inputworkp[1];
                       StatusManager.instance.Kikku += kikku;
                       StatusManager.instance.WorkP += inputworkp[1];
                }
                NowKikku.text = StatusManager.instance.Kikku.ToString();
                inputworkp[1] = kikku;
                Afterstatus[1] = StatusManager.instance.Kikku;
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
                if (StatusManager.instance.WorkP < kumitsuki)
                {
                    kumitsuki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kumitsuki += kumitsuki;
                    InputWorkPKumitsuki.text = kumitsuki.ToString();
                }
                else { StatusManager.instance.WorkP -= kumitsuki;
                       StatusManager.instance.Kumitsuki -= inputworkp[2];
                       StatusManager.instance.Kumitsuki += kumitsuki;
                       StatusManager.instance.WorkP += inputworkp[2];
                }
                NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                inputworkp[2] = kumitsuki;
                Afterstatus[2] = StatusManager.instance.Kumitsuki;
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
                if (StatusManager.instance.WorkP < kobushi)
                {
                    kobushi = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kobushi += kobushi;
                    InputWorkPKobushi.text = kobushi.ToString();
                }
                else { StatusManager.instance.WorkP -= kobushi;
                       StatusManager.instance.Kobushi -= inputworkp[3];
                       StatusManager.instance.Kobushi += kobushi;
                       StatusManager.instance.WorkP += inputworkp[3];
                }
                NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                inputworkp[3] = kobushi;
                Afterstatus[3] = StatusManager.instance.Kobushi;
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
                if (StatusManager.instance.WorkP < zutsuki)
                {
                    zutsuki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Zutsuki += zutsuki;
                    InputWorkPZutsuki.text = zutsuki.ToString();
                }
                else { StatusManager.instance.WorkP -= zutsuki;
                       StatusManager.instance.Zutsuki -= inputworkp[4];
                       StatusManager.instance.Zutsuki += zutsuki;
                       StatusManager.instance.WorkP += inputworkp[4];
                }
                NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                inputworkp[4] = zutsuki;
                Afterstatus[4] = StatusManager.instance.Zutsuki;
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
                if (StatusManager.instance.WorkP < toteki)
                {
                    toteki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Toteki += toteki;
                    InputWorkPToteki.text = toteki.ToString();
                }
                else { StatusManager.instance.WorkP -= toteki;
                       StatusManager.instance.Toteki -= inputworkp[5];
                       StatusManager.instance.Toteki += toteki;
                       StatusManager.instance.WorkP += inputworkp[5];
                }
                NowToteki.text = StatusManager.instance.Toteki.ToString();
                inputworkp[5] = toteki;
                Afterstatus[5] = StatusManager.instance.Toteki;
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
                if (StatusManager.instance.WorkP < msa)
                {
                    msa = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.MSA += msa;
                    InputWorkPMSA.text = msa.ToString();
                }
                else { StatusManager.instance.WorkP -= msa;
                       StatusManager.instance.MSA -= inputworkp[6];
                       StatusManager.instance.MSA += msa;
                       StatusManager.instance.WorkP += inputworkp[6];
                }
                NowMSA.text = StatusManager.instance.MSA.ToString();
                inputworkp[6] = msa;
                Afterstatus[6] = StatusManager.instance.MSA;
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
                if (StatusManager.instance.WorkP < kenzyu)
                {
                    kenzyu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kenzyu += kenzyu;
                    InputWorkPKenzyu.text = kenzyu.ToString();
                }
                else { StatusManager.instance.WorkP -= kenzyu;
                       StatusManager.instance.Kenzyu -= inputworkp[7];
                       StatusManager.instance.Kenzyu += kenzyu;
                       StatusManager.instance.WorkP += inputworkp[7];
                }
                NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                inputworkp[7] = kenzyu;
                Afterstatus[7] = StatusManager.instance.Kenzyu;
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
                if (StatusManager.instance.WorkP < smg)
                {
                    smg = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.SMG += smg;
                    InputWorkPSMG.text = smg.ToString();
                }
                else { StatusManager.instance.WorkP -= smg;
                       StatusManager.instance.SMG -= inputworkp[8];
                       StatusManager.instance.SMG += smg;
                       StatusManager.instance.WorkP += inputworkp[8];
                }
                NowSMG.text = StatusManager.instance.SMG.ToString();
                inputworkp[8] = smg;
                Afterstatus[8] = StatusManager.instance.SMG;
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
                if (StatusManager.instance.WorkP < sg)
                {
                    sg = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.SG += sg;
                    InputWorkPSG.text = sg.ToString();
                }
                else { StatusManager.instance.WorkP -= sg;
                       StatusManager.instance.SG -= inputworkp[9];
                       StatusManager.instance.SG += sg;
                       StatusManager.instance.WorkP += inputworkp[9];
                }
                NowSG.text = StatusManager.instance.SG.ToString();
                inputworkp[9] = sg;
                Afterstatus[9] = StatusManager.instance.SG;
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
                if (StatusManager.instance.WorkP < mg)
                {
                    mg = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.MG += mg;
                    InputWorkPMG.text = mg.ToString();
                }
                else { StatusManager.instance.WorkP -= mg;
                       StatusManager.instance.MG -= inputworkp[10];
                       StatusManager.instance.MG += mg;
                       StatusManager.instance.WorkP += inputworkp[10];
                }
                NowMG.text = StatusManager.instance.MG.ToString();
                inputworkp[10] = mg;
                Afterstatus[10] = StatusManager.instance.MG;
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
                if (StatusManager.instance.WorkP < r)
                {
                    r = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.R += r;
                    InputWorkPR.text = r.ToString();
                }
                else { StatusManager.instance.WorkP -= r;
                       StatusManager.instance.R -= inputworkp[11];
                       StatusManager.instance.R += r;
                       StatusManager.instance.WorkP += inputworkp[11];
                }
                NowR.text = StatusManager.instance.R.ToString();
                inputworkp[11] = r;
                Afterstatus[11] = StatusManager.instance.R;
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
                if (StatusManager.instance.WorkP < okyuteate)
                {
                    okyuteate = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Okyuteate += okyuteate;
                    InputWorkPOkyuteate.text = okyuteate.ToString();
                }
                else { StatusManager.instance.WorkP -= okyuteate;
                       StatusManager.instance.Okyuteate -= inputworkp[12];
                       StatusManager.instance.Okyuteate += okyuteate;
                       StatusManager.instance.WorkP += inputworkp[12];
                }
                NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                inputworkp[12] = okyuteate;
                Afterstatus[12] = StatusManager.instance.Okyuteate;
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
                if (StatusManager.instance.WorkP < kagiake)
                {
                    kagiake = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kagiake += kagiake;
                    InputWorkPKagiake.text = kagiake.ToString();
                }
                else { StatusManager.instance.WorkP -= kagiake;
                       StatusManager.instance.Kagiake -= inputworkp[13];
                       StatusManager.instance.Kagiake += kagiake;
                       StatusManager.instance.WorkP += inputworkp[13];
                }
                NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                inputworkp[13] = kagiake;
                Afterstatus[13] = StatusManager.instance.Kagiake;
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
                if (StatusManager.instance.WorkP < kakusu)
                {
                    kakusu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kakusu += kakusu;
                    InputWorkPKakusu.text = kakusu.ToString();
                }
                else { StatusManager.instance.WorkP -= kakusu;
                       StatusManager.instance.Kakusu -= inputworkp[14];
                       StatusManager.instance.Kakusu += kakusu;
                       StatusManager.instance.WorkP += inputworkp[14];
                }
                NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                inputworkp[14] = kakusu;
                Afterstatus[14] = StatusManager.instance.Kakusu;
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
                if (StatusManager.instance.WorkP < kakureru)
                {
                    kakureru = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kakureru += kakureru;
                    InputWorkPKakureru.text = kakureru.ToString();
                }
                else { StatusManager.instance.WorkP -= kakureru;
                       StatusManager.instance.Kakureru -= inputworkp[15];
                       StatusManager.instance.Kakureru += kakureru;
                       StatusManager.instance.WorkP += inputworkp[15];
                }
                NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                inputworkp[15] = kakureru;
                Afterstatus[15] = StatusManager.instance.Kakureru;
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
                if (StatusManager.instance.WorkP < kikimimi)
                {
                    kikimimi = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kikimimi += kikimimi;
                    InputWorkPKikimimi.text = kikimimi.ToString();
                }
                else { StatusManager.instance.WorkP -= kikimimi;
                       StatusManager.instance.Kikimimi -= inputworkp[16];
                       StatusManager.instance.Kikimimi += kikimimi;
                       StatusManager.instance.WorkP += inputworkp[16];
                }
                NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                inputworkp[16] = kikimimi;
                Afterstatus[16] = StatusManager.instance.Kikimimi;
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
                if (StatusManager.instance.WorkP < shinobiaruki)
                {
                    shinobiaruki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Shinobiaruki += shinobiaruki;
                    InputWorkPShinobiaruki.text = shinobiaruki.ToString();
                }
                else { StatusManager.instance.WorkP -= shinobiaruki;
                       StatusManager.instance.Shinobiaruki -= inputworkp[17];
                       StatusManager.instance.Shinobiaruki += shinobiaruki;
                       StatusManager.instance.WorkP += inputworkp[17];
                }
                NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                inputworkp[17] = shinobiaruki;
                Afterstatus[17] = StatusManager.instance.Shinobiaruki;
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
                if (StatusManager.instance.WorkP < syashinzyutsu)
                {
                    syashinzyutsu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Syashinzyutsu += syashinzyutsu;
                    InputWorkPSyashinzyutsu.text = syashinzyutsu.ToString();
                }
                else { StatusManager.instance.WorkP -= syashinzyutsu;
                       StatusManager.instance.Syashinzyutsu -= inputworkp[18];
                       StatusManager.instance.Syashinzyutsu += syashinzyutsu;
                       StatusManager.instance.WorkP += inputworkp[18];
                }
                NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                inputworkp[18] = syashinzyutsu;
                Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
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
                if (StatusManager.instance.WorkP < seshinbunseki)
                {
                    seshinbunseki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Seshinbunseki += seshinbunseki;
                    InputWorkPSeshinbunseki.text = seshinbunseki.ToString();
                }
                else { StatusManager.instance.WorkP -= seshinbunseki;
                       StatusManager.instance.Seshinbunseki -= inputworkp[19];
                       StatusManager.instance.Seshinbunseki += seshinbunseki;
                       StatusManager.instance.WorkP += inputworkp[19];
                }
                NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                inputworkp[19] = seshinbunseki;
                Afterstatus[19] = StatusManager.instance.Seshinbunseki;
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
                if (StatusManager.instance.WorkP < tsuiseki)
                {
                    tsuiseki = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Tsuiseki += tsuiseki;
                    InputWorkPTsuiseki.text = tsuiseki.ToString();
                }
                else { StatusManager.instance.WorkP -= tsuiseki;
                       StatusManager.instance.Tsuiseki -= inputworkp[20];
                       StatusManager.instance.Tsuiseki += tsuiseki;
                       StatusManager.instance.WorkP += inputworkp[20];
                }
                NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                inputworkp[20] = tsuiseki;
                Afterstatus[20] = StatusManager.instance.Tsuiseki;
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
                if (StatusManager.instance.WorkP < touhan)
                {
                    touhan = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Touhan += touhan;
                    InputWorkPTouhan.text = touhan.ToString();
                }
                else { StatusManager.instance.WorkP -= touhan;
                       StatusManager.instance.Touhan -= inputworkp[21];
                       StatusManager.instance.Touhan += touhan;
                       StatusManager.instance.WorkP += inputworkp[21];
                }
                NowTouhan.text = StatusManager.instance.Touhan.ToString();
                inputworkp[21] = touhan;
                Afterstatus[21] = StatusManager.instance.Touhan;
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
                if (StatusManager.instance.WorkP < tosyokan)
                {
                    tosyokan = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Tosyokan += tosyokan;
                    InputWorkPTosyokan.text = tosyokan.ToString();
                }
                else { StatusManager.instance.WorkP -= tosyokan;
                       StatusManager.instance.Tosyokan -= inputworkp[22];
                       StatusManager.instance.Tosyokan += tosyokan;
                       StatusManager.instance.WorkP += inputworkp[22];
                }
                NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                inputworkp[22] = tosyokan;
                Afterstatus[22] = StatusManager.instance.Tosyokan;
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
                if (StatusManager.instance.WorkP < meboshi)
                {
                    meboshi = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Meboshi += meboshi;
                    InputWorkPMeboshi.text = meboshi.ToString();
                }
                else { StatusManager.instance.WorkP -= meboshi;
                       StatusManager.instance.Meboshi -= inputworkp[23];
                       StatusManager.instance.Meboshi += meboshi;
                       StatusManager.instance.WorkP += inputworkp[23];
                }
                NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                inputworkp[23] = meboshi;
                Afterstatus[23] = StatusManager.instance.Meboshi;
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
                if (StatusManager.instance.WorkP < unten)
                {
                    unten = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Unten += unten;
                    InputWorkPUnten.text = unten.ToString();
                }
                else { StatusManager.instance.WorkP -= unten;
                       StatusManager.instance.Unten -= inputworkp[24];
                       StatusManager.instance.Unten += unten;
                       StatusManager.instance.WorkP += inputworkp[24];
                }
                NowUnten.text = StatusManager.instance.Unten.ToString();
                inputworkp[24] = unten;
                Afterstatus[24] = StatusManager.instance.Unten;
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
                if (StatusManager.instance.WorkP < kikaisyuri)
                {
                    kikaisyuri = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kikaisyuri += kikaisyuri;
                    InputWorkPKikaisyuri.text = kikaisyuri.ToString();
                }
                else { StatusManager.instance.WorkP -= kikaisyuri;
                       StatusManager.instance.Kikaisyuri -= inputworkp[25];
                       StatusManager.instance.Kikaisyuri += kikaisyuri;
                       StatusManager.instance.WorkP += inputworkp[25];
                }
                NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                inputworkp[25] = kikaisyuri;
                Afterstatus[25] = StatusManager.instance.Kikaisyuri;
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
                if (StatusManager.instance.WorkP < zyukikaisosa)
                {
                    zyukikaisosa = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Zyukikaisosa += zyukikaisosa;
                    InputWorkPZyukikaisosa.text = zyukikaisosa.ToString();
                }
                else { StatusManager.instance.WorkP -= zyukikaisosa;
                       StatusManager.instance.Zyukikaisosa -= inputworkp[26];
                       StatusManager.instance.Zyukikaisosa += zyukikaisosa;
                       StatusManager.instance.WorkP += inputworkp[26];
                }
                NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                inputworkp[26] = zyukikaisosa;
                Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
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
                if (StatusManager.instance.WorkP < zyoba)
                {
                    zyoba = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Zyoba += zyoba;
                    InputWorkPZyoba.text = zyoba.ToString();
                }
                else { StatusManager.instance.WorkP -= zyoba;
                       StatusManager.instance.Zyoba = inputworkp[27];
                       StatusManager.instance.Zyoba += zyoba;
                       StatusManager.instance.WorkP += inputworkp[27];
                }
                NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                inputworkp[27] = zyoba;
                Afterstatus[27] = StatusManager.instance.Zyoba;
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
                if (StatusManager.instance.WorkP < suiei)
                {
                    suiei = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Suiei += suiei;
                    InputWorkPSuiei.text = suiei.ToString();
                }
                else { StatusManager.instance.WorkP -= suiei;
                       StatusManager.instance.Suiei -= inputworkp[28];
                       StatusManager.instance.Suiei += suiei;
                       StatusManager.instance.WorkP += inputworkp[28];
                }
                NowSuiei.text = StatusManager.instance.Suiei.ToString();
                inputworkp[28] = suiei;
                Afterstatus[28] = StatusManager.instance.Suiei;
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
                if (StatusManager.instance.WorkP < sesaku)
                {
                    sesaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Sesaku += sesaku;
                    InputWorkPSesaku.text = sesaku.ToString();
                }
                else { StatusManager.instance.WorkP -= sesaku;
                       StatusManager.instance.Sesaku -= inputworkp[29];
                       StatusManager.instance.Sesaku += sesaku;
                       StatusManager.instance.WorkP += inputworkp[29];
                }
                NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                inputworkp[29] = sesaku;
                Afterstatus[29] = StatusManager.instance.Sesaku;
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
                if (StatusManager.instance.WorkP < sozyu)
                {
                    sozyu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Sozyu += sozyu;
                    InputWorkPSozyu.text = sozyu.ToString();
                }
                else { StatusManager.instance.WorkP -= sozyu;
                       StatusManager.instance.Sozyu -= inputworkp[30];
                       StatusManager.instance.Sozyu += sozyu;
                       StatusManager.instance.WorkP += inputworkp[30];
                }
                NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                inputworkp[30] = sozyu;
                Afterstatus[30] = StatusManager.instance.Sozyu;
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
                if (StatusManager.instance.WorkP < tyoyaku)
                {
                    tyoyaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Tyoyaku += tyoyaku;
                    InputWorkPTyoyaku.text = tyoyaku.ToString();
                }
                else { StatusManager.instance.WorkP -= tyoyaku;
                       StatusManager.instance.Tyoyaku -= inputworkp[31];
                       StatusManager.instance.Tyoyaku += tyoyaku;
                       StatusManager.instance.WorkP += inputworkp[31];
                }
                NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                inputworkp[31] = tyoyaku;
                Afterstatus[31] = StatusManager.instance.Tyoyaku;
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
                if (StatusManager.instance.WorkP < denkisyuri)
                {
                    denkisyuri = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Denkisyuri += denkisyuri;
                    InputWorkPDenkisyuri.text = denkisyuri.ToString();
                }
                else { StatusManager.instance.WorkP -= denkisyuri;
                       StatusManager.instance.Denkisyuri -= inputworkp[32];
                       StatusManager.instance.Denkisyuri += denkisyuri;
                       StatusManager.instance.WorkP += inputworkp[32];
                }
                NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                inputworkp[32] = denkisyuri;
                Afterstatus[32] = StatusManager.instance.Denkisyuri;
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
                if (StatusManager.instance.WorkP < nabigeto)
                {
                    nabigeto = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Nabigeto += nabigeto;
                    InputWorkPNabigeto.text = nabigeto.ToString();
                }
                else { StatusManager.instance.WorkP -= nabigeto;
                       StatusManager.instance.Nabigeto -= inputworkp[33];
                       StatusManager.instance.Nabigeto += nabigeto;
                       StatusManager.instance.WorkP += inputworkp[33];
                }
                NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                inputworkp[33] = nabigeto;
                Afterstatus[33] = StatusManager.instance.Nabigeto;
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
                if (StatusManager.instance.WorkP < hensou)
                {
                    hensou = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Hensou += hensou;
                    InputWorkPHensou.text = hensou.ToString();
                }
                else { StatusManager.instance.WorkP -= hensou;
                       StatusManager.instance.Hensou -= inputworkp[34];
                       StatusManager.instance.Hensou += hensou;
                       StatusManager.instance.WorkP += inputworkp[34];
                }
                NowHensou.text = StatusManager.instance.Hensou.ToString();
                inputworkp[34] = hensou;
                Afterstatus[34] = StatusManager.instance.Hensou;
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
                if (StatusManager.instance.WorkP < iikurume)
                {
                    iikurume = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Iikurume += iikurume;
                    InputWorkPIikurume.text = iikurume.ToString();
                }
                else { StatusManager.instance.WorkP -= iikurume;
                       StatusManager.instance.Iikurume -= inputworkp[35];
                       StatusManager.instance.Iikurume += iikurume;
                       StatusManager.instance.WorkP += inputworkp[35];
                }
                NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                inputworkp[35] = iikurume;
                Afterstatus[35] = StatusManager.instance.Iikurume;
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
                if (StatusManager.instance.WorkP < shinyou)
                {
                    shinyou = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Shinyou += shinyou;
                    InputWorkPShinyou.text = shinyou.ToString();
                }
                else { StatusManager.instance.WorkP -= shinyou;
                       StatusManager.instance.Shinyou -= inputworkp[36];
                       StatusManager.instance.Shinyou += shinyou;
                       StatusManager.instance.WorkP += inputworkp[36];
                }
                NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                inputworkp[36] = shinyou;
                Afterstatus[36] = StatusManager.instance.Shinyou;
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
                if (StatusManager.instance.WorkP < settoku)
                {
                    settoku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Settoku += settoku;
                    InputWorkPSettoku.text = settoku.ToString();
                }
                else { StatusManager.instance.WorkP -= settoku;
                       StatusManager.instance.Settoku -= inputworkp[37];
                       StatusManager.instance.Settoku += settoku;
                       StatusManager.instance.WorkP += inputworkp[37];
                }
                NowSettoku.text = StatusManager.instance.Settoku.ToString();
                inputworkp[37] = settoku;
                Afterstatus[37] = StatusManager.instance.Settoku;
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
                if (StatusManager.instance.WorkP < negiri)
                {
                    negiri = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Negiri += negiri;
                    InputWorkPNegiri.text = negiri.ToString();
                }
                else { StatusManager.instance.WorkP -= negiri;
                       StatusManager.instance.Negiri -= inputworkp[38];
                       StatusManager.instance.Negiri += negiri;
                       StatusManager.instance.WorkP += inputworkp[38];
                }
                NowNegiri.text = StatusManager.instance.Negiri.ToString();
                inputworkp[38] = negiri;
                Afterstatus[38] = StatusManager.instance.Negiri;
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
                if (StatusManager.instance.WorkP < bokokugo)
                {
                    bokokugo = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Bokokugo += bokokugo;
                    InputWorkPBokokugo.text = bokokugo.ToString();
                }
                else { StatusManager.instance.WorkP -= bokokugo;
                       StatusManager.instance.Bokokugo -= inputworkp[39];
                       StatusManager.instance.Bokokugo += bokokugo;
                       StatusManager.instance.WorkP += inputworkp[39];
                }
                NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                inputworkp[39] = bokokugo;
                Afterstatus[39] = StatusManager.instance.Bokokugo;
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
                if (StatusManager.instance.WorkP < igaku)
                {
                    igaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Igaku += igaku;
                    InputWorkPIgaku.text = igaku.ToString();
                }
                else { StatusManager.instance.WorkP -= igaku;
                       StatusManager.instance.Igaku -= inputworkp[40];
                       StatusManager.instance.Igaku += igaku;
                       StatusManager.instance.WorkP += inputworkp[40];
                }
                NowIgaku.text = StatusManager.instance.Igaku.ToString();
                inputworkp[40] = igaku;
                Afterstatus[40] = StatusManager.instance.Igaku;
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
                if (StatusManager.instance.WorkP < okaruto)
                {
                    okaruto = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Okaruto += okaruto;
                    InputWorkPOkaruto.text = okaruto.ToString();
                }
                else { StatusManager.instance.WorkP -= okaruto;
                       StatusManager.instance.Okaruto -= inputworkp[41];
                       StatusManager.instance.Okaruto += okaruto;
                       StatusManager.instance.WorkP += inputworkp[41];
                }
                NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                inputworkp[41] = okaruto;
                Afterstatus[41] = StatusManager.instance.Okaruto;
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
                if (StatusManager.instance.WorkP < kagaku)
                {
                    kagaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kagaku += kagaku;
                    InputWorkPKagaku.text = kagaku.ToString();
                }
                else { StatusManager.instance.WorkP -= kagaku;
                       StatusManager.instance.Kagaku -= inputworkp[42];
                       StatusManager.instance.Kagaku += kagaku;
                       StatusManager.instance.WorkP += inputworkp[42];
                }
                NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                inputworkp[42] = kagaku;
                Afterstatus[42] = StatusManager.instance.Kagaku;
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
                if (StatusManager.instance.WorkP < shinwa)
                {
                    shinwa = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Shinwa += shinwa;
                    InputWorkPShinwa.text = shinwa.ToString();
                }
                else { StatusManager.instance.WorkP -= shinwa;
                       StatusManager.instance.Shinwa -= inputworkp[43];
                       StatusManager.instance.Shinwa += shinwa;
                       StatusManager.instance.WorkP += inputworkp[43];
                }
                NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                inputworkp[43] = shinwa;
                Afterstatus[43] = StatusManager.instance.Shinwa;
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
                if (StatusManager.instance.WorkP < gezyutsu)
                {
                    gezyutsu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Gezyutsu += gezyutsu;
                    InputWorkPGezyutsu.text = gezyutsu.ToString();
                }
                else { StatusManager.instance.WorkP -= gezyutsu;
                       StatusManager.instance.Gezyutsu -= inputworkp[44];
                       StatusManager.instance.Gezyutsu += gezyutsu;
                       StatusManager.instance.WorkP += inputworkp[44];
                }
                NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                inputworkp[44] = gezyutsu;
                Afterstatus[44] = StatusManager.instance.Gezyutsu;
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
                if (StatusManager.instance.WorkP < keiri)
                {
                    keiri = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Keiri += keiri;
                    InputWorkPKeiri.text = keiri.ToString();
                }
                else { StatusManager.instance.WorkP -= keiri;
                       StatusManager.instance.Keiri -= inputworkp[45];
                       StatusManager.instance.Keiri += keiri;
                       StatusManager.instance.WorkP += inputworkp[45];
                }
                NowKeiri.text = StatusManager.instance.Keiri.ToString();
                inputworkp[45] = keiri;
                Afterstatus[45] = StatusManager.instance.Keiri;
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
                if (StatusManager.instance.WorkP < kokogaku)
                {
                    kokogaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Kokogaku += kokogaku;
                    InputWorkPKokogaku.text = kokogaku.ToString();
                }
                else { StatusManager.instance.WorkP -= kokogaku;
                       StatusManager.instance.Kokogaku -= inputworkp[46];
                       StatusManager.instance.Kokogaku += kokogaku;
                       StatusManager.instance.WorkP += inputworkp[46];
                }
                NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                inputworkp[46] = kokogaku;
                Afterstatus[46] = StatusManager.instance.Kokogaku;
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
                if (StatusManager.instance.WorkP < pc)
                {
                    pc = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.PC += pc;
                    InputWorkPPC.text = pc.ToString();
                }
                else { StatusManager.instance.WorkP -= pc;
                       StatusManager.instance.PC -= inputworkp[47];
                       StatusManager.instance.PC += pc;
                       StatusManager.instance.WorkP += inputworkp[47];
                }
                NowPC.text = StatusManager.instance.PC.ToString();
                inputworkp[47] = pc;
                Afterstatus[47] = StatusManager.instance.PC;
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
                if (StatusManager.instance.WorkP < shinrigaku)
                {
                    shinrigaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Shinrigaku += shinrigaku;
                    InputWorkPShinrigaku.text = shinrigaku.ToString();
                }
                else { StatusManager.instance.WorkP -= shinrigaku;
                       StatusManager.instance.Shinrigaku -= inputworkp[48];
                       StatusManager.instance.Shinrigaku += shinrigaku;
                       StatusManager.instance.WorkP += inputworkp[48];
                }
                NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                inputworkp[48] = shinrigaku;
                Afterstatus[48] = StatusManager.instance.Shinrigaku;
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
                if (StatusManager.instance.WorkP < zinruigaku)
                {
                    zinruigaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Zinruigaku += zinruigaku;
                    InputWorkPZinruigaku.text = zinruigaku.ToString();
                }
                else { StatusManager.instance.WorkP -= zinruigaku;
                       StatusManager.instance.Zinruigaku -= inputworkp[49];
                       StatusManager.instance.Zinruigaku += zinruigaku;
                       StatusManager.instance.WorkP += inputworkp[49];
                }
                NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                inputworkp[49] = zinruigaku;
                Afterstatus[49] = StatusManager.instance.Zinruigaku;
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
                if (StatusManager.instance.WorkP < seibutsugaku)
                {
                    seibutsugaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Seibutsugaku += seibutsugaku;
                    InputWorkPSeibutsugaku.text = seibutsugaku.ToString();
                }
                else { StatusManager.instance.WorkP -= seibutsugaku;
                       StatusManager.instance.Seibutsugaku -= inputworkp[50];
                       StatusManager.instance.Seibutsugaku += seibutsugaku;
                       StatusManager.instance.WorkP += inputworkp[50];
                }
                NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                inputworkp[50] = seibutsugaku;
                Afterstatus[50] = StatusManager.instance.Seibutsugaku;
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
                if (StatusManager.instance.WorkP < tishitsugaku)
                {
                    tishitsugaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Tishitsugaku += tishitsugaku;
                    InputWorkPTishitsugaku.text = tishitsugaku.ToString();
                }
                else { StatusManager.instance.WorkP -= tishitsugaku;
                       StatusManager.instance.Tishitsugaku -= inputworkp[51];
                       StatusManager.instance.Tishitsugaku += tishitsugaku;
                       StatusManager.instance.WorkP += inputworkp[51];
                }
                NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                inputworkp[51] = tishitsugaku;
                Afterstatus[51] = StatusManager.instance.Tishitsugaku;
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
                if (StatusManager.instance.WorkP < denshikougaku)
                {
                    denshikougaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Denshikougaku += denshikougaku;
                    InputWorkPDenshikougaku.text = denshikougaku.ToString();
                }
                else { StatusManager.instance.WorkP -= denshikougaku;
                       StatusManager.instance.Denshikougaku -= inputworkp[52];
                       StatusManager.instance.Denshikougaku += denshikougaku;
                       StatusManager.instance.WorkP += inputworkp[52];
                }
                NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                inputworkp[52] = denshikougaku;
                Afterstatus[52] = StatusManager.instance.Denshikougaku;
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
                if (StatusManager.instance.WorkP < tenmongaku)
                {
                    tenmongaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Tenmongaku += tenmongaku;
                    InputWorkPTenmongaku.text = tenmongaku.ToString();
                }
                else { StatusManager.instance.WorkP -= tenmongaku;
                       StatusManager.instance.Tenmongaku -= inputworkp[53];
                       StatusManager.instance.Tenmongaku += tenmongaku;
                       StatusManager.instance.WorkP += inputworkp[53];
                }
                NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                inputworkp[53] = tenmongaku;
                Afterstatus[53] = StatusManager.instance.Tenmongaku;
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
                if (StatusManager.instance.WorkP < hakubutsugaku)
                {
                    hakubutsugaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Hakubutsugaku += hakubutsugaku;
                    InputWorkPHakubutsugaku.text = hakubutsugaku.ToString();
                }
                else { StatusManager.instance.WorkP -= hakubutsugaku;
                       StatusManager.instance.Hakubutsugaku -= inputworkp[54];
                       StatusManager.instance.Hakubutsugaku += hakubutsugaku;
                       StatusManager.instance.WorkP += inputworkp[54];
                }
                NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                inputworkp[54] = hakubutsugaku;
                Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
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
                if (StatusManager.instance.WorkP < butsurigaku)
                {
                    butsurigaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Butsurigaku += butsurigaku;
                    InputWorkPButsurigaku.text = butsurigaku.ToString();
                }
                else { StatusManager.instance.WorkP -= butsurigaku;
                       StatusManager.instance.Butsurigaku -= inputworkp[55];
                       StatusManager.instance.Butsurigaku += butsurigaku;
                       StatusManager.instance.WorkP += inputworkp[55];
                }
                NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                inputworkp[55] = butsurigaku;
                Afterstatus[55] = StatusManager.instance.Butsurigaku;
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
                if (StatusManager.instance.WorkP < houritsu)
                {
                    houritsu = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Houritsu += houritsu;
                    InputWorkPHouritsu.text = houritsu.ToString();
                }
                else { StatusManager.instance.WorkP -= houritsu;
                       StatusManager.instance.Houritsu -= inputworkp[56];
                       StatusManager.instance.Houritsu += houritsu;
                       StatusManager.instance.WorkP += inputworkp[56];
                }
                NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                inputworkp[56] = houritsu;
                Afterstatus[56] = StatusManager.instance.Houritsu;
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
                if (StatusManager.instance.WorkP < yakugaku)
                {
                    yakugaku = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Yakugaku += yakugaku;
                    InputWorkPYakugaku.text = yakugaku.ToString();
                }
                else { StatusManager.instance.WorkP -= yakugaku;
                       StatusManager.instance.Yakugaku -= inputworkp[57];
                       StatusManager.instance.Yakugaku += yakugaku;
                       StatusManager.instance.WorkP += inputworkp[57];
                }
                NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                inputworkp[57] = yakugaku;
                Afterstatus[57] = StatusManager.instance.Yakugaku;
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
                if (StatusManager.instance.WorkP < rekishi)
                {
                    rekishi = StatusManager.instance.WorkP;
                    StatusManager.instance.WorkP = 0;
                    StatusManager.instance.Rekishi += rekishi;
                    InputWorkPRekishi.text = rekishi.ToString();
                }
                else { StatusManager.instance.WorkP -= rekishi;
                       StatusManager.instance.Rekishi -= inputworkp[58];
                       StatusManager.instance.Rekishi += rekishi;
                       StatusManager.instance.WorkP += inputworkp[58];
                }
                NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                inputworkp[58] = rekishi;
                Afterstatus[58] = StatusManager.instance.Rekishi;
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
                if (StatusManager.instance.HobbyP < kaihi)
                {
                    kaihi = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kaihi += kaihi;
                    InputHobbyPKaihi.text = kaihi.ToString();
                }
                else  {StatusManager.instance.HobbyP -= kaihi;
                       StatusManager.instance.Kaihi -= inputhobbyp[0];
                       StatusManager.instance.Kaihi += kaihi;
                       StatusManager.instance.HobbyP += inputhobbyp[0];
                }
                NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                inputhobbyp[0] = kaihi;
                Afterstatus[0] = StatusManager.instance.Kaihi;
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
                if (StatusManager.instance.HobbyP < kikku)
                {
                    kikku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kikku += kikku;
                    InputHobbyPKikku.text = kikku.ToString();
                }
                else { StatusManager.instance.HobbyP -= kikku;
                       StatusManager.instance.Kikku -= inputhobbyp[1];
                       StatusManager.instance.Kikku += kikku;
                       StatusManager.instance.HobbyP += inputhobbyp[1];
                }             
                NowKikku.text = StatusManager.instance.Kikku.ToString();
                inputhobbyp[1] = kikku;
                Afterstatus[1] = StatusManager.instance.Kikku;
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
                if (StatusManager.instance.HobbyP < kumitsuki)
                {
                    kumitsuki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kumitsuki += kumitsuki;
                    InputHobbyPKumitsuki.text = kumitsuki.ToString();
                }
                else { StatusManager.instance.HobbyP -= kumitsuki;
                       StatusManager.instance.Kumitsuki -= inputhobbyp[2];
                       StatusManager.instance.Kumitsuki += kumitsuki;
                       StatusManager.instance.HobbyP += inputhobbyp[2];
                }
                NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                inputhobbyp[2] = kumitsuki;
                Afterstatus[2] = StatusManager.instance.Kumitsuki;
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
                if (StatusManager.instance.HobbyP < kobushi)
                {
                    kobushi = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kobushi += kobushi;
                    InputHobbyPKobushi.text = kobushi.ToString();
                }
                else { StatusManager.instance.HobbyP -= kobushi;
                       StatusManager.instance.Kobushi -= inputhobbyp[3];
                       StatusManager.instance.Kobushi += kobushi;
                       StatusManager.instance.HobbyP += inputhobbyp[3];
                }
                NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                inputhobbyp[3] = kobushi;
                Afterstatus[3] = StatusManager.instance.Kobushi;
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
                if (StatusManager.instance.HobbyP < zutsuki)
                {
                    zutsuki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Zutsuki += zutsuki;
                    InputHobbyPZutsuki.text = zutsuki.ToString();
                }
                else { StatusManager.instance.HobbyP -= zutsuki;
                       StatusManager.instance.Zutsuki -= inputhobbyp[4];
                       StatusManager.instance.Zutsuki += zutsuki;
                       StatusManager.instance.HobbyP += inputhobbyp[4];
                }
                NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                inputhobbyp[4] = zutsuki;
                Afterstatus[4] = StatusManager.instance.Zutsuki;
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
                if (StatusManager.instance.HobbyP < toteki)
                {
                    toteki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Toteki += toteki;
                    InputHobbyPToteki.text = toteki.ToString();
                }
                else { StatusManager.instance.HobbyP -= toteki;
                       StatusManager.instance.Toteki -= inputhobbyp[5];
                       StatusManager.instance.Toteki += toteki;
                       StatusManager.instance.HobbyP += inputhobbyp[5];
                }
                NowToteki.text = StatusManager.instance.Toteki.ToString();
                inputhobbyp[5] = toteki;
                Afterstatus[5] = StatusManager.instance.Toteki;
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
                if (StatusManager.instance.HobbyP < msa)
                {
                    msa = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.MSA += msa;
                    InputHobbyPMSA.text = msa.ToString();
                }
                else { StatusManager.instance.HobbyP -= msa;
                       StatusManager.instance.MSA -= inputhobbyp[6];
                       StatusManager.instance.MSA += msa;
                       StatusManager.instance.HobbyP += inputhobbyp[6];
                }
                NowMSA.text = StatusManager.instance.MSA.ToString();
                inputhobbyp[6] = msa;
                Afterstatus[6] = StatusManager.instance.MSA;
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
                if (StatusManager.instance.HobbyP < kenzyu)
                {
                    kenzyu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kenzyu += kenzyu;
                    InputHobbyPKenzyu.text = kenzyu.ToString();
                }
                else { StatusManager.instance.HobbyP -= kenzyu;
                       StatusManager.instance.Kenzyu -= inputhobbyp[7];
                       StatusManager.instance.Kenzyu += kenzyu;
                       StatusManager.instance.HobbyP += inputhobbyp[7];
                }
                NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                inputhobbyp[7] = kenzyu;
                Afterstatus[7] = StatusManager.instance.Kenzyu;
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
                if (StatusManager.instance.HobbyP < smg)
                {
                    smg = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.SMG += smg;
                    InputHobbyPSMG.text = smg.ToString();
                }
                else { StatusManager.instance.HobbyP -= smg;
                       StatusManager.instance.SMG -= inputhobbyp[8];
                       StatusManager.instance.SMG += smg;
                       StatusManager.instance.HobbyP += inputhobbyp[8];
                }
                NowSMG.text = StatusManager.instance.SMG.ToString();
                inputhobbyp[8] = smg;
                Afterstatus[8] = StatusManager.instance.SMG;
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
                if (StatusManager.instance.HobbyP < sg)
                {
                    sg = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.SG += sg;
                    InputHobbyPSG.text = sg.ToString();
                }
                else { StatusManager.instance.HobbyP -= sg;
                       StatusManager.instance.SG -= inputhobbyp[9];
                       StatusManager.instance.SG += sg;
                       StatusManager.instance.HobbyP += inputhobbyp[9];
                }
                NowSG.text = StatusManager.instance.SG.ToString();
                inputhobbyp[9] = sg;
                Afterstatus[9] = StatusManager.instance.SG;
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
                if (StatusManager.instance.HobbyP < mg)
                {
                    mg = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.MG += mg;
                    InputHobbyPMG.text = mg.ToString();
                }
                else { StatusManager.instance.HobbyP -= mg;
                       StatusManager.instance.MG -= inputhobbyp[10];
                       StatusManager.instance.MG += mg;
                       StatusManager.instance.HobbyP += inputhobbyp[10];
                }
                NowMG.text = StatusManager.instance.MG.ToString();
                inputhobbyp[10] = mg;
                Afterstatus[10] = StatusManager.instance.MG;
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
                if (StatusManager.instance.HobbyP < r)
                {
                    r = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.R += r;
                    InputHobbyPR.text = r.ToString();
                }
                else { StatusManager.instance.HobbyP -= r;
                       StatusManager.instance.R -= inputhobbyp[11];
                       StatusManager.instance.R += r;
                       StatusManager.instance.HobbyP += inputhobbyp[11];
                }
                NowR.text = StatusManager.instance.R.ToString();
                inputhobbyp[11] = r;
                Afterstatus[11] = StatusManager.instance.R;
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
                if (StatusManager.instance.HobbyP < okyuteate)
                {
                    okyuteate = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Okyuteate += okyuteate;
                    InputHobbyPOkyuteate.text = okyuteate.ToString();
                }
                else { StatusManager.instance.HobbyP -= okyuteate;
                       StatusManager.instance.Okyuteate -= inputhobbyp[12];
                       StatusManager.instance.Okyuteate += okyuteate;
                       StatusManager.instance.HobbyP += inputhobbyp[12];
                }
                NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                inputhobbyp[12] = okyuteate;
                Afterstatus[12] = StatusManager.instance.Okyuteate;
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
                if (StatusManager.instance.HobbyP < kagiake)
                {
                    kagiake = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kagiake += kagiake;
                    InputHobbyPKagiake.text = kagiake.ToString();
                }
                else { StatusManager.instance.HobbyP -= kagiake;
                       StatusManager.instance.Kagiake -= inputhobbyp[13];
                       StatusManager.instance.Kagiake += kagiake;
                       StatusManager.instance.HobbyP += inputhobbyp[13];
                }
                NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                inputhobbyp[13] = kagiake;
                Afterstatus[13] = StatusManager.instance.Kagiake;
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
                if (StatusManager.instance.HobbyP < kakusu)
                {
                    kakusu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kakusu += kakusu;
                    InputHobbyPKakusu.text = kakusu.ToString();
                }
                else { StatusManager.instance.HobbyP -= kakusu;
                       StatusManager.instance.Kakusu -= inputhobbyp[14];
                       StatusManager.instance.Kakusu += kakusu;
                       StatusManager.instance.HobbyP += inputhobbyp[14];
                }
                NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                inputhobbyp[14] = kakusu;
                Afterstatus[14] = StatusManager.instance.Kakusu;
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
                if (StatusManager.instance.HobbyP < kakureru)
                {
                    kakureru = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kakureru += kakureru;
                    InputHobbyPKakureru.text = kakureru.ToString();
                }
                else { StatusManager.instance.HobbyP -= kakureru;
                       StatusManager.instance.Kakureru -= inputhobbyp[15];
                       StatusManager.instance.Kakureru += kakureru;
                       StatusManager.instance.HobbyP += inputhobbyp[15];
                }
                NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                inputhobbyp[15] = kakureru;
                Afterstatus[15] = StatusManager.instance.Kakureru;
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
                if (StatusManager.instance.HobbyP < kikimimi)
                {
                    kikimimi = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kikimimi += kikimimi;
                    InputHobbyPKikimimi.text = kikimimi.ToString();
                }
                else { StatusManager.instance.HobbyP -= kikimimi;
                       StatusManager.instance.Kikimimi -= inputhobbyp[16];
                       StatusManager.instance.Kikimimi += kikimimi;
                       StatusManager.instance.HobbyP += inputhobbyp[16];
                }
                NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                inputhobbyp[16] = kikimimi;
                Afterstatus[16] = StatusManager.instance.Kikimimi;
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
                if (StatusManager.instance.HobbyP < shinobiaruki)
                {
                    shinobiaruki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Shinobiaruki += shinobiaruki;
                    InputHobbyPShinobiaruki.text = shinobiaruki.ToString();
                }
                else { StatusManager.instance.HobbyP -= shinobiaruki;
                       StatusManager.instance.Shinobiaruki -= inputhobbyp[17];
                       StatusManager.instance.Shinobiaruki += shinobiaruki;
                       StatusManager.instance.HobbyP += inputhobbyp[17];
                }
                NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                inputhobbyp[17] = shinobiaruki;
                Afterstatus[17] = StatusManager.instance.Shinobiaruki;
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
                if (StatusManager.instance.HobbyP < syashinzyutsu)
                {
                    syashinzyutsu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Syashinzyutsu += syashinzyutsu;
                    InputHobbyPSyashinzyutsu.text = syashinzyutsu.ToString();
                }
                else { StatusManager.instance.HobbyP -= syashinzyutsu;
                       StatusManager.instance.Syashinzyutsu -= inputhobbyp[18];
                       StatusManager.instance.Syashinzyutsu += syashinzyutsu;
                       StatusManager.instance.HobbyP += inputhobbyp[18];
                }
                NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                inputhobbyp[18] = syashinzyutsu;
                Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
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
                if (StatusManager.instance.WorkP < seshinbunseki)
                {
                    seshinbunseki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Seshinbunseki += seshinbunseki;
                    InputHobbyPSeshinbunseki.text = seshinbunseki.ToString();
                }
                else { StatusManager.instance.HobbyP -= seshinbunseki;
                       StatusManager.instance.Seshinbunseki -= inputhobbyp[19];
                       StatusManager.instance.Seshinbunseki += seshinbunseki;
                       StatusManager.instance.HobbyP += inputhobbyp[19];
                }
                NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                inputhobbyp[19] = seshinbunseki;
                Afterstatus[19] = StatusManager.instance.Seshinbunseki;
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
                if (StatusManager.instance.HobbyP < tsuiseki)
                {
                    tsuiseki = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Tsuiseki += tsuiseki;
                    InputHobbyPTsuiseki.text = tsuiseki.ToString();
                }
                else { StatusManager.instance.HobbyP -= tsuiseki;
                       StatusManager.instance.Tsuiseki -= inputhobbyp[20];
                       StatusManager.instance.Tsuiseki += tsuiseki;
                       StatusManager.instance.HobbyP += inputhobbyp[20];
                }
                NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                inputhobbyp[20] = tsuiseki;
                Afterstatus[20] = StatusManager.instance.Tsuiseki;
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
                if (StatusManager.instance.HobbyP < touhan)
                {
                    touhan = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Touhan += touhan;
                    InputHobbyPTouhan.text = touhan.ToString();
                }
                else { StatusManager.instance.HobbyP -= touhan;
                       StatusManager.instance.Touhan -= inputhobbyp[21];
                       StatusManager.instance.Touhan += touhan;
                       StatusManager.instance.HobbyP += inputhobbyp[21];
                }
                NowTouhan.text = StatusManager.instance.Touhan.ToString();
                inputhobbyp[21] = touhan;
                Afterstatus[21] = StatusManager.instance.Touhan;
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
                if (StatusManager.instance.HobbyP < tosyokan)
                {
                    tosyokan = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Tosyokan += tosyokan;
                    InputHobbyPTosyokan.text = tosyokan.ToString();
                }
                else { StatusManager.instance.HobbyP -= tosyokan;
                       StatusManager.instance.Tosyokan -= inputhobbyp[22];
                       StatusManager.instance.Tosyokan += tosyokan;
                       StatusManager.instance.HobbyP += inputhobbyp[22];
                }
                NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                inputhobbyp[22] = tosyokan;
                Afterstatus[22] = StatusManager.instance.Tosyokan;
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
                if (StatusManager.instance.HobbyP < meboshi)
                {
                    meboshi = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Meboshi += meboshi;
                    InputHobbyPMeboshi.text = meboshi.ToString();
                }
                else { StatusManager.instance.HobbyP -= meboshi;
                       StatusManager.instance.Meboshi -= inputhobbyp[23];
                       StatusManager.instance.Meboshi += meboshi;
                       StatusManager.instance.HobbyP += inputhobbyp[23];
                }
                NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                inputhobbyp[23] = meboshi;
                Afterstatus[23] = StatusManager.instance.Meboshi;
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
                if (StatusManager.instance.HobbyP < unten)
                {
                    unten = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Unten += unten;
                    InputHobbyPUnten.text = unten.ToString();
                }
                else { StatusManager.instance.HobbyP -= unten;
                       StatusManager.instance.Unten -= inputhobbyp[24];
                       StatusManager.instance.Unten += unten;
                       StatusManager.instance.HobbyP += inputhobbyp[24];
                }
                NowUnten.text = StatusManager.instance.Unten.ToString();
                inputhobbyp[24] = unten;
                Afterstatus[24] = StatusManager.instance.Unten;
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
                if (StatusManager.instance.HobbyP < kikaisyuri)
                {
                    kikaisyuri = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kikaisyuri += kikaisyuri;
                    InputHobbyPKikaisyuri.text = kikaisyuri.ToString();
                }
                else { StatusManager.instance.HobbyP -= kikaisyuri;
                       StatusManager.instance.Kikaisyuri -= inputhobbyp[25];
                       StatusManager.instance.Kikaisyuri += kikaisyuri;
                       StatusManager.instance.HobbyP += inputhobbyp[25];
                }
                NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                inputhobbyp[25] = kikaisyuri;
                Afterstatus[25] = StatusManager.instance.Kikaisyuri;
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
                if (StatusManager.instance.HobbyP < zyukikaisosa)
                {
                    zyukikaisosa = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Zyukikaisosa += zyukikaisosa;
                    InputHobbyPZyukikaisosa.text = zyukikaisosa.ToString();
                }
                else { StatusManager.instance.HobbyP -= zyukikaisosa;
                       StatusManager.instance.Zyukikaisosa -= inputhobbyp[26];
                       StatusManager.instance.Zyukikaisosa += zyukikaisosa;
                       StatusManager.instance.HobbyP += inputhobbyp[26];
                }
                NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                inputhobbyp[26] = zyukikaisosa;
                Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
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
                if (StatusManager.instance.HobbyP < zyoba)
                {
                    zyoba = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Zyoba += zyoba;
                    InputHobbyPZyoba.text = zyoba.ToString();
                }
                else { StatusManager.instance.HobbyP -= zyoba;
                       StatusManager.instance.Zyoba -= inputhobbyp[27];
                       StatusManager.instance.Zyoba += zyoba;
                       StatusManager.instance.HobbyP += inputhobbyp[27];
                }
                NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                inputhobbyp[27] = zyoba;
                Afterstatus[27] = StatusManager.instance.Zyoba;
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
                if (StatusManager.instance.HobbyP < suiei)
                {
                    suiei = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Suiei += suiei;
                    InputHobbyPSuiei.text = suiei.ToString();
                }
                else { StatusManager.instance.HobbyP -= suiei;
                       StatusManager.instance.Suiei -= inputhobbyp[28];
                       StatusManager.instance.Suiei += suiei;
                       StatusManager.instance.HobbyP += inputhobbyp[28];
                }
                NowSuiei.text = StatusManager.instance.Suiei.ToString();
                inputhobbyp[28] = suiei;
                Afterstatus[28] = StatusManager.instance.Suiei;
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
                if (StatusManager.instance.HobbyP < sesaku)
                {
                    sesaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Sesaku += sesaku;
                    InputHobbyPSesaku.text = sesaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= sesaku;
                       StatusManager.instance.Sesaku -= inputhobbyp[29];
                       StatusManager.instance.Sesaku += sesaku;
                       StatusManager.instance.HobbyP += inputhobbyp[29];
                }
                NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                inputhobbyp[29] = sesaku;
                Afterstatus[29] = StatusManager.instance.Sesaku;
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
                if (StatusManager.instance.HobbyP < sozyu)
                {
                    sozyu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Sozyu += sozyu;
                    InputHobbyPSozyu.text = sozyu.ToString();
                }
                else { StatusManager.instance.HobbyP -= sozyu;
                       StatusManager.instance.Sozyu -= inputhobbyp[30];
                       StatusManager.instance.Sozyu += sozyu;
                       StatusManager.instance.HobbyP += inputhobbyp[30];
                }
                NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                inputhobbyp[30] = sozyu;
                Afterstatus[30] = StatusManager.instance.Sozyu;
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
                if (StatusManager.instance.HobbyP < tyoyaku)
                {
                    tyoyaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Tyoyaku += tyoyaku;
                    InputHobbyPTyoyaku.text = tyoyaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= tyoyaku;
                       StatusManager.instance.Tyoyaku -= inputhobbyp[31];
                       StatusManager.instance.Tyoyaku += tyoyaku;
                       StatusManager.instance.HobbyP += inputhobbyp[31];
                }
                NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                inputhobbyp[31] = tyoyaku;
                Afterstatus[31] = StatusManager.instance.Tyoyaku;
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
                if (StatusManager.instance.HobbyP < denkisyuri)
                {
                    denkisyuri = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Denkisyuri += denkisyuri;
                    InputHobbyPDenkisyuri.text = denkisyuri.ToString();
                }
                else { StatusManager.instance.HobbyP -= denkisyuri;
                       StatusManager.instance.Denkisyuri -= inputhobbyp[32];
                       StatusManager.instance.Denkisyuri += denkisyuri;
                       StatusManager.instance.HobbyP += inputhobbyp[32];
                }
                NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                inputhobbyp[32] = denkisyuri;
                Afterstatus[32] = StatusManager.instance.Denkisyuri;
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
                if (StatusManager.instance.HobbyP < nabigeto)
                {
                    nabigeto = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Nabigeto += nabigeto;
                    InputHobbyPNabigeto.text = nabigeto.ToString();
                }
                else { StatusManager.instance.HobbyP -= nabigeto;
                       StatusManager.instance.Nabigeto -= inputhobbyp[33];
                       StatusManager.instance.Nabigeto += nabigeto;
                       StatusManager.instance.HobbyP += inputhobbyp[33];
                }
                NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                inputhobbyp[33] = nabigeto;
                Afterstatus[33] = StatusManager.instance.Nabigeto;
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
                if (StatusManager.instance.HobbyP < hensou)
                {
                    hensou = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Hensou += hensou;
                    InputHobbyPHensou.text = hensou.ToString();
                }
                else { StatusManager.instance.HobbyP -= hensou;
                       StatusManager.instance.Hensou -= inputhobbyp[34];
                       StatusManager.instance.Hensou += hensou;
                       StatusManager.instance.HobbyP += inputhobbyp[34];
                }
                NowHensou.text = StatusManager.instance.Hensou.ToString();
                inputhobbyp[34] = hensou;
                Afterstatus[34] = StatusManager.instance.Hensou;
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
                if (StatusManager.instance.HobbyP < iikurume)
                {
                    iikurume = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Iikurume += iikurume;
                    InputHobbyPIikurume.text = iikurume.ToString();
                }
                else { StatusManager.instance.HobbyP -= iikurume;
                       StatusManager.instance.Iikurume -= inputhobbyp[35];
                       StatusManager.instance.Iikurume += iikurume;
                       StatusManager.instance.HobbyP += inputhobbyp[35];
                }
                NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                inputhobbyp[35] = iikurume;
                Afterstatus[35] = StatusManager.instance.Iikurume;
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
                if (StatusManager.instance.HobbyP < shinyou)
                {
                    shinyou = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Shinyou += shinyou;
                    InputHobbyPShinyou.text = shinyou.ToString();
                }
                else { StatusManager.instance.HobbyP -= shinyou;
                       StatusManager.instance.Shinyou -= inputhobbyp[36];
                       StatusManager.instance.Shinyou += shinyou;
                       StatusManager.instance.HobbyP += inputhobbyp[36];
                }
                NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                inputhobbyp[36] = shinyou;
                Afterstatus[36] = StatusManager.instance.Shinyou;
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
                if (StatusManager.instance.HobbyP < settoku)
                {
                    settoku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Settoku += settoku;
                    InputHobbyPSettoku.text = settoku.ToString();
                }
                else { StatusManager.instance.HobbyP -= settoku;
                       StatusManager.instance.Settoku -= inputhobbyp[37];
                       StatusManager.instance.Settoku += settoku;
                       StatusManager.instance.HobbyP += inputhobbyp[37];
                }
                NowSettoku.text = StatusManager.instance.Settoku.ToString();
                inputhobbyp[37] = settoku;
                Afterstatus[37] = StatusManager.instance.Settoku;
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
                if (StatusManager.instance.HobbyP < negiri)
                {
                    negiri = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Negiri += negiri;
                    InputHobbyPNegiri.text = negiri.ToString();
                }
                else { StatusManager.instance.HobbyP -= negiri;
                       StatusManager.instance.Negiri -= inputhobbyp[38];
                       StatusManager.instance.Negiri += negiri;
                       StatusManager.instance.HobbyP += inputhobbyp[38];
                }
                NowNegiri.text = StatusManager.instance.Negiri.ToString();
                inputhobbyp[38] = negiri;
                Afterstatus[38] = StatusManager.instance.Negiri;
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
                if (StatusManager.instance.HobbyP < bokokugo)
                {
                    bokokugo = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Bokokugo += bokokugo;
                    InputHobbyPBokokugo.text = bokokugo.ToString();
                }
                else { StatusManager.instance.HobbyP -= bokokugo;
                       StatusManager.instance.Bokokugo -= inputhobbyp[39];
                       StatusManager.instance.Bokokugo += bokokugo;
                       StatusManager.instance.HobbyP += inputhobbyp[39];
                }
                NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                inputhobbyp[39] = bokokugo;
                Afterstatus[39] = StatusManager.instance.Bokokugo;
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
                if (StatusManager.instance.HobbyP < igaku)
                {
                    igaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Igaku += igaku;
                    InputHobbyPIgaku.text = igaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= igaku;
                       StatusManager.instance.Igaku -= inputhobbyp[40];
                       StatusManager.instance.Igaku += igaku;
                       StatusManager.instance.HobbyP += inputhobbyp[40];
                }
                NowIgaku.text = StatusManager.instance.Igaku.ToString();
                inputhobbyp[40] = igaku;
                Afterstatus[40] = StatusManager.instance.Igaku;
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
                if (StatusManager.instance.HobbyP < okaruto)
                {
                    okaruto = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Okaruto += okaruto;
                    InputHobbyPOkaruto.text = okaruto.ToString();
                }
                else { StatusManager.instance.HobbyP -= okaruto;
                       StatusManager.instance.Okaruto -= inputhobbyp[41];
                       StatusManager.instance.Okaruto += okaruto;
                       StatusManager.instance.HobbyP += inputhobbyp[41];
                }
                NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                inputhobbyp[41] = okaruto;
                Afterstatus[41] = StatusManager.instance.Okaruto;
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
                if (StatusManager.instance.HobbyP < kagaku)
                {
                    kagaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kagaku += kagaku;
                    InputHobbyPKagaku.text = kagaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= kagaku;
                       StatusManager.instance.Kagaku -= inputhobbyp[42];
                       StatusManager.instance.Kagaku += kagaku;
                       StatusManager.instance.HobbyP += inputhobbyp[42];
                }
                NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                inputhobbyp[42] = kagaku;
                Afterstatus[42] = StatusManager.instance.Kagaku;
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
                if (StatusManager.instance.HobbyP < shinwa)
                {
                    shinwa = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Shinwa += shinwa;
                    InputHobbyPShinwa.text = shinwa.ToString();
                }
                else { StatusManager.instance.HobbyP -= shinwa;
                       StatusManager.instance.Shinwa -= inputhobbyp[43];
                       StatusManager.instance.Shinwa += shinwa;
                       StatusManager.instance.HobbyP += inputhobbyp[43];
                }
                NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                inputhobbyp[43] = shinwa;
                Afterstatus[43] = StatusManager.instance.Shinwa;
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
                if (StatusManager.instance.HobbyP < gezyutsu)
                {
                    gezyutsu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Gezyutsu += gezyutsu;
                    InputHobbyPGezyutsu.text = gezyutsu.ToString();
                }
                else { StatusManager.instance.HobbyP -= gezyutsu;
                       StatusManager.instance.Gezyutsu -= inputhobbyp[44];
                       StatusManager.instance.Gezyutsu += gezyutsu;
                       StatusManager.instance.HobbyP += inputhobbyp[44];
                }
                NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                inputhobbyp[44] = gezyutsu;
                Afterstatus[44] = StatusManager.instance.Gezyutsu;
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
                if (StatusManager.instance.HobbyP < keiri)
                {
                    keiri = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Keiri += keiri;
                    InputHobbyPKeiri.text = keiri.ToString();
                }
                else { StatusManager.instance.HobbyP -= keiri;
                       StatusManager.instance.Keiri -= inputhobbyp[45];
                       StatusManager.instance.Keiri += keiri;
                       StatusManager.instance.HobbyP += inputhobbyp[45];
                }
                NowKeiri.text = StatusManager.instance.Keiri.ToString();
                inputhobbyp[45] = keiri;
                Afterstatus[45] = StatusManager.instance.Keiri;
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
                if (StatusManager.instance.HobbyP < kokogaku)
                {
                    kokogaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Kokogaku += kokogaku;
                    InputHobbyPKokogaku.text = kokogaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= kokogaku;
                       StatusManager.instance.Kokogaku -= inputhobbyp[46];
                       StatusManager.instance.Kokogaku += kokogaku;
                       StatusManager.instance.HobbyP += inputhobbyp[46];
                }
                NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                inputhobbyp[46] = kokogaku;
                Afterstatus[46] = StatusManager.instance.Kokogaku;
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
                if (StatusManager.instance.HobbyP < pc)
                {
                    pc = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.PC += pc;
                    InputHobbyPPC.text = pc.ToString();
                }
                else { StatusManager.instance.HobbyP -= pc;
                       StatusManager.instance.PC -= inputhobbyp[47];
                       StatusManager.instance.PC += pc;
                       StatusManager.instance.HobbyP += inputhobbyp[47];
                }
                NowPC.text = StatusManager.instance.PC.ToString();
                inputhobbyp[47] = pc;
                Afterstatus[47] = StatusManager.instance.PC;
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
                if (StatusManager.instance.HobbyP < shinrigaku)
                {
                    shinrigaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Shinrigaku += shinrigaku;
                    InputHobbyPShinrigaku.text = shinrigaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= shinrigaku;
                       StatusManager.instance.Shinrigaku -= inputhobbyp[48];
                       StatusManager.instance.Shinrigaku += shinrigaku;
                       StatusManager.instance.WorkP += inputhobbyp[48];
                }
                NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                inputhobbyp[48] = shinrigaku;
                Afterstatus[48] = StatusManager.instance.Shinrigaku;
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
                if (StatusManager.instance.HobbyP < zinruigaku)
                {
                    zinruigaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Zinruigaku += zinruigaku;
                    InputHobbyPZinruigaku.text = zinruigaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= zinruigaku;
                       StatusManager.instance.Zinruigaku -= inputhobbyp[49];
                       StatusManager.instance.Zinruigaku += zinruigaku;
                       StatusManager.instance.HobbyP += inputhobbyp[49];
                }
                NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                inputhobbyp[49] = zinruigaku;
                Afterstatus[49] = StatusManager.instance.Zinruigaku;
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
                if (StatusManager.instance.HobbyP < seibutsugaku)
                {
                    seibutsugaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Seibutsugaku += seibutsugaku;
                    InputHobbyPSeibutsugaku.text = seibutsugaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= seibutsugaku;
                       StatusManager.instance.Seibutsugaku -= inputhobbyp[50];
                       StatusManager.instance.Seibutsugaku += seibutsugaku;
                       StatusManager.instance.HobbyP += inputhobbyp[50];
                }
                NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                inputhobbyp[50] = seibutsugaku;
                Afterstatus[50] = StatusManager.instance.Seibutsugaku;
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
                if (StatusManager.instance.HobbyP < tishitsugaku)
                {
                    tishitsugaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Tishitsugaku += tishitsugaku;
                    InputHobbyPTishitsugaku.text = tishitsugaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= tishitsugaku;
                       StatusManager.instance.Tishitsugaku -= inputhobbyp[51];
                       StatusManager.instance.Tishitsugaku += tishitsugaku;
                       StatusManager.instance.HobbyP += inputhobbyp[51];
                }
                NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                inputhobbyp[51] = tishitsugaku;
                Afterstatus[51] = StatusManager.instance.Tishitsugaku;
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
                if (StatusManager.instance.HobbyP < denshikougaku)
                {
                    denshikougaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Denshikougaku += denshikougaku;
                    InputHobbyPDenshikougaku.text = denshikougaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= denshikougaku;
                       StatusManager.instance.Denshikougaku -= inputhobbyp[52];
                       StatusManager.instance.Denshikougaku += denshikougaku;
                       StatusManager.instance.HobbyP += inputhobbyp[52];
                }
                NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                inputhobbyp[52] = denshikougaku;
                Afterstatus[52] = StatusManager.instance.Denshikougaku;
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
                if (StatusManager.instance.HobbyP < tenmongaku)
                {
                    tenmongaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Tenmongaku += tenmongaku;
                    InputHobbyPTenmongaku.text = tenmongaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= tenmongaku;
                       StatusManager.instance.Tenmongaku -= inputhobbyp[53];
                       StatusManager.instance.Tenmongaku += tenmongaku;
                       StatusManager.instance.HobbyP += inputhobbyp[53];
                }
                NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                inputhobbyp[53] = tenmongaku;
                Afterstatus[53] = StatusManager.instance.Tenmongaku;
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
                if (StatusManager.instance.HobbyP < hakubutsugaku)
                {
                    hakubutsugaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Hakubutsugaku += hakubutsugaku;
                    InputHobbyPHakubutsugaku.text = hakubutsugaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= hakubutsugaku;
                       StatusManager.instance.Hakubutsugaku -= inputhobbyp[54];
                       StatusManager.instance.Hakubutsugaku += hakubutsugaku;
                       StatusManager.instance.HobbyP += inputhobbyp[54];
                }
                NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                inputhobbyp[54] = hakubutsugaku;
                Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
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
                if (StatusManager.instance.HobbyP < butsurigaku)
                {
                    butsurigaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Butsurigaku += butsurigaku;
                    InputHobbyPButsurigaku.text = butsurigaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= butsurigaku;
                       StatusManager.instance.Butsurigaku -= inputhobbyp[55];
                       StatusManager.instance.Butsurigaku += butsurigaku;
                       StatusManager.instance.HobbyP += inputhobbyp[55];
                }
                NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                inputhobbyp[55] = butsurigaku;
                Afterstatus[55] = StatusManager.instance.Butsurigaku;
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
                if (StatusManager.instance.HobbyP < houritsu)
                {
                    houritsu = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Houritsu += houritsu;
                    InputHobbyPHouritsu.text = houritsu.ToString();
                }
                else { StatusManager.instance.HobbyP -= houritsu;
                       StatusManager.instance.Houritsu -= inputhobbyp[56];
                       StatusManager.instance.Houritsu += houritsu;
                       StatusManager.instance.HobbyP += inputhobbyp[56];
                }
                NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                inputhobbyp[56] = houritsu;
                Afterstatus[56] = StatusManager.instance.Houritsu;
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
                if (StatusManager.instance.HobbyP < yakugaku)
                {
                    yakugaku = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Yakugaku += yakugaku;
                    InputHobbyPYakugaku.text = yakugaku.ToString();
                }
                else { StatusManager.instance.HobbyP -= yakugaku;
                       StatusManager.instance.Yakugaku -= inputhobbyp[57];
                       StatusManager.instance.Yakugaku += yakugaku;
                       StatusManager.instance.HobbyP += inputhobbyp[57];
                }
                NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                inputhobbyp[57] = yakugaku;
                Afterstatus[57] = StatusManager.instance.Yakugaku;
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
                if (StatusManager.instance.HobbyP < rekishi)
                {
                    rekishi = StatusManager.instance.HobbyP;
                    StatusManager.instance.HobbyP = 0;
                    StatusManager.instance.Rekishi += rekishi;
                    InputHobbyPRekishi.text = rekishi.ToString();
                }
                else { StatusManager.instance.HobbyP -= rekishi;
                       StatusManager.instance.Rekishi -= inputhobbyp[58];
                       StatusManager.instance.Rekishi += rekishi;
                       StatusManager.instance.HobbyP += inputhobbyp[58];
                }
                NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                inputhobbyp[58] = rekishi;
                Afterstatus[58] = StatusManager.instance.Rekishi;
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
                if ((StatusManager.instance.Kaihi < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kaihi += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[0] += 1;
                    InputWorkPKaihi.text = inputworkp[0].ToString();
                    NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.instance.Kaihi;
                }
                else { return; }break;
            case 1:     //キック
                if ((StatusManager.instance.Kikku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kikku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[1] += 1;
                    InputWorkPKikku.text = inputworkp[1].ToString();
                    NowKikku.text = StatusManager.instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.instance.Kikku;
                }
                else { return; }break;
            case 2:     //組み付き
                if ((StatusManager.instance.Kumitsuki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kumitsuki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[2] += 1;
                    InputWorkPKumitsuki.text = inputworkp[2].ToString();
                    NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.instance.Kumitsuki;
                }
                else { return; }break;
            case 3:     //こぶし
                if ((StatusManager.instance.Kobushi < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kobushi += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[3] += 1;
                    InputWorkPKobushi.text = inputworkp[3].ToString();
                    NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.instance.Kobushi;
                }
                else { return; }break;
            case 4:     //頭突き
                if ((StatusManager.instance.Zutsuki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Zutsuki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[4] += 1;
                    InputWorkPZutsuki.text = inputworkp[4].ToString();
                    NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.instance.Zutsuki;
                }
                else { return; }break;
            case 5:     //投擲
                if ((StatusManager.instance.Toteki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Toteki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[5] += 1;
                    InputWorkPToteki.text = inputworkp[5].ToString();
                    NowToteki.text = StatusManager.instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.instance.Toteki;
                }
                else { return; }break;
            case 6:     //マーシャルアーツ
                if ((StatusManager.instance.MSA < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.MSA += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[6] += 1;
                    InputWorkPMSA.text = inputworkp[6].ToString();
                    NowMSA.text = StatusManager.instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.instance.MSA;
                }
                else { return; }break;
            case 7:     //拳銃
                if ((StatusManager.instance.Kenzyu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kenzyu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[7] += 1;
                    InputWorkPKenzyu.text = inputworkp[7].ToString();
                    NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.instance.Kenzyu;
                }
                else { return; }break;
            case 8:     //サブマシンガン
                if ((StatusManager.instance.SMG < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.SMG += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[8] += 1;
                    InputWorkPSMG.text = inputworkp[8].ToString();
                    NowSMG.text = StatusManager.instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.instance.SMG;
                }
                else { return; }break;
            case 9:     //ショットガン
                if ((StatusManager.instance.SG < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.SG += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[9] += 1;
                    InputWorkPSG.text = inputworkp[9].ToString();
                    NowSG.text = StatusManager.instance.SG.ToString();
                    Afterstatus[9] = StatusManager.instance.SG;
                }
                else { return; }break;
            case 10:    //マシンガン
                if ((StatusManager.instance.MG < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.MG += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[10] += 1;
                    InputWorkPMG.text = inputworkp[10].ToString();
                    NowMG.text = StatusManager.instance.MG.ToString();
                    Afterstatus[10] = StatusManager.instance.MG;
                }
                else { return; }break;
            case 11:    //ライフル
                if ((StatusManager.instance.R < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.R += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[11] += 1;
                    InputWorkPR.text = inputworkp[11].ToString();
                    NowR.text = StatusManager.instance.R.ToString();
                    Afterstatus[11] = StatusManager.instance.R;
                }
                else { return; }break;

            //探索技能ステータス
            case 100:    //応急手当
                if ((StatusManager.instance.Okyuteate < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Okyuteate += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[12] += 1;
                    InputWorkPOkyuteate.text = inputworkp[12].ToString();
                    NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.instance.Okyuteate;
                }
                else { return; }break;
            case 101:    //鍵開け
                if ((StatusManager.instance.Kagiake < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kagiake += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[13] += 1;
                    InputWorkPKagiake.text = inputworkp[13].ToString();
                    NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.instance.Kagiake;
                }
                else { return; }break;
            case 102:    //隠す
                if ((StatusManager.instance.Kakusu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kakusu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[14] += 1;
                    InputWorkPKakusu.text = inputworkp[14].ToString();
                    NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.instance.Kakusu;
                }
                else { return; }break;
            case 103:    //隠れる
                if ((StatusManager.instance.Kakureru < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kakureru += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[15] += 1;
                    InputWorkPKakureru.text = inputworkp[15].ToString();
                    NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.instance.Kakureru;
                }
                else { return; }break;
            case 104:    //聞き耳
                if ((StatusManager.instance.Kikimimi < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kikimimi += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[16] += 1;
                    InputWorkPKikimimi.text = inputworkp[16].ToString();
                    NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.instance.Kikimimi;
                }
                else { return; }break;
            case 105:    //忍び歩き
                if ((StatusManager.instance.Shinobiaruki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Shinobiaruki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[17] += 1;
                    InputWorkPShinobiaruki.text = inputworkp[17].ToString();
                    NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.instance.Shinobiaruki;
                }
                else { return; }break;
            case 106:    //写真術
                if ((StatusManager.instance.Syashinzyutsu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Syashinzyutsu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[18] += 1;
                    InputWorkPSyashinzyutsu.text = inputworkp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
                }
                else { return; }break;
            case 107:    //精神分析
                if ((StatusManager.instance.Seshinbunseki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Seshinbunseki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[19] += 1;
                    InputWorkPSeshinbunseki.text = inputworkp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.instance.Seshinbunseki;
                }
                else { return; }break;
            case 108:    //追跡
                if ((StatusManager.instance.Tsuiseki < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Tsuiseki += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[20] += 1;
                    InputWorkPTsuiseki.text = inputworkp[20].ToString();
                    NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.instance.Tsuiseki;
                }
                else { return; }break;
            case 109:    //登攀
                if ((StatusManager.instance.Touhan < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Touhan += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[21] += 1;
                    InputWorkPTouhan.text = inputworkp[21].ToString();
                    NowTouhan.text = StatusManager.instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.instance.Touhan;
                }
                else { return; }break;
            case 110:    //図書館
                if ((StatusManager.instance.Tosyokan < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Tosyokan += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[22] += 1;
                    InputWorkPTosyokan.text = inputworkp[22].ToString();
                    NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.instance.Tosyokan;
                }
                else { return; }break;
            case 111:    //目星
                if ((StatusManager.instance.Meboshi < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Meboshi += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[23] += 1;
                    InputWorkPMeboshi.text = inputworkp[23].ToString();
                    NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.instance.Meboshi;
                }
                else { return; }break;

            //行動技能ステータス
            case 200:    //運転
                if ((StatusManager.instance.Unten < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Unten += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[24] += 1;
                    InputWorkPUnten.text = inputworkp[24].ToString();
                    NowUnten.text = StatusManager.instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.instance.Unten;
                }
                else { return; }break;
            case 201:    //機械修理
                if ((StatusManager.instance.Kikaisyuri < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kikaisyuri += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[25] += 1;
                    InputWorkPKikaisyuri.text = inputworkp[25].ToString();
                    NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.instance.Kikaisyuri;
                }
                else { return; }break;
            case 202:    //重機械操作
                if ((StatusManager.instance.Zyukikaisosa < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Zyukikaisosa += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[26] += 1;
                    InputWorkPZyukikaisosa.text = inputworkp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
                }
                else { return; }break;
            case 203:    //乗馬
                if ((StatusManager.instance.Zyoba < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Zyoba += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[27] += 1;
                    InputWorkPZyoba.text = inputworkp[27].ToString();
                    NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.instance.Zyoba;
                }
                else { return; }break;
            case 204:    //水泳
                if ((StatusManager.instance.Suiei < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Suiei += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[28] += 1;
                    InputWorkPSuiei.text = inputworkp[28].ToString();
                    NowSuiei.text = StatusManager.instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.instance.Suiei;
                }
                else { return; }break;
            case 205:    //制作
                if ((StatusManager.instance.Sesaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Sesaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[29] += 1;
                    InputWorkPSesaku.text = inputworkp[29].ToString();
                    NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.instance.Sesaku;
                }
                else { return; }break;
            case 206:    //操縦
                if ((StatusManager.instance.Sozyu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Sozyu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[30] += 1;
                    InputWorkPSozyu.text = inputworkp[30].ToString();
                    NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.instance.Sozyu;
                }
                else { return; }break;
            case 207:    //跳躍
                if ((StatusManager.instance.Tyoyaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Tyoyaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[31] += 1;
                    InputWorkPTyoyaku.text = inputworkp[31].ToString();
                    NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.instance.Tyoyaku;
                }
                else { return; }break;
            case 208:    //電気修理
                if ((StatusManager.instance.Denkisyuri < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Denkisyuri += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[32] += 1;
                    InputWorkPDenkisyuri.text = inputworkp[32].ToString();
                    NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.instance.Denkisyuri;
                }
                else { return; }break;
            case 209:    //ナビゲート
                if ((StatusManager.instance.Nabigeto < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Nabigeto += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[33] += 1;
                    InputWorkPNabigeto.text = inputworkp[33].ToString();
                    NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.instance.Nabigeto;
                }
                else { return; }break;
            case 210:    //変装
                if ((StatusManager.instance.Hensou < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Hensou += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[34] += 1;
                    InputWorkPHensou.text = inputworkp[34].ToString();
                    NowHensou.text = StatusManager.instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.instance.Hensou;
                }
                else { return; }break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if ((StatusManager.instance.Iikurume < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Iikurume += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[35] += 1;
                    InputWorkPIikurume.text = inputworkp[35].ToString();
                    NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.instance.Iikurume;
                }
                else { return; }break;
            case 301:    //信用
                if ((StatusManager.instance.Shinyou < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Shinyou += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[36] += 1;
                    InputWorkPShinyou.text = inputworkp[36].ToString();
                    NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.instance.Shinyou;
                }
                else { return; }break;
            case 302:    //説得
                if ((StatusManager.instance.Settoku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Settoku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[37] += 1;
                    InputWorkPSettoku.text = inputworkp[37].ToString();
                    NowSettoku.text = StatusManager.instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.instance.Settoku;
                }
                else { return; }break;
            case 303:    //値切り
                if ((StatusManager.instance.Negiri < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Negiri += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[38] += 1;
                    InputWorkPNegiri.text = inputworkp[38].ToString();
                    NowNegiri.text = StatusManager.instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.instance.Negiri;
                }
                else { return; }break;
            case 304:    //母国語
                if ((StatusManager.instance.Bokokugo < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Bokokugo += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[39] += 1;
                    InputWorkPBokokugo.text = inputworkp[39].ToString();
                    NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.instance.Bokokugo;
                }
                else { return; }break;

            //知識技能ステータス
            case 400:    //医学
                if ((StatusManager.instance.Igaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Igaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[40] += 1;
                    InputWorkPIgaku.text = inputworkp[40].ToString();
                    NowIgaku.text = StatusManager.instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.instance.Igaku;
                }
                else { return; }break;
            case 401:    //オカルト
                if ((StatusManager.instance.Okaruto < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Okaruto += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[41] += 1;
                    InputWorkPOkaruto.text = inputworkp[41].ToString();
                    NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.instance.Okaruto;
                }
                else { return; }break;
            case 402:    //化学
                if ((StatusManager.instance.Kagaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kagaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[42] += 1;
                    InputWorkPKagaku.text = inputworkp[42].ToString();
                    NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.instance.Kagaku;
                }
                else { return; }break;
            case 403:    //クトゥルフ神話
                if ((StatusManager.instance.Shinwa < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Shinwa += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[43] += 1;
                    InputWorkPShinwa.text = inputworkp[43].ToString();
                    NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.instance.Shinwa;
                }
                else { return; }break;
            case 404:    //芸術
                if ((StatusManager.instance.Gezyutsu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Gezyutsu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[44] += 1;
                    InputWorkPGezyutsu.text = inputworkp[44].ToString();
                    NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.instance.Gezyutsu;
                }
                else { return; }break;
            case 405:    //経理
                if ((StatusManager.instance.Keiri < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Keiri += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[45] += 1;
                    InputWorkPKeiri.text = inputworkp[45].ToString();
                    NowKeiri.text = StatusManager.instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.instance.Keiri;
                }
                else { return; }break;
            case 406:    //考古学
                if ((StatusManager.instance.Kokogaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Kokogaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[46] += 1;
                    InputWorkPKokogaku.text = inputworkp[46].ToString();
                    NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.instance.Kokogaku;
                }
                else { return; }break;
            case 407:    //コンピューター
                if ((StatusManager.instance.PC < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.PC += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[47] += 1;
                    InputWorkPPC.text = inputworkp[47].ToString();
                    NowPC.text = StatusManager.instance.PC.ToString();
                    Afterstatus[47] = StatusManager.instance.PC;
                }
                else { return; }break;
            case 408:    //心理学
                if ((StatusManager.instance.Shinrigaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Shinrigaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[48] += 1;
                    InputWorkPShinrigaku.text = inputworkp[48].ToString();
                    NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.instance.Shinrigaku;
                }
                else { return; }break;
            case 409:    //人類学
                if ((StatusManager.instance.Zinruigaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Zinruigaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[49] += 1;
                    InputWorkPZinruigaku.text = inputworkp[49].ToString();
                    NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.instance.Zinruigaku;
                }
                else { return; }break;
            case 410:    //生物学
                if ((StatusManager.instance.Seibutsugaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Seibutsugaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[50] += 1;
                    InputWorkPSeibutsugaku.text = inputworkp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.instance.Seibutsugaku;
                }
                else { return; }break;
            case 411:    //地質学
                if ((StatusManager.instance.Tishitsugaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Tishitsugaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[51] += 1;
                    InputWorkPTishitsugaku.text = inputworkp[51].ToString();
                    NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.instance.Tishitsugaku;
                }
                else { return; }break;
            case 412:    //電子工学
                if ((StatusManager.instance.Denshikougaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Denshikougaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[52] += 1;
                    InputWorkPDenshikougaku.text = inputworkp[52].ToString();
                    NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.instance.Denshikougaku;
                }
                else { return; }break;
            case 413:    //天文学
                if ((StatusManager.instance.Tenmongaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Tenmongaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[53] += 1;
                    InputWorkPTenmongaku.text = inputworkp[53].ToString();
                    NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.instance.Tenmongaku;
                }
                else { return; }break;
            case 414:    //博物学
                if ((StatusManager.instance.Hakubutsugaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Hakubutsugaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[54] += 1;
                    InputWorkPHakubutsugaku.text = inputworkp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
                }
                else { return; }break;
            case 415:    //物理学
                if ((StatusManager.instance.Butsurigaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Butsurigaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[55] += 1;
                    InputWorkPButsurigaku.text = inputworkp[55].ToString();
                    NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.instance.Butsurigaku;
                }
                else { return; }break;
            case 416:    //法律
                if ((StatusManager.instance.Houritsu < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Houritsu += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[56] += 1;
                    InputWorkPHouritsu.text = inputworkp[56].ToString();
                    NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.instance.Houritsu;
                }
                else { return; }break;
            case 417:    //薬学
                if ((StatusManager.instance.Yakugaku < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Yakugaku += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[57] += 1;
                    InputWorkPYakugaku.text = inputworkp[57].ToString();
                    NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.instance.Yakugaku;
                }
                else { return; }break;
            case 418:    //歴史
                if ((StatusManager.instance.Rekishi < limit) && (StatusManager.instance.WorkP != 0))
                {
                    StatusManager.instance.Rekishi += 1;
                    StatusManager.instance.WorkP -= 1;
                    inputworkp[58] += 1;
                    InputWorkPRekishi.text = inputworkp[58].ToString();
                    NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.instance.Rekishi;
                }
                else { return; }break;
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
                    StatusManager.instance.Kaihi -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[0] -= 1;
                    InputWorkPKaihi.text = inputworkp[0].ToString();
                    NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.instance.Kaihi;
                }
                else { return; }break;
            case 1:     //キック
                if (int.Parse(InputWorkPKikku.text) > 0)
                {
                    StatusManager.instance.Kikku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[1] -= 1;
                    InputWorkPKikku.text = inputworkp[1].ToString();
                    NowKikku.text = StatusManager.instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.instance.Kikku;
                }
                else { return; }break;
            case 2:     //組み付き
                if (int.Parse(InputWorkPKumitsuki.text) > 0)
                {
                    StatusManager.instance.Kumitsuki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[2] -= 1;
                    InputWorkPKumitsuki.text = inputworkp[2].ToString();
                    NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.instance.Kumitsuki;
                }
                else { return; }break;
            case 3:     //こぶし
                if (int.Parse(InputWorkPKobushi.text) > 0)
                {
                    StatusManager.instance.Kobushi -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[3] -= 1;
                    InputWorkPKobushi.text = inputworkp[3].ToString();
                    NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.instance.Kobushi;
                }
                else { return; }break;
            case 4:     //頭突き
                if (int.Parse(InputWorkPZutsuki.text) > 0)
                {
                    StatusManager.instance.Zutsuki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[4] -= 1;
                    InputWorkPZutsuki.text = inputworkp[4].ToString();
                    NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.instance.Zutsuki;
                }
                else { return; }break;
            case 5:     //投擲
                if (int.Parse(InputWorkPToteki.text) > 0)
                {
                    StatusManager.instance.Toteki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[5] -= 1;
                    InputWorkPToteki.text = inputworkp[5].ToString();
                    NowToteki.text = StatusManager.instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.instance.Toteki;
                }
                else { return; }break;
            case 6:     //マーシャルアーツ
                if (int.Parse(InputWorkPMSA.text) > 0)
                {
                    StatusManager.instance.MSA -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[6] -= 1;
                    InputWorkPMSA.text = inputworkp[6].ToString();
                    NowMSA.text = StatusManager.instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.instance.MSA;
                }
                else { return; }break;
            case 7:     //拳銃
                if (int.Parse(InputWorkPKenzyu.text) > 0)
                {
                    StatusManager.instance.Kenzyu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[7] -= 1;
                    InputWorkPKenzyu.text = inputworkp[7].ToString();
                    NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.instance.Kenzyu;
                }
                else { return; }break;
            case 8:     //サブマシンガン
                if (int.Parse(InputWorkPSMG.text) > 0)
                {
                    StatusManager.instance.SMG -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[8] -= 1;
                    InputWorkPSMG.text = inputworkp[8].ToString();
                    NowSMG.text = StatusManager.instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.instance.SMG;
                }
                else { return; }break;
            case 9:     //ショットガン
                if (int.Parse(InputWorkPSG.text) > 0)
                {
                    StatusManager.instance.SG -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[9] -= 1;
                    InputWorkPSG.text = inputworkp[9].ToString();
                    NowSG.text = StatusManager.instance.SG.ToString();
                    Afterstatus[9] = StatusManager.instance.SG;
                }
                else { return; }break;
            case 10:    //マシンガン
                if (int.Parse(InputWorkPMG.text) > 0)
                {
                    StatusManager.instance.MG -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[10] -= 1;
                    InputWorkPMG.text = inputworkp[10].ToString();
                    NowMG.text = StatusManager.instance.MG.ToString();
                    Afterstatus[10] = StatusManager.instance.MG;
                }
                else { return; }break;
            case 11:    //ライフル
                if (int.Parse(InputWorkPR.text) > 0)
                {
                    StatusManager.instance.R -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[11] -= 1;
                    InputWorkPR.text = inputworkp[11].ToString();
                    NowR.text = StatusManager.instance.R.ToString();
                    Afterstatus[11] = StatusManager.instance.R;
                }
                else { return; }break;

            //探索技能ステータス
            case 100:    //応急手当
                if (int.Parse(InputWorkPOkyuteate.text) > 0)
                {
                    StatusManager.instance.Okyuteate -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[12] -= 1;
                    InputWorkPOkyuteate.text = inputworkp[12].ToString();
                    NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.instance.Okyuteate;
                }
                else { return; }break;
            case 101:    //鍵開け
                if (int.Parse(InputWorkPKagiake.text) > 0)
                {
                    StatusManager.instance.Kagiake -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[13] -= 1;
                    InputWorkPKagiake.text = inputworkp[13].ToString();
                    NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.instance.Kagiake;
                }
                else { return; }break;
            case 102:    //隠す
                if (int.Parse(InputWorkPKakusu.text) > 0)
                {
                    StatusManager.instance.Kakusu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[14] -= 1;
                    InputWorkPKakusu.text = inputworkp[14].ToString();
                    NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.instance.Kakusu;
                }
                else { return; }break;
            case 103:    //隠れる
                if (int.Parse(InputWorkPKakureru.text) > 0)
                {
                    StatusManager.instance.Kakureru -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[15] -= 1;
                    InputWorkPKakureru.text = inputworkp[15].ToString();
                    NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.instance.Kakureru;
                }
                else { return; }break;
            case 104:    //聞き耳
                if (int.Parse(InputWorkPKikimimi.text) > 0)
                {
                    StatusManager.instance.Kikimimi -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[16] -= 1;
                    InputWorkPKikimimi.text = inputworkp[16].ToString();
                    NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.instance.Kikimimi;
                }
                else { return; }break;
            case 105:    //忍び歩き
                if (int.Parse(InputWorkPShinobiaruki.text) > 0)
                {
                    StatusManager.instance.Shinobiaruki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[17] -= 1;
                    InputWorkPShinobiaruki.text = inputworkp[17].ToString();
                    NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.instance.Shinobiaruki;
                }
                else { return; }break;
            case 106:    //写真術
                if (int.Parse(InputWorkPSyashinzyutsu.text) > 0)
                {
                    StatusManager.instance.Syashinzyutsu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[18] -= 1;
                    InputWorkPSyashinzyutsu.text = inputworkp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
                }
                else { return; }break;
            case 107:    //精神分析
                if (int.Parse(InputWorkPSeshinbunseki.text) > 0)
                {
                    StatusManager.instance.Seshinbunseki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[19] -= 1;
                    InputWorkPSeshinbunseki.text = inputworkp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.instance.Seshinbunseki;
                }
                else { return; }break;
            case 108:    //追跡
                if (int.Parse(InputWorkPTsuiseki.text) > 0)
                {
                    StatusManager.instance.Tsuiseki -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[20] -= 1;
                    InputWorkPTsuiseki.text = inputworkp[20].ToString();
                    NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.instance.Tsuiseki;
                }
                else { return; }break;
            case 109:    //登攀
                if (int.Parse(InputWorkPTouhan.text) > 0)
                {
                    StatusManager.instance.Touhan -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[21] -= 1;
                    InputWorkPTouhan.text = inputworkp[21].ToString();
                    NowTouhan.text = StatusManager.instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.instance.Touhan;
                }
                else { return; }break;
            case 110:    //図書館
                if (int.Parse(InputWorkPTosyokan.text) > 0)
                {
                    StatusManager.instance.Tosyokan -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[22] -= 1;
                    InputWorkPTosyokan.text = inputworkp[22].ToString();
                    NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.instance.Tosyokan;
                }
                else { return; }break;
            case 111:    //目星
                if (int.Parse(InputWorkPMeboshi.text) > 0)
                {
                    StatusManager.instance.Meboshi -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[23] -= 1;
                    InputWorkPMeboshi.text = inputworkp[23].ToString();
                    NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.instance.Meboshi;
                }
                else { return; }break;

            //行動技能ステータス
            case 200:    //運転
                if (int.Parse(InputWorkPUnten.text) > 0)
                {
                    StatusManager.instance.Unten -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[24] -= 1;
                    InputWorkPUnten.text = inputworkp[24].ToString();
                    NowUnten.text = StatusManager.instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.instance.Unten;
                }
                else { return; }break;
            case 201:    //機械修理
                if (int.Parse(InputWorkPKikaisyuri.text) > 0)
                {
                    StatusManager.instance.Kikaisyuri -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[25] -= 1;
                    InputWorkPKikaisyuri.text = inputworkp[25].ToString();
                    NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.instance.Kikaisyuri;
                }
                else { return; }break;
            case 202:    //重機械操作
                if (int.Parse(InputWorkPZyukikaisosa.text) > 0)
                {
                    StatusManager.instance.Zyukikaisosa -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[26] -= 1;
                    InputWorkPZyukikaisosa.text = inputworkp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
                }
                else { return; }break;
            case 203:    //乗馬
                if (int.Parse(InputWorkPZyoba.text) > 0)
                {
                    StatusManager.instance.Zyoba -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[27] -= 1;
                    InputWorkPZyoba.text = inputworkp[27].ToString();
                    NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.instance.Zyoba;
                }
                else { return; }break;
            case 204:    //水泳
                if (int.Parse(InputWorkPSuiei.text) > 0)
                {
                    StatusManager.instance.Suiei -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[28] -= 1;
                    InputWorkPSuiei.text = inputworkp[28].ToString();
                    NowSuiei.text = StatusManager.instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.instance.Suiei;
                }
                else { return; }break;
            case 205:    //制作
                if (int.Parse(InputWorkPSesaku.text) > 0)
                {
                    StatusManager.instance.Sesaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[29] -= 1;
                    InputWorkPSesaku.text = inputworkp[29].ToString();
                    NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.instance.Sesaku;
                }
                else { return; }break;
            case 206:    //操縦
                if (int.Parse(InputWorkPSozyu.text) > 0)
                {
                    StatusManager.instance.Sozyu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[30] -= 1;
                    InputWorkPSozyu.text = inputworkp[30].ToString();
                    NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.instance.Sozyu;
                }
                else { return; }break;
            case 207:    //跳躍
                if (int.Parse(InputWorkPTyoyaku.text) > 0)
                {
                    StatusManager.instance.Tyoyaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[31] -= 1;
                    InputWorkPTyoyaku.text = inputworkp[31].ToString();
                    NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.instance.Tyoyaku;
                }
                else { return; }break;
            case 208:    //電気修理
                if (int.Parse(InputWorkPDenkisyuri.text) > 0)
                {
                    StatusManager.instance.Denkisyuri -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[32] -= 1;
                    InputWorkPDenkisyuri.text = inputworkp[32].ToString();
                    NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.instance.Denkisyuri;
                }
                else { return; }break;
            case 209:    //ナビゲート
                if (int.Parse(InputWorkPNabigeto.text) > 0)
                {
                    StatusManager.instance.Nabigeto -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[33] -= 1;
                    InputWorkPNabigeto.text = inputworkp[33].ToString();
                    NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.instance.Nabigeto;
                }
                else { return; }break;
            case 210:    //変装
                if (int.Parse(InputWorkPHensou.text) > 0)
                {
                    StatusManager.instance.Hensou -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[34] -= 1;
                    InputWorkPHensou.text = inputworkp[34].ToString();
                    NowHensou.text = StatusManager.instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.instance.Hensou;
                }
                else { return; }break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if (int.Parse(InputWorkPIikurume.text) > 0)
                {
                    StatusManager.instance.Iikurume -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[35] -= 1;
                    InputWorkPIikurume.text = inputworkp[35].ToString();
                    NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.instance.Iikurume;
                }
                else { return; }break;
            case 301:    //信用
                if (int.Parse(InputWorkPShinyou.text) > 0)
                {
                    StatusManager.instance.Shinyou -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[36] -= 1;
                    InputWorkPShinyou.text = inputworkp[36].ToString();
                    NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.instance.Shinyou;
                }
                else { return; }break;
            case 302:    //説得
                if (int.Parse(InputWorkPSettoku.text) > 0)
                {
                    StatusManager.instance.Settoku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[37] -= 1;
                    InputWorkPSettoku.text = inputworkp[37].ToString();
                    NowSettoku.text = StatusManager.instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.instance.Settoku;
                }
                else { return; }break;
            case 303:    //値切り
                if (int.Parse(InputWorkPNegiri.text) > 0)
                {
                    StatusManager.instance.Negiri -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[38] -= 1;
                    InputWorkPNegiri.text = inputworkp[38].ToString();
                    NowNegiri.text = StatusManager.instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.instance.Negiri;
                }
                else { return; }break;
            case 304:    //母国語
                if (int.Parse(InputWorkPBokokugo.text) > 0)
                {
                    StatusManager.instance.Bokokugo -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[39] -= 1;
                    InputWorkPBokokugo.text = inputworkp[39].ToString();
                    NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.instance.Bokokugo;
                }
                else { return; }break;

            //知識技能ステータス
            case 400:    //医学
                if (int.Parse(InputWorkPIgaku.text) > 0)
                {
                    StatusManager.instance.Igaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[40] -= 1;
                    InputWorkPIgaku.text = inputworkp[40].ToString();
                    NowIgaku.text = StatusManager.instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.instance.Igaku;
                }
                else { return; }break;
            case 401:    //オカルト
                if (int.Parse(InputWorkPOkaruto.text) > 0)
                {
                    StatusManager.instance.Okaruto -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[41] -= 1;
                    InputWorkPOkaruto.text = inputworkp[41].ToString();
                    NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.instance.Okaruto;
                }
                else { return; }break;
            case 402:    //化学
                if (int.Parse(InputWorkPKagaku.text) > 0)
                {
                    StatusManager.instance.Kagaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[42] -= 1;
                    InputWorkPKagaku.text = inputworkp[42].ToString();
                    NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.instance.Kagaku;
                }
                else { return; }break;
            case 403:    //クトゥルフ神話
                if (int.Parse(InputWorkPShinwa.text) > 0)
                {
                    StatusManager.instance.Shinwa -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[43] -= 1;
                    InputWorkPShinwa.text = inputworkp[43].ToString();
                    NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.instance.Shinwa;
                }
                else { return; }break;
            case 404:    //芸術
                if (int.Parse(InputWorkPGezyutsu.text) > 0)
                {
                    StatusManager.instance.Gezyutsu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[44] -= 1;
                    InputWorkPGezyutsu.text = inputworkp[44].ToString();
                    NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.instance.Gezyutsu;
                }
                else { return; }break;
            case 405:    //経理
                if (int.Parse(InputWorkPKeiri.text) > 0)
                {
                    StatusManager.instance.Keiri -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[45] -= 1;
                    InputWorkPKeiri.text = inputworkp[45].ToString();
                    NowKeiri.text = StatusManager.instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.instance.Keiri;
                }
                else { return; }break;
            case 406:    //考古学
                if (int.Parse(InputWorkPKokogaku.text) > 0)
                {
                    StatusManager.instance.Kokogaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[46] -= 1;
                    InputWorkPKokogaku.text = inputworkp[46].ToString();
                    NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.instance.Kokogaku
                        ;
                }
                else { return; }break;
            case 407:    //コンピューター
                if (int.Parse(InputWorkPPC.text) > 0)
                {
                    StatusManager.instance.PC -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[47] -= 1;
                    InputWorkPPC.text = inputworkp[47].ToString();
                    NowPC.text = StatusManager.instance.PC.ToString();
                    Afterstatus[47] = StatusManager.instance.PC;
                }
                else { return; }break;
            case 408:    //心理学
                if (int.Parse(InputWorkPShinrigaku.text) > 0)
                {
                    StatusManager.instance.Shinrigaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[48] -= 1;
                    InputWorkPShinrigaku.text = inputworkp[48].ToString();
                    NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.instance.Shinrigaku;
                }
                else { return; }break;
            case 409:    //人類学
                if (int.Parse(InputWorkPZinruigaku.text) > 0)
                {
                    StatusManager.instance.Zinruigaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[49] -= 1;
                    InputWorkPZinruigaku.text = inputworkp[149].ToString();
                    NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.instance.Zinruigaku;
                }
                else { return; }break;
            case 410:    //生物学
                if (int.Parse(InputWorkPSeibutsugaku.text) > 0)
                {
                    StatusManager.instance.Seibutsugaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[50] -= 1;
                    InputWorkPSeibutsugaku.text = inputworkp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.instance.Seibutsugaku;
                }
                else { return; }break;
            case 411:    //地質学
                if (int.Parse(InputWorkPTishitsugaku.text) > 0)
                {
                    StatusManager.instance.Tishitsugaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[51] -= 1;
                    InputWorkPTishitsugaku.text = inputworkp[51].ToString();
                    NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.instance.Tishitsugaku;
                }
                else { return; }break;
            case 412:    //電子工学
                if (int.Parse(InputWorkPDenshikougaku.text) > 0)
                {
                    StatusManager.instance.Denshikougaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[52] -= 1;
                    InputWorkPDenshikougaku.text = inputworkp[52].ToString();
                    NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.instance.Denshikougaku;
                }
                else { return; }break;
            case 413:    //天文学
                if (int.Parse(InputWorkPTenmongaku.text) > 0)
                {
                    StatusManager.instance.Tenmongaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[53] -= 1;
                    InputWorkPTenmongaku.text = inputworkp[53].ToString();
                    NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.instance.Tenmongaku;
                }
                else { return; }break;
            case 414:    //博物学
                if (int.Parse(InputWorkPHakubutsugaku.text) > 0)
                {
                    StatusManager.instance.Hakubutsugaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[54] -= 1;
                    InputWorkPHakubutsugaku.text = inputworkp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
                }
                else { return; }break;
            case 415:    //物理学
                if (int.Parse(InputWorkPButsurigaku.text) > 0)
                {
                    StatusManager.instance.Butsurigaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    InputWorkPButsurigaku.text = inputworkp[55].ToString();
                    inputworkp[55] = StatusManager.instance.Butsurigaku;
                    NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.instance.Butsurigaku;
                }
                else { return; }break;
            case 416:    //法律
                if (int.Parse(InputWorkPHouritsu.text) > 0)
                {
                    StatusManager.instance.Houritsu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[56] -= 1;
                    InputWorkPHouritsu.text = inputworkp[56].ToString();
                    NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.instance.Houritsu;
                }
                else { return; }break;
            case 417:    //薬学
                if (int.Parse(InputWorkPYakugaku.text) > 0)
                {
                    StatusManager.instance.Yakugaku -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[57] -= 1;
                    InputWorkPYakugaku.text = inputworkp[57].ToString();
                    NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.instance.Yakugaku;
                }
                else { return; }break;
            case 418:    //歴史
                if (int.Parse(InputWorkPRekishi.text) > 0)
                {
                    StatusManager.instance.Rekishi -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputworkp[58] -= 1;
                    InputWorkPRekishi.text = inputworkp[58].ToString();
                    NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.instance.Rekishi;
                }
                else { return; }break;
        }
    }

    //趣味技能ポイント振り分けUPボタン
    public void UpHobbyP(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:     //回避
                if ((StatusManager.instance.Kaihi < limit)&&(StatusManager.instance.HobbyP!=0))
                {
                    StatusManager.instance.Kaihi += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[0] += 1;
                    InputHobbyPKaihi.text = inputhobbyp[0].ToString();
                    NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.instance.Kaihi;
                }
                else { return; }break;
            case 1:     //キック
                if ((StatusManager.instance.Kikku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kikku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[1] += 1;
                    InputHobbyPKikku.text = inputhobbyp[1].ToString();
                    NowKikku.text = StatusManager.instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.instance.Kikku;
                }
                else { return; }break;
            case 2:     //組み付き
                if ((StatusManager.instance.Kumitsuki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kumitsuki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[2] += 1;
                    InputHobbyPKumitsuki.text = inputhobbyp[2].ToString();
                    NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.instance.Kumitsuki;
                }
                else { return; }break;
            case 3:     //こぶし
                if ((StatusManager.instance.Kobushi < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kobushi += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[3] += 1;
                    InputHobbyPKobushi.text = inputhobbyp[3].ToString();
                    NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.instance.Kobushi;
                }
                else { return; }break;
            case 4:     //頭突き
                if ((StatusManager.instance.Zutsuki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Zutsuki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[4] += 1;
                    InputHobbyPZutsuki.text = inputhobbyp[4].ToString();
                    NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.instance.Zutsuki;
                }
                else { return; }break;
            case 5:     //投擲
                if ((StatusManager.instance.Toteki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Toteki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[5] += 1;
                    InputHobbyPToteki.text = inputhobbyp[5].ToString();
                    NowToteki.text = StatusManager.instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.instance.Toteki;
                }
                else { return; }break;
            case 6:     //マーシャルアーツ
                if ((StatusManager.instance.MSA < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.MSA += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[6] += 1;
                    InputHobbyPMSA.text = inputhobbyp[6].ToString();
                    NowMSA.text = StatusManager.instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.instance.MSA;
                }
                else { return; }break;
            case 7:     //拳銃
                if ((StatusManager.instance.Kenzyu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kenzyu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[7] += 1;
                    InputHobbyPKenzyu.text = inputhobbyp[7].ToString();
                    NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.instance.Kenzyu;
                }
                else { return; }break;
            case 8:     //サブマシンガン
                if ((StatusManager.instance.SMG < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.SMG += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[8] += 1;
                    InputHobbyPSMG.text = inputhobbyp[8].ToString();
                    NowSMG.text = StatusManager.instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.instance.SMG;
                }
                else { return; }break;
            case 9:     //ショットガン
                if ((StatusManager.instance.SG < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.SG += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[9] += 1;
                    InputHobbyPSG.text = inputhobbyp[9].ToString();
                    NowSG.text = StatusManager.instance.SG.ToString();
                    Afterstatus[9] = StatusManager.instance.SG;
                }
                else { return; }break;
            case 10:    //マシンガン
                if ((StatusManager.instance.MG < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.MG += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[10] += 1;
                    InputHobbyPMG.text = inputhobbyp[10].ToString();
                    NowMG.text = StatusManager.instance.MG.ToString();
                    Afterstatus[10] = StatusManager.instance.MG;
                }
                else { return; }break;
            case 11:    //ライフル
                if ((StatusManager.instance.R < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.R += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[11] += 1;
                    InputHobbyPR.text = inputhobbyp[11].ToString();
                    NowR.text = StatusManager.instance.R.ToString();
                    Afterstatus[11] = StatusManager.instance.R;
                }
                else { return; }break;

            //探索技能ステータス
            case 100:    //応急手当
                if ((StatusManager.instance.Okyuteate < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Okyuteate += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[12] += 1;
                    InputHobbyPOkyuteate.text = inputhobbyp[12].ToString();
                    NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.instance.Okyuteate;
                }
                else { return; }break;
            case 101:    //鍵開け
                if ((StatusManager.instance.Kagiake < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kagiake += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[13] += 1;
                    InputHobbyPKagiake.text = inputhobbyp[14].ToString();
                    NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.instance.Kagiake;
                }
                else { return; }break;
            case 102:    //隠す
                if ((StatusManager.instance.Kakusu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kakusu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[14] += 1;
                    InputHobbyPKakusu.text = inputhobbyp[14].ToString();
                    NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.instance.Kakusu;
                }
                else { return; }break;
            case 103:    //隠れる
                if ((StatusManager.instance.Kakureru < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kakureru += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[15] += 1;
                    InputHobbyPKakureru.text = inputhobbyp[15].ToString();
                    NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.instance.Kakureru;
                }
                else { return; }break;
            case 104:    //聞き耳
                if ((StatusManager.instance.Kikimimi < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kikimimi += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[16] += 1;
                    InputHobbyPKikimimi.text = inputhobbyp[16].ToString();
                    NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.instance.Kikimimi;
                }
                else { return; }break;
            case 105:    //忍び歩き
                if ((StatusManager.instance.Shinobiaruki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Shinobiaruki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[17] += 1;
                    InputHobbyPShinobiaruki.text = inputhobbyp[17].ToString();
                    NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.instance.Shinobiaruki;
                }
                else { return; }break;
            case 106:    //写真術
                if ((StatusManager.instance.Syashinzyutsu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Syashinzyutsu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[18] += 1;
                    InputHobbyPSyashinzyutsu.text = inputhobbyp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
                }
                else { return; }break;
            case 107:    //精神分析
                if ((StatusManager.instance.Seshinbunseki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Seshinbunseki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[19] += 1;
                    InputHobbyPSeshinbunseki.text = inputhobbyp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.instance.Seshinbunseki;
                }
                else { return; }break;
            case 108:    //追跡
                if ((StatusManager.instance.Tsuiseki < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Tsuiseki += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[20] += 1;
                    InputHobbyPTsuiseki.text = inputhobbyp[20].ToString();
                    NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.instance.Tsuiseki;
                }
                else { return; }break;
            case 109:    //登攀
                if ((StatusManager.instance.Touhan < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Touhan += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[21] += 1;
                    InputHobbyPTouhan.text = inputhobbyp[21].ToString();
                    NowTouhan.text = StatusManager.instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.instance.Touhan;
                }
                else { return; }break;
            case 110:    //図書館
                if ((StatusManager.instance.Tosyokan < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Tosyokan += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[22] += 1;
                    InputHobbyPTosyokan.text = inputhobbyp[22].ToString();
                    NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.instance.Tosyokan;
                }
                else { return; }break;
            case 111:    //目星
                if ((StatusManager.instance.Meboshi < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Meboshi += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[23] += 1;
                    InputHobbyPMeboshi.text = inputhobbyp[23].ToString();
                    NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.instance.Meboshi;
                }
                else { return; }break;

            //行動技能ステータス
            case 200:    //運転
                if ((StatusManager.instance.Unten < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Unten += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[24] += 1;
                    InputHobbyPUnten.text = inputhobbyp[24].ToString();
                    NowUnten.text = StatusManager.instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.instance.Unten;
                }
                else { return; }break;
            case 201:    //機械修理
                if ((StatusManager.instance.Kikaisyuri < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kikaisyuri += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[25] += 1;
                    InputHobbyPKikaisyuri.text = inputhobbyp[25].ToString();
                    NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.instance.Kikaisyuri;
                }
                else { return; }break;
            case 202:    //重機械操作
                if ((StatusManager.instance.Zyukikaisosa < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Zyukikaisosa += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[26] += 1;
                    InputHobbyPZyukikaisosa.text = inputhobbyp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
                }
                else { return; }break;
            case 203:    //乗馬
                if ((StatusManager.instance.Zyoba < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Zyoba += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[27] += 1;
                    InputHobbyPZyoba.text = inputhobbyp[27].ToString();
                    NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.instance.Zyoba;
                }
                else { return; }break;
            case 204:    //水泳
                if ((StatusManager.instance.Suiei < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Suiei += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[28] += 1;
                    InputHobbyPSuiei.text = inputhobbyp[28].ToString();
                    NowSuiei.text = StatusManager.instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.instance.Suiei;
                }
                else { return; }break;
            case 205:    //制作
                if ((StatusManager.instance.Sesaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Sesaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[29] += 1;
                    InputHobbyPSesaku.text = inputhobbyp[29].ToString();
                    NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.instance.Sesaku;
                }
                else { return; }break;
            case 206:    //操縦
                if ((StatusManager.instance.Sozyu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Sozyu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[30] += 1;
                    InputHobbyPSozyu.text = inputhobbyp[30].ToString();
                    NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.instance.Sozyu;
                }
                else { return; }break;
            case 207:    //跳躍
                if ((StatusManager.instance.Tyoyaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Tyoyaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[31] += 1;
                    InputHobbyPTyoyaku.text = inputhobbyp[31].ToString();
                    NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.instance.Tyoyaku;
                }
                else { return; }break;
            case 208:    //電気修理
                if ((StatusManager.instance.Denkisyuri < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Denkisyuri += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[32] += 1;
                    InputHobbyPDenkisyuri.text = inputhobbyp[32].ToString();
                    NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.instance.Denkisyuri;
                }
                else { return; }break;
            case 209:    //ナビゲート
                if ((StatusManager.instance.Nabigeto < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Nabigeto += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[33] += 1;
                    InputHobbyPNabigeto.text = inputhobbyp[33].ToString();
                    NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.instance.Nabigeto;
                }
                else { return; }break;
            case 210:    //変装
                if ((StatusManager.instance.Hensou < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Hensou += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[34] += 1;
                    InputHobbyPHensou.text = inputhobbyp[34].ToString();
                    NowHensou.text = StatusManager.instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.instance.Hensou;
                }
                else { return; }break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if ((StatusManager.instance.Iikurume < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Iikurume += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[35] += 1;
                    InputHobbyPIikurume.text = inputhobbyp[35].ToString();
                    NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.instance.Iikurume;
                }
                else { return; }break;
            case 301:    //信用
                if ((StatusManager.instance.Shinyou < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Shinyou += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[36] += 1;
                    InputHobbyPShinyou.text = inputhobbyp[36].ToString();
                    NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.instance.Shinyou;
                }
                else { return; }break;
            case 302:    //説得
                if ((StatusManager.instance.Settoku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Settoku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[37] += 1;
                    InputHobbyPSettoku.text = inputhobbyp[37].ToString();
                    NowSettoku.text = StatusManager.instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.instance.Settoku;
                }
                else { return; }break;
            case 303:    //値切り
                if ((StatusManager.instance.Negiri < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Negiri += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[38] += 1;
                    InputHobbyPNegiri.text = inputhobbyp[38].ToString();
                    NowNegiri.text = StatusManager.instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.instance.Negiri;
                }
                else { return; }break;
            case 304:    //母国語
                if ((StatusManager.instance.Bokokugo < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Bokokugo += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[39] += 1;
                    InputHobbyPBokokugo.text = inputhobbyp[39].ToString();
                    NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.instance.Bokokugo;
                }
                else { return; }break;

            //知識技能ステータス
            case 400:    //医学
                if ((StatusManager.instance.Igaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Igaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[40] += 1;
                    InputHobbyPIgaku.text = inputhobbyp[40].ToString();
                    NowIgaku.text = StatusManager.instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.instance.Igaku;
                }
                else { return; }break;
            case 401:    //オカルト
                if ((StatusManager.instance.Okaruto < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Okaruto += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[41] += 1;
                    InputHobbyPOkaruto.text = inputhobbyp[41].ToString();
                    NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.instance.Okaruto;
                }
                else { return; }break;
            case 402:    //化学
                if ((StatusManager.instance.Kagaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kagaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[42] += 1;
                    InputHobbyPKagaku.text = inputhobbyp[42].ToString();
                    NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.instance.Kagaku;
                }
                else { return; }break;
            case 403:    //クトゥルフ神話
                if ((StatusManager.instance.Shinwa < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Shinwa += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[43] += 1;
                    InputHobbyPShinwa.text = inputhobbyp[43].ToString();
                    NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.instance.Shinwa;
                }
                else { return; }break;
            case 404:    //芸術
                if ((StatusManager.instance.Gezyutsu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Gezyutsu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[44] += 1;
                    InputHobbyPGezyutsu.text = inputhobbyp[44].ToString();
                    NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.instance.Gezyutsu;
                }
                else { return; }break;
            case 405:    //経理
                if ((StatusManager.instance.Keiri < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Keiri += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[45] += 1;
                    InputHobbyPKeiri.text = inputhobbyp[45].ToString();
                    NowKeiri.text = StatusManager.instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.instance.Keiri;
                }
                else { return; }break;
            case 406:    //考古学
                if ((StatusManager.instance.Kokogaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Kokogaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[46] += 1;
                    InputHobbyPKokogaku.text = inputhobbyp[46].ToString();
                    NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.instance.Kokogaku;
                }
                else { return; }break;
            case 407:    //コンピューター
                if ((StatusManager.instance.PC < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.PC += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[47] += 1;
                    InputHobbyPPC.text = inputhobbyp[47].ToString();
                    NowPC.text = StatusManager.instance.PC.ToString();
                    Afterstatus[47] = StatusManager.instance.PC;
                }
                else { return; }break;
            case 408:    //心理学
                if ((StatusManager.instance.Shinrigaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Shinrigaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[48] += 1;
                    InputHobbyPShinrigaku.text = inputhobbyp[48].ToString();
                    NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.instance.Shinrigaku;
                }
                else { return; }break;
            case 409:    //人類学
                if ((StatusManager.instance.Zinruigaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Zinruigaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[49] += 1;
                    InputHobbyPZinruigaku.text = inputhobbyp[49].ToString();
                    NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.instance.Zinruigaku;
                }
                else { return; }break;
            case 410:    //生物学
                if ((StatusManager.instance.Seibutsugaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Seibutsugaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[50] += 1;
                    InputHobbyPSeibutsugaku.text = inputhobbyp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.instance.Seibutsugaku;
                }
                else { return; }break;
            case 411:    //地質学
                if ((StatusManager.instance.Tishitsugaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Tishitsugaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[51] += 1;
                    InputHobbyPTishitsugaku.text = inputhobbyp[51].ToString();
                    NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.instance.Tishitsugaku;
                }
                else { return; }break;
            case 412:    //電子工学
                if ((StatusManager.instance.Denshikougaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Denshikougaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[52] += 1;
                    InputHobbyPDenshikougaku.text = inputhobbyp[52].ToString();
                    NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.instance.Denshikougaku;
                }
                else { return; }break;
            case 413:    //天文学
                if ((StatusManager.instance.Tenmongaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Tenmongaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[53] += 1;
                    InputHobbyPTenmongaku.text = inputhobbyp[53].ToString();
                    NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.instance.Tenmongaku;
                }
                else { return; }break;
            case 414:    //博物学
                if ((StatusManager.instance.Hakubutsugaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Hakubutsugaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[54] += 1;
                    InputHobbyPHakubutsugaku.text = inputhobbyp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
                }
                else { return; }break;
            case 415:    //物理学
                if ((StatusManager.instance.Butsurigaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Butsurigaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[55] += 1;
                    InputHobbyPButsurigaku.text = inputhobbyp[55].ToString();
                    NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.instance.Butsurigaku;
                }
                else { return; }break;
            case 416:    //法律
                if ((StatusManager.instance.Houritsu < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Houritsu += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[56] += 1;
                    InputHobbyPHouritsu.text = inputhobbyp[56].ToString();
                    NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.instance.Houritsu;
                }
                else { return; }break;
            case 417:    //薬学
                if ((StatusManager.instance.Yakugaku < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Yakugaku += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[57] += 1;
                    InputHobbyPYakugaku.text = inputhobbyp[57].ToString();
                    NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.instance.Yakugaku;
                }
                else { return; }break;
            case 418:    //歴史
                if ((StatusManager.instance.Rekishi < limit) && (StatusManager.instance.HobbyP != 0))
                {
                    StatusManager.instance.Rekishi += 1;
                    StatusManager.instance.HobbyP -= 1;
                    inputhobbyp[58] += 1;
                    InputHobbyPRekishi.text = inputhobbyp[58].ToString();
                    NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.instance.Rekishi;
                }
                else { return; }break;
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
                    StatusManager.instance.Kaihi -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[0] -= 1;
                    InputHobbyPKaihi.text = inputhobbyp[0].ToString();
                    NowKaihi.text = StatusManager.instance.Kaihi.ToString();
                    Afterstatus[0] = StatusManager.instance.Kaihi;
                }
                else { return; }break;
            case 1:     //キック
                if (int.Parse(InputHobbyPKikku.text) > 0)
                {
                    StatusManager.instance.Kikku -= 1;
                    inputhobbyp[1] -= 1;
                    InputHobbyPKikku.text = inputhobbyp[1].ToString();
                    NowKikku.text = StatusManager.instance.Kikku.ToString();
                    Afterstatus[1] = StatusManager.instance.Kikku;
                }
                else { return; }break;
            case 2:     //組み付き
                if (int.Parse(InputHobbyPKumitsuki.text) > 0)
                {
                    StatusManager.instance.Kumitsuki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[2] -= 1;
                    InputHobbyPKumitsuki.text = inputhobbyp[2].ToString();
                    NowKumitsuki.text = StatusManager.instance.Kumitsuki.ToString();
                    Afterstatus[2] = StatusManager.instance.Kumitsuki;
                }
                else { return; }break;
            case 3:     //こぶし
                if (int.Parse(InputHobbyPKobushi.text) > 0)
                {
                    StatusManager.instance.Kobushi -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[3] -= 1;
                    InputHobbyPKobushi.text = inputhobbyp[3].ToString();
                    NowKobushi.text = StatusManager.instance.Kobushi.ToString();
                    Afterstatus[3] = StatusManager.instance.Kobushi;
                }
                else { return; }break;
            case 4:     //頭突き
                if (int.Parse(InputHobbyPZutsuki.text) > 0)
                {
                    StatusManager.instance.Zutsuki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[4] -= 1;
                    InputHobbyPZutsuki.text = inputhobbyp[4].ToString();
                    NowZutsuki.text = StatusManager.instance.Zutsuki.ToString();
                    Afterstatus[4] = StatusManager.instance.Zutsuki;
                }
                else { return; }break;
            case 5:     //投擲
                if (int.Parse(InputHobbyPToteki.text) > 0)
                {
                    StatusManager.instance.Toteki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[5] -= 1;
                    InputHobbyPToteki.text = inputhobbyp[5].ToString();
                    NowToteki.text = StatusManager.instance.Toteki.ToString();
                    Afterstatus[5] = StatusManager.instance.Toteki;
                }
                else { return; }break;
            case 6:     //マーシャルアーツ
                if (int.Parse(InputHobbyPMSA.text) > 0)
                {
                    StatusManager.instance.MSA -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[6] -= 1;
                    InputHobbyPMSA.text = inputhobbyp[6].ToString();
                    NowMSA.text = StatusManager.instance.MSA.ToString();
                    Afterstatus[6] = StatusManager.instance.MSA;
                }
                else { return; }break;
            case 7:     //拳銃
                if (int.Parse(InputHobbyPKenzyu.text) > 0)
                {
                    StatusManager.instance.Kenzyu -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[7] -= 1;
                    InputHobbyPKenzyu.text = inputhobbyp[7].ToString();
                    NowKenzyu.text = StatusManager.instance.Kenzyu.ToString();
                    Afterstatus[7] = StatusManager.instance.Kenzyu;
                }
                else { return; }break;
            case 8:     //サブマシンガン
                if (int.Parse(InputHobbyPSMG.text) > 0)
                {
                    StatusManager.instance.SMG -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[8] -= 1;
                    InputHobbyPSMG.text = inputhobbyp[8].ToString();
                    NowSMG.text = StatusManager.instance.SMG.ToString();
                    Afterstatus[8] = StatusManager.instance.SMG;
                }
                else { return; }break;
            case 9:     //ショットガン
                if (int.Parse(InputHobbyPSG.text) > 0)
                {
                    StatusManager.instance.SG -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[9] -= 1;
                    InputHobbyPSG.text = inputhobbyp[9].ToString();
                    NowSG.text = StatusManager.instance.SG.ToString();
                    Afterstatus[9] = StatusManager.instance.SG;
                }
                else { return; }break;
            case 10:    //マシンガン
                if (int.Parse(InputHobbyPMG.text) > 0)
                {
                    StatusManager.instance.MG -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[10] -= 1;
                    InputHobbyPMG.text = inputhobbyp[10].ToString();
                    NowMG.text = StatusManager.instance.MG.ToString();
                    Afterstatus[10] = StatusManager.instance.MG;
                }
                else { return; }break;
            case 11:    //ライフル
                if (int.Parse(InputHobbyPR.text) > 0)
                {
                    StatusManager.instance.R -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[11] -= 1;
                    InputHobbyPR.text = inputhobbyp[11].ToString();
                    NowR.text = StatusManager.instance.R.ToString();
                    Afterstatus[11] = StatusManager.instance.R;
                }
                else { return; }break;

            //探索技能ステータス
            case 100:    //応急手当
                if (int.Parse(InputHobbyPOkyuteate.text) > 0)
                {
                    StatusManager.instance.Okyuteate -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[12] -= 1;
                    InputHobbyPOkyuteate.text = inputhobbyp[12].ToString();
                    NowOkyuteate.text = StatusManager.instance.Okyuteate.ToString();
                    Afterstatus[12] = StatusManager.instance.Okyuteate;
                }
                else { return; }break;
            case 101:    //鍵開け
                if (int.Parse(InputHobbyPKagiake.text) > 0)
                {
                    StatusManager.instance.Kagiake -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[13] -= 1;
                    InputHobbyPKagiake.text = inputhobbyp[13].ToString();
                    NowKagiake.text = StatusManager.instance.Kagiake.ToString();
                    Afterstatus[13] = StatusManager.instance.Kagiake;
                }
                else { return; }break;
            case 102:    //隠す
                if (int.Parse(InputHobbyPKakusu.text) > 0)
                {
                    StatusManager.instance.Kakusu -= 1;
                    StatusManager.instance.WorkP += 1;
                    inputhobbyp[14] -= 1;
                    InputHobbyPKakusu.text = inputhobbyp[14].ToString();
                    NowKakusu.text = StatusManager.instance.Kakusu.ToString();
                    Afterstatus[14] = StatusManager.instance.Kakusu;
                }
                else { return; }break;
            case 103:    //隠れる
                if (int.Parse(InputHobbyPKakureru.text) > 0)
                {
                    StatusManager.instance.Kakureru -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[15] -= 1;
                    InputHobbyPKakureru.text = inputhobbyp[15].ToString();
                    NowKakureru.text = StatusManager.instance.Kakureru.ToString();
                    Afterstatus[15] = StatusManager.instance.Kakureru;
                }
                else { return; }break;
            case 104:    //聞き耳
                if (int.Parse(InputHobbyPKikimimi.text) > 0)
                {
                    StatusManager.instance.Kikimimi -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[16] -= 1;
                    InputHobbyPKikimimi.text = inputhobbyp[16].ToString();
                    NowKikimimi.text = StatusManager.instance.Kikimimi.ToString();
                    Afterstatus[16] = StatusManager.instance.Kikimimi;
                }
                else { return; }break;
            case 105:    //忍び歩き
                if (int.Parse(InputHobbyPShinobiaruki.text) > 0)
                {
                    StatusManager.instance.Shinobiaruki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[17] -= 1;
                    InputHobbyPShinobiaruki.text = inputhobbyp[17].ToString();
                    NowShinobiaruki.text = StatusManager.instance.Shinobiaruki.ToString();
                    Afterstatus[17] = StatusManager.instance.Shinobiaruki;
                }
                else { return; }break;
            case 106:    //写真術
                if (int.Parse(InputHobbyPSyashinzyutsu.text) > 0)
                {
                    StatusManager.instance.Syashinzyutsu -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[18] -= 1;
                    InputHobbyPSyashinzyutsu.text = inputhobbyp[18].ToString();
                    NowSyashinzyutsu.text = StatusManager.instance.Syashinzyutsu.ToString();
                    Afterstatus[18] = StatusManager.instance.Syashinzyutsu;
                }
                else { return; }break;
            case 107:    //精神分析
                if (int.Parse(InputHobbyPSeshinbunseki.text) > 0)
                {
                    StatusManager.instance.Seshinbunseki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[19] -= 1;
                    InputHobbyPSeshinbunseki.text = inputhobbyp[19].ToString();
                    NowSeshinbunseki.text = StatusManager.instance.Seshinbunseki.ToString();
                    Afterstatus[19] = StatusManager.instance.Seshinbunseki;
                }
                else { return; }break;
            case 108:    //追跡
                if (int.Parse(InputHobbyPTsuiseki.text) > 0)
                {
                    StatusManager.instance.Tsuiseki -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[20] -= 1;
                    InputHobbyPTsuiseki.text = inputhobbyp[20].ToString();
                    NowTsuiseki.text = StatusManager.instance.Tsuiseki.ToString();
                    Afterstatus[20] = StatusManager.instance.Tsuiseki;
                }
                else { return; }break;
            case 109:    //登攀
                if (int.Parse(InputHobbyPTouhan.text) > 0)
                {
                    StatusManager.instance.Touhan -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[21] -= 1;
                    InputHobbyPTouhan.text = inputhobbyp[21].ToString();
                    NowTouhan.text = StatusManager.instance.Touhan.ToString();
                    Afterstatus[21] = StatusManager.instance.Touhan;
                }
                else { return; }break;
            case 110:    //図書館
                if (int.Parse(InputHobbyPTosyokan.text) > 0)
                {
                    StatusManager.instance.Tosyokan -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[22] -= 1;
                    InputHobbyPTosyokan.text = inputhobbyp[22].ToString();
                    NowTosyokan.text = StatusManager.instance.Tosyokan.ToString();
                    Afterstatus[22] = StatusManager.instance.Tosyokan;
                }
                else { return; }break;
            case 111:    //目星
                if (int.Parse(InputHobbyPMeboshi.text) > 0)
                {
                    StatusManager.instance.Meboshi -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[23] -= 1;
                    InputHobbyPMeboshi.text = inputhobbyp[23].ToString();
                    NowMeboshi.text = StatusManager.instance.Meboshi.ToString();
                    Afterstatus[23] = StatusManager.instance.Meboshi;
                }
                else { return; }break;

            //行動技能ステータス
            case 200:    //運転
                if (int.Parse(InputHobbyPUnten.text) > 0)
                {
                    StatusManager.instance.Unten -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[24] -= 1;
                    InputHobbyPUnten.text = inputhobbyp[24].ToString();
                    NowUnten.text = StatusManager.instance.Unten.ToString();
                    Afterstatus[24] = StatusManager.instance.Unten;
                }
                else { return; }break;
            case 201:    //機械修理
                if (int.Parse(InputHobbyPKikaisyuri.text) > 0)
                {
                    StatusManager.instance.Kikaisyuri -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[25] -= 1;
                    InputHobbyPKikaisyuri.text = inputhobbyp[25].ToString();
                    NowKikaisyuri.text = StatusManager.instance.Kikaisyuri.ToString();
                    Afterstatus[25] = StatusManager.instance.Kikaisyuri;
                }
                else { return; }break;
            case 202:    //重機械操作
                if (int.Parse(InputHobbyPZyukikaisosa.text) > 0)
                {
                    StatusManager.instance.Zyukikaisosa -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[26] -= 1;
                    InputHobbyPZyukikaisosa.text = inputhobbyp[26].ToString();
                    NowZyukikaisosa.text = StatusManager.instance.Zyukikaisosa.ToString();
                    Afterstatus[26] = StatusManager.instance.Zyukikaisosa;
                }
                else { return; }break;
            case 203:    //乗馬
                if (int.Parse(InputHobbyPZyoba.text) > 0)
                {
                    StatusManager.instance.Zyoba -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[27] -= 1;
                    InputHobbyPZyoba.text = inputhobbyp[27].ToString();
                    NowZyoba.text = StatusManager.instance.Zyoba.ToString();
                    Afterstatus[27] = StatusManager.instance.Zyoba;
                }
                else { return; }break;
            case 204:    //水泳
                if (int.Parse(InputHobbyPSuiei.text) > 0)
                {
                    StatusManager.instance.Suiei -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[28] -= 1;
                    InputHobbyPSuiei.text = inputhobbyp[28].ToString();
                    NowSuiei.text = StatusManager.instance.Suiei.ToString();
                    Afterstatus[28] = StatusManager.instance.Suiei;
                }
                else { return; }break;
            case 205:    //制作
                if (int.Parse(InputHobbyPSesaku.text) > 0)
                {
                    StatusManager.instance.Sesaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[29] -= 1;
                    InputHobbyPSesaku.text = inputhobbyp[29].ToString();
                    NowSesaku.text = StatusManager.instance.Sesaku.ToString();
                    Afterstatus[29] = StatusManager.instance.Sesaku;
                }
                else { return; }break;
            case 206:    //操縦
                if (int.Parse(InputHobbyPSozyu.text) > 0)
                {
                    StatusManager.instance.Sozyu -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[30] -= 1;
                    InputHobbyPSozyu.text = inputhobbyp[30].ToString();
                    NowSozyu.text = StatusManager.instance.Sozyu.ToString();
                    Afterstatus[30] = StatusManager.instance.Sozyu;
                }
                else { return; }break;
            case 207:    //跳躍
                if (int.Parse(InputHobbyPTyoyaku.text) > 0)
                {
                    StatusManager.instance.Tyoyaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[31] -= 1;
                    InputHobbyPTyoyaku.text = inputhobbyp[31].ToString();
                    NowTyoyaku.text = StatusManager.instance.Tyoyaku.ToString();
                    Afterstatus[31] = StatusManager.instance.Tyoyaku;
                }
                else { return; }break;
            case 208:    //電気修理
                if (int.Parse(InputHobbyPDenkisyuri.text) > 0)
                {
                    StatusManager.instance.Denkisyuri -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[32] -= 1;
                    InputHobbyPDenkisyuri.text = inputhobbyp[32].ToString();
                    NowDenkisyuri.text = StatusManager.instance.Denkisyuri.ToString();
                    Afterstatus[32] = StatusManager.instance.Denkisyuri;
                }
                else { return; }break;
            case 209:    //ナビゲート
                if (int.Parse(InputHobbyPNabigeto.text) > 0)
                {
                    StatusManager.instance.Nabigeto -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[33] -= 1;
                    InputHobbyPNabigeto.text = inputhobbyp[33].ToString();
                    NowNabigeto.text = StatusManager.instance.Nabigeto.ToString();
                    Afterstatus[33] = StatusManager.instance.Nabigeto;
                }
                else { return; }break;
            case 210:    //変装
                if (int.Parse(InputHobbyPHensou.text) > 0)
                {
                    StatusManager.instance.Hensou -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[34] -= 1;
                    InputHobbyPHensou.text = inputhobbyp[34].ToString();
                    NowHensou.text = StatusManager.instance.Hensou.ToString();
                    Afterstatus[34] = StatusManager.instance.Hensou;
                }
                else { return; }break;

            //交渉技能ステータス
            case 300:    //言いくるめ
                if (int.Parse(InputHobbyPIikurume.text) > 0)
                {
                    StatusManager.instance.Iikurume -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[35] -= 1;
                    InputHobbyPIikurume.text = inputhobbyp[35].ToString();
                    NowIikurume.text = StatusManager.instance.Iikurume.ToString();
                    Afterstatus[35] = StatusManager.instance.Iikurume;
                }
                else { return; }break;
            case 301:    //信用
                if (int.Parse(InputHobbyPShinyou.text) > 0)
                {
                    StatusManager.instance.Shinyou -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[36] -= 1;
                    InputHobbyPShinyou.text = inputhobbyp[36].ToString();
                    NowShinyou.text = StatusManager.instance.Shinyou.ToString();
                    Afterstatus[36] = StatusManager.instance.Shinyou;
                }
                else { return; }break;
            case 302:    //説得
                if (int.Parse(InputHobbyPSettoku.text) > 0)
                {
                    StatusManager.instance.Settoku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[37] -= 1;
                    InputHobbyPSettoku.text = inputhobbyp[37].ToString();
                    NowSettoku.text = StatusManager.instance.Settoku.ToString();
                    Afterstatus[37] = StatusManager.instance.Settoku;
                }
                else { return; }break;
            case 303:    //値切り
                if (int.Parse(InputHobbyPNegiri.text) > 0)
                {
                    StatusManager.instance.Negiri -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[38] -= 1;
                    InputHobbyPNegiri.text = inputhobbyp[38].ToString();
                    NowNegiri.text = StatusManager.instance.Negiri.ToString();
                    Afterstatus[38] = StatusManager.instance.Negiri;
                }
                else { return; }break;
            case 304:    //母国語
                if (int.Parse(InputHobbyPBokokugo.text) > 0)
                {
                    StatusManager.instance.Bokokugo -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[39] -= 1;
                    InputHobbyPBokokugo.text = inputhobbyp[39].ToString();
                    NowBokokugo.text = StatusManager.instance.Bokokugo.ToString();
                    Afterstatus[39] = StatusManager.instance.Bokokugo;
                }
                else { return; }break;

            //知識技能ステータス
            case 400:    //医学
                if (int.Parse(InputHobbyPIgaku.text) > 0)
                {
                    StatusManager.instance.Igaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[40] -= 1;
                    InputHobbyPIgaku.text = inputhobbyp[40].ToString();
                    NowIgaku.text = StatusManager.instance.Igaku.ToString();
                    Afterstatus[40] = StatusManager.instance.Igaku;
                }
                else { return; }break;
            case 401:    //オカルト
                if (int.Parse(InputHobbyPOkaruto.text) > 0)
                {
                    StatusManager.instance.Okaruto -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[41] -= 1;
                    InputHobbyPOkaruto.text = inputhobbyp[41].ToString();
                    NowOkaruto.text = StatusManager.instance.Okaruto.ToString();
                    Afterstatus[41] = StatusManager.instance.Okaruto;
                }
                else { return; }break;
            case 402:    //化学
                if (int.Parse(InputHobbyPKagaku.text) > 0)
                {
                    StatusManager.instance.Kagaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[42] -= 1;
                    InputHobbyPKagaku.text = inputhobbyp[42].ToString();
                    NowKagaku.text = StatusManager.instance.Kagaku.ToString();
                    Afterstatus[42] = StatusManager.instance.Kagaku;
                }
                else { return; }break;
            case 403:    //クトゥルフ神話
                if (int.Parse(InputHobbyPShinwa.text) > 0)
                {
                    StatusManager.instance.Shinwa -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[43] -= 1;
                    InputHobbyPShinwa.text = inputhobbyp[43].ToString();
                    NowShinwa.text = StatusManager.instance.Shinwa.ToString();
                    Afterstatus[43] = StatusManager.instance.Shinwa;
                }
                else { return; }break;
            case 404:    //芸術
                if (int.Parse(InputHobbyPGezyutsu.text) > 0)
                {
                    StatusManager.instance.Gezyutsu -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[44] -= 1;
                    InputHobbyPGezyutsu.text = inputhobbyp[44].ToString();
                    NowGezyutsu.text = StatusManager.instance.Gezyutsu.ToString();
                    Afterstatus[44] = StatusManager.instance.Gezyutsu;
                }
                else { return; }break;
            case 405:    //経理
                if (int.Parse(InputHobbyPKeiri.text) > 0)
                {
                    StatusManager.instance.Keiri -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[45] -= 1;
                    InputHobbyPKeiri.text = inputhobbyp[45].ToString();
                    NowKeiri.text = StatusManager.instance.Keiri.ToString();
                    Afterstatus[45] = StatusManager.instance.Keiri;
                }
                else { return; }break;
            case 406:    //考古学
                if (int.Parse(InputHobbyPKokogaku.text) > 0)
                {
                    StatusManager.instance.Kokogaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[46] -= 1;
                    InputHobbyPKokogaku.text = inputhobbyp[46].ToString();
                    NowKokogaku.text = StatusManager.instance.Kokogaku.ToString();
                    Afterstatus[46] = StatusManager.instance.Kokogaku;
                }
                else { return; }break;
            case 407:    //コンピューター
                if (int.Parse(InputHobbyPPC.text) > 0)
                {
                    StatusManager.instance.PC -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[47] -= 1;
                    InputHobbyPPC.text = inputhobbyp[47].ToString();
                    NowPC.text = StatusManager.instance.PC.ToString();
                    Afterstatus[47] = StatusManager.instance.PC;
                }
                else { return; }break;
            case 408:    //心理学
                if (int.Parse(InputHobbyPShinrigaku.text) > 0)
                {
                    StatusManager.instance.Shinrigaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[48] -= 1;
                    InputHobbyPShinrigaku.text = inputhobbyp[48].ToString();
                    NowShinrigaku.text = StatusManager.instance.Shinrigaku.ToString();
                    Afterstatus[48] = StatusManager.instance.Shinrigaku;
                }
                else { return; }break;
            case 409:    //人類学
                if (int.Parse(InputHobbyPZinruigaku.text) > 0)
                {
                    StatusManager.instance.Zinruigaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[49] -= 1;
                    InputHobbyPZinruigaku.text = inputhobbyp[49].ToString();
                    NowZinruigaku.text = StatusManager.instance.Zinruigaku.ToString();
                    Afterstatus[49] = StatusManager.instance.Zinruigaku;
                }
                else { return; }break;
            case 410:    //生物学
                if (int.Parse(InputHobbyPSeibutsugaku.text) > 0)
                {
                    StatusManager.instance.Seibutsugaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[50] -= 1;
                    InputHobbyPSeibutsugaku.text = inputhobbyp[50].ToString();
                    NowSeibutsugaku.text = StatusManager.instance.Seibutsugaku.ToString();
                    Afterstatus[50] = StatusManager.instance.Seibutsugaku;
                }
                else { return; }break;
            case 411:    //地質学
                if (int.Parse(InputHobbyPTishitsugaku.text) > 0)
                {
                    StatusManager.instance.Tishitsugaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[51] -= 1;
                    InputHobbyPTishitsugaku.text = inputhobbyp[51].ToString();
                    NowTishitsugaku.text = StatusManager.instance.Tishitsugaku.ToString();
                    Afterstatus[51] = StatusManager.instance.Tishitsugaku;
                }
                else { return; }break;
            case 412:    //電子工学
                if (int.Parse(InputHobbyPDenshikougaku.text) > 0)
                {
                    StatusManager.instance.Denshikougaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[52] -= 1;
                    InputHobbyPDenshikougaku.text = inputhobbyp[52].ToString();
                    NowDenshikougaku.text = StatusManager.instance.Denshikougaku.ToString();
                    Afterstatus[52] = StatusManager.instance.Denshikougaku;
                }
                else { return; }break;
            case 413:    //天文学
                if (int.Parse(InputHobbyPTenmongaku.text) > 0)
                {
                    StatusManager.instance.Tenmongaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[53] -= 1;
                    InputHobbyPTenmongaku.text = inputhobbyp[53].ToString();
                    NowTenmongaku.text = StatusManager.instance.Tenmongaku.ToString();
                    Afterstatus[53] = StatusManager.instance.Tenmongaku;
                }
                else { return; }break;
            case 414:    //博物学
                if (int.Parse(InputHobbyPHakubutsugaku.text) > 0)
                {
                    StatusManager.instance.Hakubutsugaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[54] -= 1;
                    InputHobbyPHakubutsugaku.text = inputhobbyp[54].ToString();
                    NowHakubutsugaku.text = StatusManager.instance.Hakubutsugaku.ToString();
                    Afterstatus[54] = StatusManager.instance.Hakubutsugaku;
                }
                else { return; }break;
            case 415:    //物理学
                if (int.Parse(InputHobbyPButsurigaku.text) > 0)
                {
                    StatusManager.instance.Butsurigaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[55] -= 1;
                    InputHobbyPButsurigaku.text = inputhobbyp[55].ToString();
                    NowButsurigaku.text = StatusManager.instance.Butsurigaku.ToString();
                    Afterstatus[55] = StatusManager.instance.Butsurigaku;
                }
                else { return; }break;
            case 416:    //法律
                if (int.Parse(InputHobbyPHouritsu.text) > 0)
                {
                    StatusManager.instance.Houritsu -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[56] -= 1;
                    InputHobbyPHouritsu.text = inputhobbyp[56].ToString();
                    NowHouritsu.text = StatusManager.instance.Houritsu.ToString();
                    Afterstatus[56] = StatusManager.instance.Houritsu;
                }
                else { return; }break;
            case 417:    //薬学
                if (int.Parse(InputHobbyPYakugaku.text) > 0)
                {
                    StatusManager.instance.Yakugaku -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[57] -= 1;
                    InputHobbyPYakugaku.text = inputhobbyp[57].ToString();
                    NowYakugaku.text = StatusManager.instance.Yakugaku.ToString();
                    Afterstatus[57] = StatusManager.instance.Yakugaku;
                }
                else { return; }break;
            case 418:    //歴史
                if (int.Parse(InputHobbyPRekishi.text) > 0)
                {
                    StatusManager.instance.Rekishi -= 1;
                    StatusManager.instance.HobbyP += 1;
                    inputhobbyp[58] -= 1;
                    InputHobbyPRekishi.text = inputhobbyp[58].ToString();
                    NowRekishi.text = StatusManager.instance.Rekishi.ToString();
                    Afterstatus[58] = StatusManager.instance.Rekishi;
                }
                else { return; }break;
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

    //シーン移行
    public void NextScenechecker(int ButtonNo)
    {
        switch (ButtonNo)
        {
            case 0:
                if (StatusManager.instance.ChoiceProfession != 3)
                {
                    if ((StatusManager.instance.WorkP != 0) && (StatusManager.instance.HobbyP != 0))
                    { DecisionPanel.SetActive(true); }
                    else { SkillCheckerPanel.SetActive(true); }
                }
                else
                {
                    if (StatusManager.instance.HobbyP != 0)
                    { DecisionPanel.SetActive(true); }
                    else { SkillCheckerPanel.SetActive(true); }
                }
                break;
            case 1:
                TakeSkill();
                SceneManager.LoadScene("test");
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
        for(int i = 0; i < 58; i++)
        {
            if (status[i] != Afterstatus[i])
            {
                StatusManager.instance.dic.Add(SkillName[i], Afterstatus[i]);
            }
        }
    }
}
