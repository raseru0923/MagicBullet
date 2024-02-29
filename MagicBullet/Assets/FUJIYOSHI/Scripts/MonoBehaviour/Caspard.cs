using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カスパール
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP▼")]
    [SerializeField] private int HP;

    [Header("攻撃力▼")]
    [SerializeField] private TRPGParameter AttackParameter;

    public void EnemyDamage(float Damage)
    {

    }

    public float EnemyAttack()
    {
        return default;
    }

    [System.Serializable]
    public struct DiceParameter
    {
        [Header("ダイスの数▼")]
        public int Count;
        [Header("目の数▼")]
        public int Value;
    }

    [System.Serializable]
    public struct TRPGParameter
    {
        [Header("ダイス▼")]
        public DiceParameter[] DiceParameters;
        [Header("加算値▼")]
        public int AddValue;
    }
}
