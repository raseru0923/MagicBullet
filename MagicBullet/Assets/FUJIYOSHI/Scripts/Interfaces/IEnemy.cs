using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// エネミーインターフェース
public interface IEnemy
{
    // ダメージを受ける
    // 1:使用武器の名前2:ダメージ量
    public void EnemyDamage(string passSkill, int Damage);

    // 攻撃値返却
    // 戻り値:ダメージ量
    public TRPGParameter GetAttackValue();

    // 死亡
    // 戻り値:死亡しているか
    public bool IsDie();
}
