using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

// 戦闘時のプレイヤー
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("戦闘用コマンドを設定▼")]
    [SerializeField] private GameObject BattleCommand;
    [SerializeField] private GameObject ActionList;

    [Header("最大HP▼")]
    [SerializeField] private int MAXHP;
    // 現在HP
    private int currentHP;

    private bool isDie = false;

    private bool isEnter = false;
    private string useSkillName = null;

    // IBattlePlayer
    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }

    // IBattlePlayer
    public string GetUsedSkillName()
    {
        return useSkillName;
    }

    // IBattlePlayer
    public int GetAttackPoint()
    {
        return 5;
    }

    // IBattlePlayer
    public void Damage(int damage)
    {
        // ダメージを受ける
        currentHP -= damage;

        // 死亡
        if (currentHP <= 0)
        {
            isDie = true;
        }
    }

    // IBattlePlayer
    public async void Action(Action<bool> isEnd)
    {
        isEnter = false;
        await GameMaster.Instance.SkillDiceRoll(useSkillName);

        isEnd?.Invoke(true);
    }

    // IBattlePlayer
    public bool IsDie()
    {
        return isDie;
    }

    // IBattlePlayer
    public void ActionEnter(string skillName)
    {
        Debug.Log("行動決定！");
        useSkillName = skillName;
        isEnter = true;
        // アクションリストを閉じる
        ActionList.SetActive(false);
    }

    // IBattlePlayer
    public bool IsEnter()
    {
        return isEnter;
    }

    // IBattlePlayer
    public void Win()
    {
        GameMaster.Instance.Moderate("戦闘終了！");
    }
}
