using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class Dealer : MonoBehaviour
{
    // �_�C�X�̐݌v�}
    [SerializeField] private GameObject DicePrefab;
    // �_�C�X��u���ꏊ
    [SerializeField] private GameObject DiceRollSpace;

    public static Dealer Instance;

    private void Awake()
    {
        Instance = this;
    }

    private async void Start()
    {

    }

    // �_�C�X���[���̔���̎�ނł��B
    public enum JudgementType
    {
        CRITICAL = 0,   // �听���I 1d100�̂ݎg�p
        SUCCESS,        // ����
        FAIL,           // ���s
        FUMBLE,         // �厸�s�I 1d100�̂ݎg�p
    }

    // 1d100�̃t�@���u���A�N���e�B�J����ǉ������_�C�X���[���̔���ł��B
    public async UniTask<JudgementType> HundredDiceRoll(int successRate)
    {
        int value = await SumDealerDiceRoll(100);

        Debug.Log(value);
        
        if (value <= 5) { return JudgementType.FUMBLE; }       // �厸�s
        if (value < successRate) { return JudgementType.FAIL; } // ���s
        if (value > 95) { return JudgementType.CRITICAL; }     // �N���e�B�J��
        return JudgementType.SUCCESS;                           // ����
    }

    // �_�C�X���[����U�������ɔz��ɕۑ����A�ԋp���܂��B
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

    // �_�C�X���[���̍��v�̒l��ԋp���܂��B
    public async UniTask<int> SumDealerDiceRoll(int diceValue, int diceCount = 1)
    {
        int sum = 0;

        foreach (var item in await DealerDiceRoll(diceValue, diceCount))
        {
            sum += item;
        }

        return sum;
    }

    // ����������Ƀ_�C�X���[���̐��ۂ𔻒肵�܂��B
    public async UniTask<JudgementType> ReturnResultDiceRoll(int successRate, int diceValue, int diceCount = 1)
    {
        var result = await SumDealerDiceRoll(diceValue, diceCount);

        Debug.Log(result);

        // ���s
        if (result < successRate)
        {
            return JudgementType.FAIL;
        }

        return JudgementType.SUCCESS;
    }

    // ��̃_�C�X���쐬���A�_�C�X���[�����s���l��Ԃ�
    private async UniTask<int> OneDiceRoll(int diceValue)
    {
        var Dice = await CreateDice(diceValue);

        // 10�_�C�X�̂ݓ��ʂȏ������s���B
        if (diceValue == 10)
        {
            return await Dice.DiceRoll(0);
        }

        return await Dice.NormalDiceRoll();
    }

    // ��ɂ���_�C�X�����ׂč폜���܂��B
    private void DestroyAllDice()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }

    // �_�C�X���쐬���܂��B������_�C�X�̏���ԋp���܂��B
    private async UniTask<Dice> CreateDice(int diceValue, CancellationToken ct = default)
    {
        // �݌v�}���g�p���A�_�C�X�𐶐�
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
