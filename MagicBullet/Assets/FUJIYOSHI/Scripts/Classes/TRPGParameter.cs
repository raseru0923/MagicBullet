using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TRPGParameter
{
    [System.Serializable]
    public struct DiceParameter
    {
        [Header("ダイスの数▼")]
        public int Count;
        [Header("目の数▼")]
        public int Value;
    }

    public string DiceText
    {
        get
        {
            string diceText = null;
            foreach (var item in DiceParameters)
            {
                diceText += item.Count + " d " + item.Value + " + ";
            }
            diceText += AddValue;
            return diceText;
        }
    }

    [Header("ダイス▼")]
    public DiceParameter[] DiceParameters;
    [Header("加算値▼")]
    public int AddValue;
}
