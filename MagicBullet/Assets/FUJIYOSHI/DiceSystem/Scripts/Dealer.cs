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

    public static Dealer Instance;

    private void Awake()
    {
        Instance = this;
    }

    private async void Start()
    {

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
        int value = await SumDealerDiceRoll(100);

        Debug.Log(value);
        
        if (value <= 5) { return JudgementType.FUMBLE; }       // 大失敗
        if (value < successRate) { return JudgementType.FAIL; } // 失敗
        if (value > 95) { return JudgementType.CRITICAL; }     // クリティカル
        return JudgementType.SUCCESS;                           // 成功
    }

    // ダイスロールを振った順に配列に保存し、返却します。
    public async UniTask<int[]> DealerDiceRoll(int diceValue, int diceCount = 1)
    {
        DestroyAllDice();

        int[] result = new int[diceCount];

        for (int i = 0; i < diceCount; i++)
        {
            result[i] = await OneDiceRoll(diceValue);
        }

        StartCoroutine(WaitDiceDelete());
        return result;
    }

    // ダイスロールの合計の値を返却します。
    public async UniTask<int> SumDealerDiceRoll(int diceValue, int diceCount = 1)
    {
        int sum = 0;

        foreach (var item in await DealerDiceRoll(diceValue, diceCount))
        {
            sum += item;
        }

        return sum;
    }

    // 第一引数を基準にダイスロールの成否を判定します。
    public async UniTask<JudgementType> ReturnResultDiceRoll(int successRate, int diceValue, int diceCount = 1)
    {
        var result = await SumDealerDiceRoll(diceValue, diceCount);

        Debug.Log(result);

        // 失敗
        if (result < successRate)
        {
            return JudgementType.FAIL;
        }

        return JudgementType.SUCCESS;
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

        await UniTask.Yield(PlayerLoopTiming.Update, ct);

        Dice.transform.SetParent(DiceRollSpace.transform);

        var dice = Dice.GetComponent<Dice>();
        dice.diceValue = diceValue;
        return dice;
    }

    private IEnumerator WaitDiceDelete(float WaitTime = 1)
    {
        yield return new WaitForSeconds(WaitTime);
        DestroyAllDice();
    }
}
