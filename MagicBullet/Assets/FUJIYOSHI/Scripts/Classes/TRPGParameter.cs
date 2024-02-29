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

    [Header("�_�C�X��")]
    public DiceParameter[] DiceParameters;
    [Header("���Z�l��")]
    public int AddValue;
}
