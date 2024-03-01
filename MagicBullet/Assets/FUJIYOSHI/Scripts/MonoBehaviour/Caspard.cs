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
    [SerializeField] private List<string> PassSkillNames;

    private bool isDie = false;

    // IEnemy
    public void EnemyDamage(string passSkill, int Damage)
    {
        // �_���[�W������
        // ���X�L�������̎w��Ȃ��̂Ƃ��̓_���[�W��H�炢�܂��B
        if (PassSkillNames != null && !IsPassSkill(passSkill))
        {
            GameMaster.Instance.Moderate("�������I");
            return;
        }

        // �_���[�W���󂯂�
        HP -= Damage;
        GameMaster.Instance.Moderate(Damage + "�_���[�W��^�����I");

        // ���S����
        if (HP <= 0)
        {
            isDie = true;
        }
    }

    // ���ʂ̂��镐��Ȃ̂��m�F
    bool IsPassSkill(string passSkill)
    {
        bool isPass = false;

        foreach (var item in PassSkillNames)
        {
            if (passSkill == item)
            {
                isPass = true;
            }
        }

        return isPass;
    }

    // IEnemy
    public TRPGParameter GetAttackValue()
    {
        return AttackParameter;
    }

    // IEnemy
    public bool IsDie()
    {
        return isDie;
    }
}
