using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �G�l�~�[�C���^�[�t�F�[�X
public interface IEnemy
{
    // �_���[�W���󂯂�
    // 1:�g�p����̔ԍ�2:�_���[�W��
    public void EnemyDamage(float Damage);

    // �U���l�ԋp
    // �߂�l:�_���[�W��
    public TRPGParameter GetAttackValue();
}
