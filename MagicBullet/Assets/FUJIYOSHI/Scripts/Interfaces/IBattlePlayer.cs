using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IBattlePlayer
{
    // �퓬�p�R�}���h�̓����Ԑؑ�
    // ����1:���삵�Ă��邩�B
    public void SetBattleCommandActive(bool isActive);

    // �U���Ɏg�p��������̖��O��ԋp
    public string GetUsedSkillName();

    // �U���l��ԋp
    public int GetAttackPoint();

    // �_���[�W���󂯂�
    public void Damage(int damage);

    // �s��
    public void Action(Action<bool> isEnd);

    // ���S
    // �߂�l:���S���Ă��邩
    public bool IsDie();

    // �s�����莞�ɌĂяo���B
    public void ActionEnter(string skillName);

    // �s�������肳��Ă��邩
    public bool IsEnter();

    // �������̏���
    public void Win();
}
