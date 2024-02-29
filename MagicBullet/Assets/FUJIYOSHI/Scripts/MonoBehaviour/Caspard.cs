using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// カスパール
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP▼")]
    [SerializeField] private int HP;

    [Header("攻撃力▼")]
    [SerializeField] private TRPGParameter AttackParameter;

    // IEnemy
    public void EnemyDamage(float Damage)
    {

    }

    // IEnemy
    public TRPGParameter GetAttackValue()
    {
        return AttackParameter;
    }
}
