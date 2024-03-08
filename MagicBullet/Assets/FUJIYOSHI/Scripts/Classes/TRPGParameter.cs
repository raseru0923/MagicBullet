using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TRPGParameter
{
    [System.Serializable]
    public struct DiceParameter
    {
        [Header("�_�C�X�̐���")]
        public int Count;
        [Header("�ڂ̐���")]
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

    [Header("�_�C�X��")]
    public DiceParameter[] DiceParameters;
    [Header("���Z�l��")]
    public int AddValue;
}
