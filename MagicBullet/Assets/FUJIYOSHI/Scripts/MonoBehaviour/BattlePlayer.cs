using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �퓬���̃v���C���[
public class BattlePlayer : MonoBehaviour
{
    [Header("�퓬�p�R�}���h��ݒ聥")]
    [SerializeField] private GameObject BattleCommand;

    // �퓬�p�R�}���h�̓����Ԑؑ�
    // ����1:���삵�Ă��邩�B
    public void SetBattleCommandActive(bool isActive)
    {
        BattleCommand.SetActive(isActive);
    }
}
