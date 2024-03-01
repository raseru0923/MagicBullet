using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// カスパール
public class Caspard : MonoBehaviour, IEnemy
{
    [Header("HP▼")]
    [SerializeField] private int HP;

    [Header("攻撃力▼")]
    [SerializeField] private TRPGParameter AttackParameter;

    [Header("効果のある武器の名前▼")]
    [SerializeField] private List<string> PassSkillNames;

    // IEnemy
    public void EnemyDamage(string passSkill, int Damage)
    {
        // ダメージ無効化
        // ※スキル制限の指定なしのときはダメージを食らいます。
        if (PassSkillNames != null && !IsPassSkill(passSkill))
        {
            return;
        }

        // ダメージを受ける
        HP -= Damage;

        // 死亡処理
        if (HP <= 0)
        {
            Destroy(this.gameObject);
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
        return default;
    }
}
