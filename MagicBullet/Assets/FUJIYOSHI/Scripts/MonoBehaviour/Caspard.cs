using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �J�X�p�[��
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP��")]
    [SerializeField] private int HP;

    [Header("�U���́�")]
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
        [Header("�_�C�X�̐���")]
        public int Count;
        [Header("�ڂ̐���")]
        public int Value;
    }

    [System.Serializable]
    public struct TRPGParameter
    {
        [Header("�_�C�X��")]
        public DiceParameter[] DiceParameters;
        [Header("���Z�l��")]
        public int AddValue;
    }
}
