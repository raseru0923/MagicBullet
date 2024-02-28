using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class Dealer : MonoBehaviour
{
    // ダイスの設計図
    [SerializeField] private GameObject DicePrefab;
    // ダイスを置く場所
    [SerializeField] private GameObject DiceRollSpace;
    // 通知
    public Label informationLabel;

    public static Dealer Instance;

    private void Awake()
    {
        Instance = this;
    }

    // ダイスロールの判定の種類です。
    public enum JudgementType
    {
        CRITICAL = 0,   // 大成功！ 1d100のみ使用
        SUCCESS,        // 成功
        FAIL,           // 失敗
        FUMBLE,         // 大失敗！ 1d100のみ使用
    }

    // 1d100のファンブル、クリティカルを追加したダイスロールの判定です。
    public async UniTask<JudgementType> HundredDiceRoll(int successRate)
    {
        int value = await SumDealerDiceRoll(1, 100);

        if (value <= 5) { return JudgementType.CRITICAL; }       // クリティカル
        if (value < successRate) { return JudgementType.SUCCESS; } // 成功
        if (value > 95) { return JudgementType.FUMBLE; }     // ファンブル
        return JudgementType.FAIL;                           // 失敗
    }

    // ダイスロールを振った順に配列に保存し、返却します。
    public async UniTask<int[]> DealerDiceRoll(int diceCount, int diceValue)
    {
        DestroyAllDice();

        int[] result = new int[diceCount];

        for (int i = 0; i < diceCount; i++)
        {
            result[i] = await OneDiceRoll(diceValue);
        }

        await WaitDiceDelete();

        return result;
    }

    // ダイスロールの合計の値を返却します。
    public async UniTask<int> SumDealerDiceRoll(int diceCount, int diceValue)
    {
        await informationLabel.PlayLabelTask(diceCount + " d " + diceValue);
        await informationLabel.PlayLabelTask("ダイスロール！");
        informationLabel.OnLabel(diceCount + " d " + diceValue);

        int sum = 0;

        foreach (var item in await DealerDiceRoll(diceCount, diceValue))
        {
            sum += item;
        }

        await informationLabel.PlayLabelTask(sum.ToString());

        return sum;
    }

    // 第一引数を基準にダイスロールの成否を判定します。
    public async UniTask<JudgementType> ReturnResultDiceRoll(int successRate, int diceCount, int diceValue)
    {
        var result = await SumDealerDiceRoll(diceCount, diceValue);

        // 失敗
        if (result < successRate)
        {
            return JudgementType.SUCCESS;
        }

        return JudgementType.FAIL;
    }

    // 一つのダイスを作成し、ダイスロールを行い値を返す
    private async UniTask<int> OneDiceRoll(int diceValue)
    {
        var Dice = await CreateDice(diceValue);

        // 10ダイスのみ特別な処理を行う。
        if (diceValue == 10)
        {
            return await Dice.DiceRoll(0);
        }

        return await Dice.NormalDiceRoll();
    }

    // 場にあるダイスをすべて削除します。
    private void DestroyAllDice()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }

    // ダイスを作成します。作ったダイスの情報を返却します。
    private async UniTask<Dice> CreateDice(int diceValue, CancellationToken ct = default)
    {
        // 設計図を使用し、ダイスを生成
        GameObject Dice = Instantiate(DicePrefab);

        await WaitOneFrame();

        Dice.transform.SetParent(DiceRollSpace.transform);

        var dice = Dice.GetComponent<Dice>();
        dice.diceValue = diceValue;
        return dice;
    }

    private async UniTask WaitDiceDelete()
    {
        await UniTask.WaitForSeconds(1);
        informationLabel.OFFLabel();
        DestroyAllDice();
    }

    private async UniTask WaitOneFrame(CancellationToken ct = default)
    {
        await UniTask.Yield(PlayerLoopTiming.Update, ct);
    }
}
