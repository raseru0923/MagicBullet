using System.Collections;
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

    private void Start()
    {
        currentHP = MAXHP;
    }

    // IEnemy
    public void EnemyDamage(string passSkill, int Damage)
    {
        // ダメージ無効化
        // ※スキル制限の指定なしのときはダメージを食らいます。
        if (PassSkillNames != null && !IsPassSkill(passSkill))
        {
            GameMaster.Instance.Moderate("無効化！");
            return;
        }

        // ダメージを受ける
        currentHP -= Damage;
        GameMaster.Instance.Moderate(Damage + "ダメージを与えた！");

        // 死亡処理
        if (currentHP <= 0)
        {
            isDie = true;
        }
    }

    // 効果のある武器なのか確認
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

    // IEnemy
    public void EnemyWin()
    {
        GameMaster.Instance.Moderate("カスパールに敗北した！");
    }
}
