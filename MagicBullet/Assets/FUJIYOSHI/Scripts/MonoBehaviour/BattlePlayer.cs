using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �퓬���̃v���C���[
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("�퓬�p�R�}���h��ݒ聥")]
    [SerializeField] private GameObject BattleCommand;

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
    public int Attack()
    {
        return default;
    }
}
