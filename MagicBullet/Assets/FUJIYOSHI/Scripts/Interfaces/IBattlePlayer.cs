using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattlePlayer
{
    // �퓬�p�R�}���h�̓����Ԑؑ�
    // ����1:���삵�Ă��邩�B
    public void SetBattleCommandActive(bool isActive);

    // �U���Ɏg�p��������̖��O��ԋp
    public string GetUsedWeaponName();

    // �_���[�W���󂯂�
    public void Damage(int damage);
}
