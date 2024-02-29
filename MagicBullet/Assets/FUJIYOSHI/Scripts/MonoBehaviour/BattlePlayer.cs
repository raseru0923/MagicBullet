using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦闘時のプレイヤー
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("戦闘用コマンドを設定▼")]
    [SerializeField] private GameObject BattleCommand;

    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }
}
