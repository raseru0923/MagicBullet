using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_KeyNumberCombertion
{
    // 数字キーと対応した数値を返却します。
    public int KeyNumberToInteger()
    {
        // 呼び出されたときに現在キーが押されているかをチェック
        if (Input.anyKey)
        {
            return AllKeyNumberCheck();
        }
        return -1;
    }

    // すべての数字キーを検索し、trueなものに対応した数字を返却します。
    private int AllKeyNumberCheck()
    {
        // 数字キーの0に割り当てられた整数値
        const int ALPHAZEROINTEGER = 48;

        for (int i = 0; i < 10; i++)
        {
            // 整数値からKeyCode型に変更し、値を確認する。
            // trueなら対応した数値を返却する。
            if (Input.GetKey((KeyCode)(ALPHAZEROINTEGER + i)))
            {
                return i;
            }
        }
        return -1;
    }
}
