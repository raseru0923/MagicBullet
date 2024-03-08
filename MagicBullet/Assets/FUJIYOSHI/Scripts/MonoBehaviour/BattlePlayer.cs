using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// 戦闘時のプレイヤー
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("戦闘用コマンドを設定▼")]
    [SerializeField] private GameObject BattleCommand;
    [SerializeField] private GameObject ActionList;

    // 現在HP
    private int currentHP;

    private bool isDie = false;

    private bool isEnter = false;
    private string useSkillName = null;

    [SerializeField] private Image HPBar;
    [SerializeField] private Text HPText;
    [SerializeField] private Image SANBar;
    [SerializeField] private Text SANText;

    [SerializeField] private AudioClip GunClip;

    [SerializeField] private f_StageData stageData;

    [SerializeField] private SkillParameterData SkillParameterDatas;

    private bool canAvoid = true;

    private int attackPoint = 0;

    private async void Start()
    {
        // ステータスからHPを設定
        currentHP = StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);

        Cursor.lockState = CursorLockMode.None;


        HPBar.fillAmount = currentHP / StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        HPText.text = "HP : " + currentHP + " / " + StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        SANBar.fillAmount = 1;
        SANText.text = "SAN : " + StatusManager.Instance.SAN + " / " + StatusManager.Instance.SAN;

        f_Stage stage = GameObject.Find("Stage").GetComponent<f_Stage>();



        await stage.PlayStage(stageData);

        await GameMaster.Instance.TurnBattle(this.GetComponent<IBattlePlayer>(), GameObject.Find("Caspard").GetComponent<IEnemy>());
    }

    // IBattlePlayer
    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }

    // IBattlePlayer
    public string GetUsedSkillName()
    {
        return useSkillName;
    }

    // IBattlePlayer
    public int GetAttackPoint()
    {
        return attackPoint;
    }

    // IBattlePlayer
    public async void Damage(int damage, Action<bool> isEnd)
    {
        if (canAvoid)
        {
            await GameMaster.Instance.informationLabel.PlayLabelTask("回避");
            var result = await GameMaster.Instance.HundredDiceRoll(StatusManager.Instance.SkillParameter["回避"]);

            switch (result)
            {
                case f_Dealer.JudgementType.CRITICAL:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("攻撃を回避しました。");
                    isEnd?.Invoke(true);
                    return;
                case f_Dealer.JudgementType.SUCCESS:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("攻撃を回避しました。");
                    isEnd?.Invoke(true);
                    return;
                case f_Dealer.JudgementType.FAIL:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("回避失敗。");
                    break;
                case f_Dealer.JudgementType.FUMBLE:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("回避失敗。");
                    break;
                default:
                    break;
            }
        }

        // ダメージを受ける
        currentHP -= damage;

        GameMaster.Instance.AttackUI.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(GunClip);

        await GameMaster.Instance.informationLabel.PlayLabelTask(damage + "ダメージを受けた！");

        // 死亡
        if (currentHP <= 0)
        {
            isDie = true;
        }

        SetHPGauge();

        isEnd?.Invoke(true);
    }

    private void SetHPGauge()
    {
        float bar = (float)currentHP / (float)StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        Debug.Log(bar);

        HPBar.fillAmount = bar;
        HPText.text = "HP : " + currentHP + " / " + StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
    }

    private async UniTask<int> TRPGParameterDice(TRPGParameter trpgParameter)
    {
        await GameMaster.Instance.informationLabel.PlayLabelTask(useSkillName + "!");

        trpgParameter = SkillParameterDatas.SkillTRPGParameters[useSkillName];

        await GameMaster.Instance.informationLabel.PlayLabelTask(trpgParameter.DiceText);

        int result = 0;

        foreach (var item in trpgParameter.DiceParameters)
        {
            result += await GameMaster.Instance.SumDealerDiceRoll(item.Count, item.Value);
        }
        return result += trpgParameter.AddValue;
    }

    // IBattlePlayer
    public async void Action(Action<bool> isEnd)
    {
        isEnter = false;

        var result = await GameMaster.Instance.SkillDiceRoll(useSkillName);

        // テスト用
        result = f_Dealer.JudgementType.FUMBLE;

        if (useSkillName == "応急手当")
        {
            var recovery = 0;
            switch (result)
            {
                case f_Dealer.JudgementType.CRITICAL:
                    recovery = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]) * 2;

                    currentHP = Mathf.Clamp(currentHP + recovery, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HPを" + recovery + "回復した！");
                    SetHPGauge();
                    break;
                case f_Dealer.JudgementType.SUCCESS:
                    recovery = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]);
                    currentHP = Mathf.Clamp(currentHP + recovery, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HPを" + recovery + "回復した！");
                    SetHPGauge();
                    break;
                case f_Dealer.JudgementType.FAIL:
                    break;
                case f_Dealer.JudgementType.FUMBLE:
                    currentHP = Mathf.Clamp(currentHP - 1, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HPが1減少！");
                    SetHPGauge();
                    break;
                default:
                    break;
            }
            isEnd?.Invoke(true);
            return;
        }

        TRPGParameter trpgParameter = default;

        switch (result)
        {
            case f_Dealer.JudgementType.CRITICAL:
                attackPoint = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]) * 2;
                break;
            case f_Dealer.JudgementType.SUCCESS:
                attackPoint = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]);
                break;
            case f_Dealer.JudgementType.FAIL:
                break;
            case f_Dealer.JudgementType.FUMBLE:
                break;
            default:
                break;
        }

        isEnd?.Invoke(true);
    }

    // IBattlePlayer
    public bool IsDie()
    {
        return isDie;
    }

    // IBattlePlayer
    public void ActionEnter(string skillName)
    {
        canAvoid = true;
        Debug.Log("行動決定！");
        useSkillName = skillName;

        StatusManager.Instance.SetMode(12);

        foreach (var item in StatusManager.Instance.GetNames())
        {
            if (item == skillName)
            {
                Debug.Log("回避不能");
                canAvoid = false;
                break;
            }
        }

        isEnter = true;
        // アクションリストを閉じる
        ActionList.SetActive(false);
    }

    // IBattlePlayer
    public bool IsEnter()
    {
        return isEnter;
    }

    // IBattlePlayer
    public void Win()
    {
        GameMaster.Instance.Moderate("戦闘終了！");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Clear");
    }
}
