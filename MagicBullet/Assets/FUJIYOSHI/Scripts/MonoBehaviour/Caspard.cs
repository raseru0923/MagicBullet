using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// カスパール
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("最大HP▼")]
    [SerializeField] private int MAXHP;
    private int currentHP;

    [Header("攻撃力▼")]
    [SerializeField] private TRPGParameter AttackParameter;

    [Header("効果のある武器の名前▼")]
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
            // 使用技能が攻撃技能でないときは終了
            if (item == passSkill) { isEnd?.Invoke(true); return; }
        }
        // ダメージ無効化
        // ※スキル制限の指定なしのときはダメージを食らいます。
        if (PassSkillNames != null && !IsPassSkill(passSkill))
        {
            await GameMaster.Instance.informationLabel.PlayLabelTask("無効化！");
            isEnd?.Invoke(true);
            return;
        }

        // ダメージを受ける
        currentHP -= Damage;
        GameMaster.Instance.AttackUI.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(GunClip);
        await GameMaster.Instance.informationLabel.PlayLabelTask(Damage + "ダメージを与えた！");

        // 死亡処理
        if (currentHP <= 0)
        {
            isDie = true;
        }

        isEnd?.Invoke(true);
    }

    // 効果のある武器なのか確認
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
        GameMaster.Instance.Moderate("カスパールに敗北した！");
    }
}
