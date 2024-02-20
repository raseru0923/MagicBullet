using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : MonoBehaviour, ITurn
{
    private bool isSelectCommand = false;

    // 毎フレーム呼び出し
    public bool Action()
    {
        // コマンドを選択
        if (!isSelectCommand)
        {
            return false;
        }

        // ダイスロール


        // ダイスロールの結果


        return true;
    }

    public void Command()
    {
        // 技能をenumにしてほしい
        isSelectCommand = true;
    }

    public void DiceRoll()
    {
        //Dealer.Instance.HundredDiceRoll(50);
    }

    public void Result()
    {

    }
}
