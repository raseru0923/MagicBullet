using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �퓬���̃v���C���[
public class BattlePlayer : MonoBehaviour, IBattlePlayer
{
    [Header("�퓬�p�R�}���h��ݒ聥")]
    [SerializeField] private GameObject BattleCommand;

    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }
}
