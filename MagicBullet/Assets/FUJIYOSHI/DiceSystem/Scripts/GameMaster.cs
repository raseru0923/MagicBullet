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
    // 自身のインスタンス
    public static GameMaster Instance;

    // 現在戦闘中の敵・味方
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

    // 司会進行
    public void Moderate(string printText)
    {
        if (canModerator)
        {
            canModerator = false;
            StartCoroutine(Moderator(printText));
        }
    }

    // 司会進行
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
            // 台詞を流す
            await informationLabel.PlayLabelTask(item);

            // 1フレーム待機
            await UniTask.Yield(PlayerLoopTiming.Update);
        }
    }

    // SAN値の判定
    // 自身の現在のSAN値と失敗時、成功時のSAN値の減少方法
    public async UniTask<int> SANDiceRoll(int nowSAN, int minA, int maxA, int minB, int maxB)
    {
        await UniTask.Yield(PlayerLoopTiming.Update);
        await informationLabel.PlayLabelTask("SAN値減少！ " + minA.ToString() + " / "
             + "1 d " + (maxB - minB + 1).ToString());

        await informationLabel.PlayLabelTask("SAN値 = " + nowSAN);

        // 成功、失敗のみを返す1d100
        var SANResult = await ReturnResultDiceRoll(nowSAN, 1, 100);

        int result = 0;

        switch (SANResult)
        {
            case JudgementType.SUCCESS:
                await informationLabel.PlayLabelTask("成功！");
                result = await DecreaseSAN(minA, maxA, result);
                break;
            case JudgementType.FAIL:
                await informationLabel.PlayLabelTask("失敗！");
                result = await DecreaseSAN(minB, maxB, result);
                break;
            default:
                break;
        }

        await informationLabel.PlayLabelTask("SAN値が" + result + "減少！");

        await CheckInsane(nowSAN - result);

        return result;
    }

    private async UniTask CheckInsane(int SAN)
    {
        if (SAN <= 0)
        {
            await informationLabel.PlayLabelTask("SAN値0あなたは狂死してしまった。");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }
    }

    // SAN値減少ダイスロール
    private async Task<int> DecreaseSAN(int minA, int maxA, int result)
    {
        if (minA == maxA)
        {
            return minA;
        }
        // 加算値
        int addnum = minA - 1;
        // ダイスの目の数
        int diceValue = maxA - minA + 1;

        return await SumDealerDiceRoll(1, diceValue) + addnum;
    }

    // アイテムの鑑定を行う。
    public async UniTask<ObjectItem> AssessmentDiceRoll(ObjectItem targetItem/*使用する技能を指定*/)
    {
        var result = await HundredDiceRoll(50);

        //ダイスロールの結果から理解度を変更
        int level = (int)result;
        targetItem.Comprehension = (COMPREHENSION)level;
        //理解度からテキストを表示
        await informationLabel.PlayLabelTask(result.ToString());

        foreach (var item in targetItem.AssesmentItem())
        {
            await informationLabel.PlayLabelTask(item);
        }

        result = JudgementType.FUMBLE;
        // ファンブル時特別処理
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

        //ダイスロールの結果から理解度を変更
        int level = (int)result;
        targetItem.Comprehension = (COMPREHENSION)level;
        Debug.Log(targetItem.Comprehension);

        //理解度からテキストを表示

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

        // ファンブル時特別処理
        if (result == JudgementType.FUMBLE)
        {
            StatusManager.Instance.SAN -= await SANDiceRoll(StatusManager.Instance.SAN, 1, 1, 1, 3);
        }

        return targetItem;
    }

    // ターン性バトル開始！
    public async UniTask TurnBattle(IBattlePlayer battlePlayer, IEnemy enemy, int TurnLimit = 0)
    {
        BattleObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        // 現在戦闘中の敵・味方を保存
        currentBattlePlayer = battlePlayer;
        currentEnemy = enemy;
        var turnCount = 0;

        if (AttackUI == null)
        {
            AttackUI = GameObject.Find("GunAttack");
            Debug.Log(AttackUI);
        }
        var isEnd = false;

        // 両者生存で続行
        while (IsCharacterActive(battlePlayer, enemy) && (TurnLimit == 0 || turnCount < TurnLimit))
        {
            AttackUI.SetActive(false);

            if (turnCount == 0 && TurnLimit != 0)
            {
                await UniTask.WaitForSeconds(1);
                await informationLabel.PlayLabelTask("亡骸から人型のもやが出てきた！");
                //await informationLabel.PlayLabelTask(TurnLimit + "ターン耐久で勝利！");
            }

            battlePlayer.SetBattleCommandActive(true);

            while (!battlePlayer.IsEnter())
            {
                await UniTask.WaitForFixedUpdate();
            }


            battlePlayer.SetBattleCommandActive(false);

            isEnd = false;

            // プレイヤーが行動を行います。
            battlePlayer.Action(x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            isEnd = false;

            var passSkill = battlePlayer.GetUsedSkillName();

            if (enemy.IsPassSkill(passSkill))
            {
                // すでに6発撃っており、花冠を持っていないとき
                if (magicBullet == 6 && !canMagickBulletAvoid)
                {
                    await informationLabel.PlayLabelTask("撃ち出された弾は敵に向かわず\n弾道を変え自身の胸めがけて飛んできた！");
                    await informationLabel.PlayLabelTask("9999ダメージを受けた！");
                    await informationLabel.PlayLabelTask("GameOver");
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
                }
                ++magicBullet;
            }

            // 敵がダメージを受けます。
            enemy.EnemyDamage(passSkill, battlePlayer.GetAttackPoint(), x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }

            if (!IsCharacterActive(battlePlayer, enemy)) { break; }

            await UniTask.Yield(PlayerLoopTiming.Update);

            // 敵が攻撃を行います。
            await informationLabel.PlayLabelTask("敵の攻撃！");
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

            // プレイヤーがダメージを受けます。
            isEnd = false;

            // プレイヤーが行動を行います。
            battlePlayer.Damage(sumdamage, x => isEnd = x);

            while (!isEnd)
            {
                await UniTask.WaitForFixedUpdate();
            }
            ++turnCount;
        }

        // 戦闘終了のため、戦闘中の敵・味方を削除
        currentEnemy = null;
        currentBattlePlayer = null;

        // 味方の勝利！
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
                await informationLabel.PlayLabelTask("人型のもやは霧散した！");
                var bag = GameObject.Find("Bag").GetComponent<Bag>();
                bag.Content.Add(ItemManager.ItemData[ItemIndex]);

                await informationLabel.PlayLabelTask("花冠を手に入れた！");
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
        // 敵の勝利！
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

    // 技能のダイスロール
    // 戻り値：ダイスロールの結果
    // 引数1:技能の名前
    public async UniTask<JudgementType> SkillDiceRoll(string skillName)
    {
        // 技能名を表示
        await informationLabel.PlayLabelTask(skillName + "!");

        // 対応したスキルの値を返却
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
            Moderate("どこかで鍵の開いた音がした！");
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
        //未セットの場合はnullがあり得る
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("自身アイテムを指定▼");
        PopupProperty.intValue = EditorGUILayout.Popup(
            PopupProperty.intValue,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );

        serializedObject.ApplyModifiedProperties();
    }
}
#endif
