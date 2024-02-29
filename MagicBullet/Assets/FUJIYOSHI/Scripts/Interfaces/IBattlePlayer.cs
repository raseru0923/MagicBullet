using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattlePlayer
{
    // 戦闘用コマンドの動作状態切替
    // 引数1:動作しているか。
    public void SetBattleCommandActive(bool isActive);

    // 攻撃に使用した武器の名前を返却
    public string GetUsedWeaponName();

    // ダメージを受ける
    public void Damage(int damage);
}
