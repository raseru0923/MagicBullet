using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// �J�X�p�[��
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP��")]
    [SerializeField] private int HP;

    [Header("�U���́�")]
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
