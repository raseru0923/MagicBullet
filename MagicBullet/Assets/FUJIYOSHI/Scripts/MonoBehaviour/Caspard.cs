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

    [Header("効果のある武器の名前▼")]
    [SerializeField] private List<string> PassWeaponNames;

    // IEnemy
    public void EnemyDamage(int Damage)
    {

    }

    // IEnemy
    public TRPGParameter GetAttackValue()
    {
        return AttackParameter;
    }

    // IEnemy
    public bool IsDie()
    {
        return default;
    }
}
