using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 戦闘時のプレイヤー
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("戦闘用コマンドを設定▼")]
    [SerializeField] private GameObject BattleCommand;
    private bool isEnter = false;

    // IBattlePlayer
    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }

    // IBattlePlayer
    public string GetUsedWeaponName()
    {
        return default;
    }

    // IBattlePlayer
    public void Damage(int damage)
    {

    }

    // IBattlePlayer
    public void Action()
    {

    }

    // IBattlePlayer
    public bool IsDie()
    {
        return default;
    }

    // IBattlePlayer
    public void ActionEnter()
    {
        Debug.Log("行動決定！");
        isEnter = true;
    }

    // IBattlePlayer
    public bool IsEnter()
    {
        return isEnter;
    }
}
