using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class GameMaster : f_Dealer
{
    // ���g�̃C���X�^���X
    public static GameMaster Instance;

    // ���ݐ퓬���̓G�E����
    public IBattlePlayer currentBattlePlayer;
    public IEnemy currentEnemy;

    private int clearGimmickCount = 0;

    /*[HideInInspector]*/
    public bool canFinalBattle = false;
    public bool isFinalBattle = false;

    public GameObject AttackUI;

    private bool canModerator = true;
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
            return;
        }
        Destroy(this);
    }

    // �i��i�s
    public void Moderate(string printText)
    {
        if (canModerator)
        {
            canModerator = false;
            StartCoroutine(Moderator(printText));
        }
    }

    // �i��i�s
    public void Moderate(string[] printTexts)
    {
        if (canModerator)
        {
            canModerator = false;
            StartCoroutine(Moderator(printTexts));
        }
    }

    private IEnumerator Moderator(string printText)
    {
        yield return null;
        informationLabel.OnLabel(printText);
        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
        informationLabel.OffLabel();
        canModerator = true;
    }

    private IEnumerator Moderator(string[] printTexts)
    {
        foreach (var item in printTexts)
        {
            canModerator = false;
            yield return Moderator(item);
        }
        canModerator = true;
    }

    public async UniTask TalkTask(List<string> talkTexts)
    {
        foreach (var item in talkTexts)
        {
            // �䎌�𗬂�
            await informationLabel.PlayLabelTask(item);

            // 1�t���[���ҋ@
            await UniTask.Yield(PlayerLoopTiming.Update);
        }
    }

    // SAN�l�̔���
    // ���g�̌��݂�SAN�l�Ǝ��s���A��������SAN�l�̌������@
    public async UniTask<int> SANDiceRoll(int nowSAN, int minA, int maxA, int minB, int maxB)
    {
        await informationLabel.PlayLabelTask("SAN�l�����I " + minA + " / "
             + "1 d " + (maxB - minB + 1));

        // �����A���s�݂̂�Ԃ�1d100
        var SANResult = await ReturnResultDiceRoll(nowSAN, 1, 100);

        int result = 0;

        switch (SANResult)
        {
            case JudgementType.SUCCESS:
                await informationLabel.PlayLabelTask("�����I");
                result = await DecreaseSAN(minA, maxA, result);
                break;
            case JudgementType.FAIL:
                await informationLabel.PlayLabelTask("���s�I");
                result = await DecreaseSAN(minB, maxB, result);
                break;
            default:
                break;
        }

        await informationLabel.PlayLabelTask(result + "�����I");

        return result;
    }

    // SAN�l�����_�C�X���[��
    private async Task<int> DecreaseSAN(int minA, int maxA, int result)
    {
        if (minA == maxA)
        {
            return minA;
        }
        // ���Z�l
        int addnum = minA - 1;
        // �_�C�X�̖ڂ̐�
        int diceValue = maxA - minA + 1;

        return await SumDealerDiceRoll(1, diceValue) + addnum;
    }

    // �A�C�e���̊Ӓ���s���B
    public async UniTask<ObjectItem> AssessmentDiceRoll(ObjectItem targetItem/*�g�p����Z�\���w��*/)
    {
        var result = await HundredDiceRoll(50);

        //�_�C�X���[���̌��ʂ��痝��x��ύX
        int level = (int)result;
        targetItem.Comprehension = (COMPREHENSION)level;
        //����x����e�L�X�g��\��
        informationLabel.PlayLabel(result.ToString());

        foreach (var item in targetItem.AssesmentItem())
        {
            informationLabel.PlayLabel(item);
        }

        return targetItem;
    }
    public async UniTask<ObjectItem> AssessmentDiceRoll(ObjectItem targetItem, string useSkillName)
    {
        await informationLabel.PlayLabelTask(useSkillName);

        var result = await HundredDiceRoll(StatusManager.Instance.SkillParameter[useSkillName]);

        //�_�C�X���[���̌��ʂ��痝��x��ύX
        int level = (int)result;
        targetItem.Comprehension = (COMPREHENSION)level;
        //����x����e�L�X�g��\��

        informationLabel.PlayLabel(result.ToString());

        foreach (var item in targetItem.AssesmentItem())
        {
            informationLabel.PlayLabel(item);
        }

        return targetItem;
    }

    // �^�[�����o�g���J�n�I
    public async UniTask TurnBattle(IBattlePlayer battlePlayer, IEnemy enemy)
    {
        // ���ݐ퓬���̓G�E������ۑ�
        currentBattlePlayer = battlePlayer;
        currentEnemy = enemy;

        if (AttackUI == null)
        {
            AttackUI = GameObject.Find("GunAttack");
            Debug.Log(AttackUI);
        }
        var isEnd = false;

        // ���Ґ����ő��s
        while (IsCharacterActive(battlePlayer, enemy))
        {
            AttackUI.SetActive(false);
            // �v���C���[���s����I�����܂��B
            battlePlayer.SetBattleCommandActive(true);

            while (!battlePlayer.IsEnter())
            {
                await UniTask.WaitForFixedUpdate();
            }

            battlePlayer.SetBattleCommandActive(false);

            isEnd = false;

            // �v���C���[���s�����s���܂��B
            battlePlayer.Action(x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            isEnd = false;

            // �G���_���[�W���󂯂܂��B
            enemy.EnemyDamage(battlePlayer.GetUsedSkillName(), battlePlayer.GetAttackPoint(), x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            await UniTask.Yield(PlayerLoopTiming.Update);

            // �G���U�����s���܂��B
            await informationLabel.PlayLabelTask("�G�̍U���I");
            AttackUI.SetActive(false);

            var attackParameter = enemy.GetAttackValue();

            string attackDice = null;
            foreach (var item in attackParameter.DiceParameters)
            {
                attackDice += item.Count + " d " + item.Value + " + ";
            }
            attackDice += attackParameter.AddValue;

            await UniTask.WaitForFixedUpdate();

            await informationLabel.PlayLabelTask(attackDice);

            List<int> result = new List<int>();

            foreach (var item in attackParameter.DiceParameters)
            {
                result.Add(await SumDealerDiceRoll(item.Count, item.Value));
            }

            result.Add(attackParameter.AddValue);

            string damageText = null;

            int sumdamage = 0;

            for (int i = 0; i < result.Count; i++)
            {
                int item = result[i];
                damageText += item;
                sumdamage += item;
                if (i != result.Count - 1) { damageText += " + "; }
            }

            damageText += " = " + sumdamage;

            await UniTask.WaitForFixedUpdate();
            await informationLabel.PlayLabelTask(damageText);

            await UniTask.WaitForFixedUpdate();

            // �v���C���[���_���[�W���󂯂܂��B
            isEnd = false;

            // �v���C���[���s�����s���܂��B
            battlePlayer.Damage(sumdamage, x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            while (!Input.GetMouseButtonDown(0))
            {
                await UniTask.Yield(PlayerLoopTiming.Update);
            }
        }

        // �퓬�I���̂��߁A�퓬���̓G�E�������폜
        currentEnemy = null;
        currentBattlePlayer = null;

        // �����̏����I
        if (!battlePlayer.IsDie())
        {
            battlePlayer.Win();

            return;
        }
        // �G�̏����I
        enemy.EnemyWin();

        while (!Input.anyKeyDown)
        {
            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }

    private static bool IsCharacterActive(IBattlePlayer battlePlayer, IEnemy enemy)
    {
        return !battlePlayer.IsDie() && !enemy.IsDie();
    }

    // �Z�\�̃_�C�X���[��
    // �߂�l�F�_�C�X���[���̌���
    // ����1:�Z�\�̖��O
    public async UniTask<JudgementType> SkillDiceRoll(string skillName)
    {
        // �Z�\����\��
        await informationLabel.PlayLabelTask(skillName + "!");

        // �Ή������X�L���̒l��ԋp
        int skillValue = ReturnSkillParameter(skillName);

        return await HundredDiceRoll(skillValue);
    }

    private int ReturnSkillParameter(string skillName)
    {
        if (StatusManager.Instance.SkillParameter.Count != 0)
        {
            return StatusManager.Instance.SkillParameter[skillName];
        }
        return 50;
    }

    public void GimmickClear()
    {
        ++clearGimmickCount;
        if (clearGimmickCount >= 5)
        {
            canFinalBattle = true;
        }
    }

    public async void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
        }
    }
}
