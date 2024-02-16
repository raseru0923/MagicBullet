using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 名前を保存するクラスです
// 拡張子の削除などを行うことができます。

public class Name
{
    // 名前を保存
    public string value = "";

    // 拡張子削除
    public string DeleteExtension()
    {
        int dotIndex = 0;
        string NoneExtensionName = value;
        bool isEqual = false;

        for (int i = 0; i < NoneExtensionName.Length; i++)
        {
            isEqual = EqualString(i, NoneExtensionName, ".");
            // .が来たら値を保存
            dotIndex = (isEqual) ? i : dotIndex;
            // trueなら走査を完了
            i = (isEqual) ? NoneExtensionName.Length : i;
        }

        NoneExtensionName = NoneExtensionName.Substring(0, dotIndex);

        return NoneExtensionName;
    }

    private bool EqualString(int startIndex, string targetString, string searchString)
    {
        // 検索範囲
        int searchLength = startIndex + searchString.Length;

        // 検索範囲が検索対象の文字列の長さ以下、かつ
        // 
        if (
            searchLength <= targetString.Length &&
            targetString.Substring(startIndex, searchString.Length) == searchString
            )
        {
            return true;
        }
        return false;
    }
}
