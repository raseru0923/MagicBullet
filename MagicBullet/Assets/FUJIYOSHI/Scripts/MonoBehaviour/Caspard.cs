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

    [Header("���ʂ̂��镐��̖��O��")]
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
