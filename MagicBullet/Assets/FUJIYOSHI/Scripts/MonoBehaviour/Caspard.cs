using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// JXp[
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP¥")]
    [SerializeField] private int HP;

    [Header("UÍ¥")]
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
        [Header("_CXÌ¥")]
        public int Count;
        [Header("ÚÌ¥")]
        public int Value;
    }

    [System.Serializable]
    public struct TRPGParameter
    {
        [Header("_CX¥")]
        public DiceParameter[] DiceParameters;
        [Header("ÁZl¥")]
        public int AddValue;
    }
}
