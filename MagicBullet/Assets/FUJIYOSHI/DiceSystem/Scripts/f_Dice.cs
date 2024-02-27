using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

public class f_Dice : MonoBehaviour
{
    // �ڂ̐�
    public int diceValue = 6;
    // �ǂꂭ�炢�̗͂ŐU��̂�(��]�b���ɔ��f)
    [SerializeField] float RollForce;
    // �_�C�X�̖ڂ�\�����郂�m
    [SerializeField] Text DiceText;

    // �U���Đ��l��ԋp
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
