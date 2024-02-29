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
        informationLabel.PlayLabel(printText);
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

        informationLabel.PlayLabel(targetItem.AssesmentItem());

        return targetItem;
    }

    // �^�[�����o�g���J�n�I
    public async UniTask TurnBattle(IBattlePlayer battlePlayer, IEnemy enemy)
    {
        // ���ݐ퓬���̓G�E������ۑ�
        currentBattlePlayer = battlePlayer;
        currentEnemy = enemy;

        // ���Ґ����ő��s
        while (IsCharacterActive(battlePlayer, enemy))
        {
            // �v���C���[���s����I�����܂��B
            battlePlayer.SetBattleCommandActive(true);

            while (!battlePlayer.IsEnter())
            {
                await UniTask.WaitForFixedUpdate();
            }

            battlePlayer.SetBattleCommandActive(false);

            // �v���C���[���s�����s���܂��B
            await SkillDiceRoll("���e");

            // �G���U�����s���܂��B
        }

        // �퓬�I���̂��߁A�퓬���̓G�E�������폜
        currentEnemy = null;
        currentBattlePlayer = null;
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
        int skillValue = StatusManager.Instance.SkillParameter[skillName];

        return await HundredDiceRoll(skillValue);
    }

    public async void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            await TurnBattle(GameObject.Find("BattlePlayer").GetComponent<IBattlePlayer>(), GameObject.Find("Caspard").GetComponent<IEnemy>());
        }
    }
}
