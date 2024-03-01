using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IBattlePlayer
{
    // 戦闘用コマンドの動作状態切替
    // 引数1:動作しているか。
    public void SetBattleCommandActive(bool isActive);

    // 攻撃に使用した武器の名前を返却
    public string GetUsedSkillName();

    // 攻撃値を返却
    public int GetAttackPoint();

    // ダメージを受ける
    public void Damage(int damage);

    // 行動
    public void Action(Action<bool> isEnd);

    // 死亡
    // 戻り値:死亡しているか
    public bool IsDie();

    // 行動決定時に呼び出す。
    public void ActionEnter(string skillName);

    // 行動が決定されているか
    public bool IsEnter();

    // 勝利時の処理
    public void Win();
}
