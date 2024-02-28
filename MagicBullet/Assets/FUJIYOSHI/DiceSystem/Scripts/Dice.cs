using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

public class Dice : MonoBehaviour
{
    // 目の数
    public int diceValue = 6;
    // どれくらいの力で振るのか(回転秒数に反映)
    [SerializeField] float RollForce;
    // ダイスの目を表示するモノ
    [SerializeField] Text DiceText;

    // 振って数値を返却
    private int DiceRollResult(int diceMin, int diceValue)
    {
        return Random.Range(diceMin, diceValue + diceMin);
    }

    public async UniTask<int> DiceRoll(int diceMin)
    {
        await Roll(diceMin, diceValue);
        int result = DiceRollResult(diceMin, diceValue);
        DiceText.text = result.ToString();
        return result;
    }

    public async UniTask<int> NormalDiceRoll()
    {
        return await DiceRoll(1);
    }

    private async UniTask Roll(int diceMin, int diceValue, CancellationToken ct = default)
    {
        float timer = 0;
        while (timer < RollForce)
        {
            DiceText.text = DiceRollResult(diceMin, diceValue).ToString();
            timer += Time.deltaTime;
            await UniTask.Yield(PlayerLoopTiming.Update, ct);
        }
    }
}
