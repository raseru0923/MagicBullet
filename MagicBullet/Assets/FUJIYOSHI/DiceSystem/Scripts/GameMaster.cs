using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class GameMaster : f_Dealer
{
    // 自身のインスタンス
    public static GameMaster Instance;

    // 現在戦闘中の敵・味方
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

    // 司会進行
    public void Moderate(string printText)
    {
        informationLabel.PlayLabel(printText);
    }

    // SAN値の判定
    // 自身の現在のSAN値と失敗時、成功時のSAN値の減少方法
    public async UniTask<int> SANDiceRoll(int nowSAN, int minA, int maxA, int minB, int maxB)
    {
        await informationLabel.PlayLabelTask("SAN値減少！ " + minA + " / "
             + "1 d " + (maxB - minB + 1));

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

        await informationLabel.PlayLabelTask(result + "減少！");

        return result;
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

        informationLabel.PlayLabel(targetItem.AssesmentItem());

        return targetItem;
    }

    // ターン性バトル開始！
    public async UniTask TurnBattle(IBattlePlayer battlePlayer, IEnemy enemy)
    {
        // 現在戦闘中の敵・味方を保存
        currentBattlePlayer = battlePlayer;
        currentEnemy = enemy;

        // 両者生存で続行
        while (IsCharacterActive(battlePlayer, enemy))
        {
            // プレイヤーが行動を選択します。
            battlePlayer.SetBattleCommandActive(true);

            while (!battlePlayer.IsEnter())
            {
                await UniTask.WaitForFixedUpdate();
            }

            battlePlayer.SetBattleCommandActive(false);

            // プレイヤーが行動を行います。
            await SkillDiceRoll("拳銃");

            // 敵が攻撃を行います。
        }

        // 戦闘終了のため、戦闘中の敵・味方を削除
        currentEnemy = null;
        currentBattlePlayer = null;
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
