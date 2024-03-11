using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

// �G�l�~�[�C���^�[�t�F�[�X
public interface IEnemy
{
    // �_���[�W���󂯂�
    // 1:�g�p����̖��O2:�_���[�W��
    public void EnemyDamage(string passSkill, int Damage, Action<bool> isEnd);

    // �U���l�ԋp
    // �߂�l:�_���[�W��
    public TRPGParameter GetAttackValue();

    // ���S
    // �߂�l:���S���Ă��邩
    public bool IsDie();

    // �������̏���
    public void EnemyWin();

    public bool IsPassSkill(string passSkill);
}
