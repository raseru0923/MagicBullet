using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// �퓬���̃v���C���[
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("�퓬�p�R�}���h��ݒ聥")]
    [SerializeField] private GameObject BattleCommand;
    [SerializeField] private GameObject ActionList;

    // ����HP
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

    private async void OnEnable()
    {
        await BattleSet();
    }

    public async UniTask BattleSet()
    {
        while (StatusManager.Instance == null) { await UniTask.WaitForFixedUpdate(); }
        // �X�e�[�^�X����HP��ݒ�
        currentHP = StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);

        Cursor.lockState = CursorLockMode.None;


        HPBar.fillAmount = currentHP / StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        HPText.text = "HP : " + currentHP + " / " + StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        SANBar.fillAmount = 1;
        SANText.text = "SAN : " + StatusManager.Instance.SAN + " / " + StatusManager.Instance.SAN;

        while (GameMaster.Instance == null)
        {
            await UniTask.WaitForFixedUpdate();
        }

        Debug.Log(GameMaster.Instance.canBattle);

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Playground" && GameMaster.Instance.canBattle)
        {
            Debug.Log("�ϋv��I");
            await GameMaster.Instance.TurnBattle(this.GetComponent<IBattlePlayer>(), GameObject.Find("Caspard").GetComponent<IEnemy>(), 3);
            return;
        }

        if (!GameMaster.Instance.canBattle)
        {
            GameMaster.Instance.canBattle = true;
            return;
        }

        f_Stage stage = GameObject.Find("Stage").GetComponent<f_Stage>();

        await stage.PlayStage(stageData);

        await GameMaster.Instance.TurnBattle(this.GetComponent<IBattlePlayer>(), GameObject.Find("Caspard").GetComponent<IEnemy>());
    }

    private async void Start()
    {
        GameMaster.Instance.BattlePlayerObject = this.gameObject;

        // �X�e�[�^�X����HP��ݒ�
        currentHP = StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);

        Cursor.lockState = CursorLockMode.None;


        HPBar.fillAmount = currentHP / StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        HPText.text = "HP : " + currentHP + " / " + StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON);
        SANBar.fillAmount = 1;
        SANText.text = "SAN : " + StatusManager.Instance.SAN + " / " + StatusManager.Instance.SAN;
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Playground") { return; }

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
            await GameMaster.Instance.informationLabel.PlayLabelTask("���");
            var result = await GameMaster.Instance.HundredDiceRoll(StatusManager.Instance.SkillParameter["���"]);

            switch (result)
            {
                case f_Dealer.JudgementType.CRITICAL:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("�U����������܂����B");
                    isEnd?.Invoke(true);
                    return;
                case f_Dealer.JudgementType.SUCCESS:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("�U����������܂����B");
                    isEnd?.Invoke(true);
                    return;
                case f_Dealer.JudgementType.FAIL:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("������s�B");
                    break;
                case f_Dealer.JudgementType.FUMBLE:
                    await GameMaster.Instance.informationLabel.PlayLabelTask("������s�B");
                    break;
                default:
                    break;
            }
        }

        // �_���[�W���󂯂�
        currentHP -= damage;

        GameMaster.Instance.AttackUI.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(GunClip);

        await GameMaster.Instance.informationLabel.PlayLabelTask(damage + "�_���[�W���󂯂��I");

        // ���S
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


        if (useSkillName == "���}�蓖")
        {
            var recovery = 0;
            switch (result)
            {
                case f_Dealer.JudgementType.CRITICAL:
                    recovery = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]) * 2;

                    currentHP = Mathf.Clamp(currentHP + recovery, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HP��" + recovery + "�񕜂����I");
                    SetHPGauge();
                    break;
                case f_Dealer.JudgementType.SUCCESS:
                    recovery = await TRPGParameterDice(SkillParameterDatas.SkillTRPGParameters[useSkillName]);
                    currentHP = Mathf.Clamp(currentHP + recovery, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HP��" + recovery + "�񕜂����I");
                    SetHPGauge();
                    break;
                case f_Dealer.JudgementType.FAIL:
                    break;
                case f_Dealer.JudgementType.FUMBLE:
                    currentHP = Mathf.Clamp(currentHP - 1, 0, StatusManager.Instance.BasicStatusTypeValue(StatusManager.BasicStatusType.CON));

                    await GameMaster.Instance.informationLabel.PlayLabelTask("HP��1�����I");
                    SetHPGauge();
                    break;
                default:
                    break;
            }
            isEnd?.Invoke(true);
            return;
        }

        var trpgParameter = new TRPGParameter();
        attackPoint = 0;

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

        var damageBonus = StatusManager.Instance.DamageP;

        // �_���[�W�{�[�i�X�̏����͂���
        //if (damageBonus != 0)
        //{
        //    var absBonus = Mathf.Abs(damageBonus);
        //    await GameMaster.Instance.informationLabel.PlayLabelTask("�_���[�W�{�[�i�X = " + damageBonus / absBonus + " d " + absBonus);
        //    var bonusResult = await GameMaster.Instance.SumDealerDiceRoll(1, absBonus);
        //    bonusResult *= damageBonus / absBonus;
        //    await GameMaster.Instance.informationLabel.PlayLabelTask(attackPoint + " + " + bonusResult + " = " + (attackPoint + bonusResult));
        //    attackPoint += bonusResult;
        //}


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
        StatusManager.Instance.SetMode(58);
        foreach (var item in StatusManager.Instance.GetNames())
        {
            // �g�p�Z�\���U���Z�\�łȂ��Ƃ��͏I��
            if (item == skillName && item != "���}�蓖") { GameMaster.Instance.Moderate("�g�p���Ă��Ӗ��͂Ȃ��������B"); return; }
        }
        canAvoid = true;
        Debug.Log("�s������I");
        useSkillName = skillName;

        StatusManager.Instance.SetMode(12);

        foreach (var item in StatusManager.Instance.GetNames())
        {
            if (item == skillName)
            {
                Debug.Log("���s�\");
                canAvoid = false;
                break;
            }
        }

        isEnter = true;
        // �A�N�V�������X�g�����
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
        GameMaster.Instance.Moderate("�퓬�I���I");
    }
}
