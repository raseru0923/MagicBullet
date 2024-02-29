using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦闘時のプレイヤー
public class BattlePlayer : MonoBehaviour
{
    [Header("戦闘用コマンドを設定▼")]
    [SerializeField] private GameObject BattleCommand;

    // 戦闘用コマンドの動作状態切替
    // 引数1:動作しているか。
    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }
}
