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

    // SAN�l�̔���
    // ���g�̌��݂�SAN�l�Ǝ��s���A��������SAN�l�̌������@
    public async UniTask<int> SANDiceRoll(int nowSAN, int minA, int maxA,int minB, int maxB)
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
}