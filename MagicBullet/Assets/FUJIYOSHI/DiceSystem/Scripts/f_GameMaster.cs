using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class f_GameMaster : f_Dealer
{

    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X");
            await SANDiceRoll(50, 1, 1, 1, 3);
        }
    }

    // SAN値の判定
    // 自身の現在のSAN値と失敗時、成功時のSAN値の減少方法
    public async UniTask<int> SANDiceRoll(int nowSAN, int minA, int maxA,int minB, int maxB)
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
}
