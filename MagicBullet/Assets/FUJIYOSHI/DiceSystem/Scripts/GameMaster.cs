using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Linq;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;
#if UNITY_EDITOR
using UnityEditor;
#endif

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

    [SerializeField] private f_Stage Stage;
    [SerializeField] private f_StageData StageData;

    [HideInInspector] public ObjectItem SelectItem;
    public bool IsSelectItem = false;
    public bool canMagickBulletAvoid = false;
    public bool canBattle = false;

    [HideInInspector] public GameObject BattleObject;

    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;

    public int magicBullet = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            this.canMagickBulletAvoid = Instance.canMagickBulletAvoid;
            this.canBattle = Instance.canBattle;
            Destroy(Instance.gameObject);
        }
        Instance = this;
        return;
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
        await UniTask.Yield(PlayerLoopTiming.Update);
        await informationLabel.PlayLabelTask("SAN�l�����I " + minA.ToString() + " / "
             + "1 d " + (maxB - minB + 1).ToString());

        await informationLabel.PlayLabelTask("SAN�l = " + nowSAN);

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

        await informationLabel.PlayLabelTask("SAN�l��" + result + "�����I");

        await CheckInsane(nowSAN - result);

        return result;
    }

    private async UniTask CheckInsane(int SAN)
    {
        if (SAN <= 0)
        {
            await informationLabel.PlayLabelTask("SAN�l0���Ȃ��͋������Ă��܂����B");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }
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
        await informationLabel.PlayLabelTask(result.ToString());

        foreach (var item in targetItem.AssesmentItem())
        {
            await informationLabel.PlayLabelTask(item);
        }

        result = JudgementType.FUMBLE;
        // �t�@���u�������ʏ���
        if (result == JudgementType.FUMBLE)
        {
            StatusManager.Instance.SAN -= await SANDiceRoll(StatusManager.Instance.SAN, 1, 1, 1, 3);
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
        Debug.Log(targetItem.Comprehension);

        //����x����e�L�X�g��\��

        await UniTask.Yield(PlayerLoopTiming.Update);

        informationLabel.PlayLabel(result.ToString());

        while (!Input.GetMouseButtonDown(0))
        {
            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        foreach (var item in targetItem.AssesmentItem())
        {
            await UniTask.Yield(PlayerLoopTiming.Update);

            informationLabel.PlayLabel(item);

            while (!Input.GetMouseButtonDown(0))
            {
                await UniTask.Yield(PlayerLoopTiming.Update);
            }
        }

        // �t�@���u�������ʏ���
        if (result == JudgementType.FUMBLE)
        {
            StatusManager.Instance.SAN -= await SANDiceRoll(StatusManager.Instance.SAN, 1, 1, 1, 3);
        }

        return targetItem;
    }

    // �^�[�����o�g���J�n�I
    public async UniTask TurnBattle(IBattlePlayer battlePlayer, IEnemy enemy, int TurnLimit = 0)
    {
        BattleObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        // ���ݐ퓬���̓G�E������ۑ�
        currentBattlePlayer = battlePlayer;
        currentEnemy = enemy;
        var turnCount = 0;

        if (AttackUI == null)
        {
            AttackUI = GameObject.Find("GunAttack");
            Debug.Log(AttackUI);
        }
        var isEnd = false;

        // ���Ґ����ő��s
        while (IsCharacterActive(battlePlayer, enemy) && (TurnLimit == 0 || turnCount < TurnLimit))
        {
            AttackUI.SetActive(false);

            if (turnCount == 0 && TurnLimit != 0)
            {
                await UniTask.WaitForSeconds(1);
                await informationLabel.PlayLabelTask("�S�[����l�^�̂��₪�o�Ă����I");
                //await informationLabel.PlayLabelTask(TurnLimit + "�^�[���ϋv�ŏ����I");
            }

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

            var passSkill = battlePlayer.GetUsedSkillName();

            if (enemy.IsPassSkill(passSkill))
            {
                // ���ł�6�������Ă���A�Ԋ��������Ă��Ȃ��Ƃ�
                if (magicBullet == 6 && !canMagickBulletAvoid)
                {
                    await informationLabel.PlayLabelTask("�����o���ꂽ�e�͓G�Ɍ����킸\n�e����ς����g�̋��߂����Ĕ��ł����I");
                    await informationLabel.PlayLabelTask("9999�_���[�W���󂯂��I");
                    await informationLabel.PlayLabelTask("GameOver");
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
                }
                ++magicBullet;
            }

            // �G���_���[�W���󂯂܂��B
            enemy.EnemyDamage(passSkill, battlePlayer.GetAttackPoint(), x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            if (!IsCharacterActive(battlePlayer, enemy)) { break; }

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
            ++turnCount;
        }

        // �퓬�I���̂��߁A�퓬���̓G�E�������폜
        currentEnemy = null;
        currentBattlePlayer = null;

        // �����̏����I
        if (!battlePlayer.IsDie())
        {
            battlePlayer.Win();
            await UniTask.Yield(PlayerLoopTiming.Update);

            while (!Input.GetMouseButtonDown(0))
            {
                await UniTask.Yield(PlayerLoopTiming.Update);
            }

            while (!Input.anyKeyDown)
            {
                await UniTask.Yield(PlayerLoopTiming.Update);
            }
            await UniTask.Yield(PlayerLoopTiming.Update);

            if (TurnLimit != 0)
            {
                await informationLabel.PlayLabelTask("�l�^�̂���͖��U�����I");
                var bag = GameObject.Find("Bag").GetComponent<Bag>();
                bag.Content.Add(ItemManager.ItemData[ItemIndex]);

                await informationLabel.PlayLabelTask("�Ԋ�����ɓ��ꂽ�I");
                canMagickBulletAvoid = true;
                BattleObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                return;
            }

            await Stage.PlayStage(StageData);
            Stage.StageSettingActive(true);

            UnityEngine.SceneManagement.SceneManager.LoadScene("Clear");

            return;
        }
        // �G�̏����I
        enemy.EnemyWin();
        await UniTask.Yield(PlayerLoopTiming.Update);

        while (!Input.GetMouseButtonDown(0))
        {
            await UniTask.Yield(PlayerLoopTiming.Update);
        }

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
            Moderate("�ǂ����Ō��̊J�������������I");
            canFinalBattle = true;
        }
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(GameMaster))]
public class GameMasterEditor : Editor
{
    SerializedProperty PopupProperty;

    private void OnEnable()
    {
        PopupProperty = serializedObject.FindProperty("ItemIndex");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        serializedObject.Update();

        GameMaster manager = (GameMaster)this.target;
        //���Z�b�g�̏ꍇ��null�����蓾��
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("���g�A�C�e�����w�聥");
        PopupProperty.intValue = EditorGUILayout.Popup(
            PopupProperty.intValue,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );

        serializedObject.ApplyModifiedProperties();
    }
}
#endif
