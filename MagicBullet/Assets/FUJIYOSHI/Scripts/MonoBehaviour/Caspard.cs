using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// �J�X�p�[��
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("�ő�HP��")]
    [SerializeField] private int MAXHP;
    private int currentHP;

    [Header("�U���́�")]
    [SerializeField] private TRPGParameter AttackParameter;

    [Header("���ʂ̂��镐��̖��O��")]
    [SerializeField] private List<string> PassSkillNames;

    private bool isDie = false;

    [SerializeField] private AudioClip GunClip;

    private void Start()
    {
        currentHP = MAXHP;
    }

    // IEnemy
    public async void EnemyDamage(string passSkill, int Damage, Action<bool> isEnd)
    {
        if (Damage == 0) { isEnd?.Invoke(true); return; }
        StatusManager.Instance.SetMode(58);
        foreach (var item in StatusManager.Instance.GetNames())
        {
            // �g�p�Z�\���U���Z�\�łȂ��Ƃ��͏I��
            if (item == passSkill) { isEnd?.Invoke(true); return; }
        }
        // �_���[�W������
        // ���X�L�������̎w��Ȃ��̂Ƃ��̓_���[�W��H�炢�܂��B
        if (PassSkillNames != null && !IsPassSkill(passSkill))
        {
            await GameMaster.Instance.informationLabel.PlayLabelTask("�������I");
            isEnd?.Invoke(true);
            return;
        }

        // �_���[�W���󂯂�
        currentHP -= Damage;
        GameMaster.Instance.AttackUI.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(GunClip);
        await GameMaster.Instance.informationLabel.PlayLabelTask(Damage + "�_���[�W��^�����I");

        // ���S����
        if (currentHP <= 0)
        {
            isDie = true;
        }

        isEnd?.Invoke(true);
    }

    // ���ʂ̂��镐��Ȃ̂��m�F
    public bool IsPassSkill(string passSkill)
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

    // IEnemy
    public void EnemyWin()
    {
        GameMaster.Instance.Moderate("�J�X�p�[���ɔs�k�����I");
    }
}
