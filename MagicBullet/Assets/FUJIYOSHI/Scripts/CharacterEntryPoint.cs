using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CharacterEntryPoint : MonoBehaviour
{
    private Image myImage;
    // �Ó]�p�̃}�X�N�I�u�W�F�N�g
    [SerializeField] private GameObject BlackMask;

    private void OnEnable()
    {
        // ���g�̃C���[�W���擾
        myImage = this.GetComponent<Image>();
    }

    // �폜
    public void Remove()
    {
        myImage.sprite = null;
        myImage.color = Color.clear;
    }

    // �o�^
    public void Joint(Image characterImage)
    {
        myImage = characterImage;
        myImage.color = Color.white;
    }

    public void Joint(Sprite characterSprite)
    {
        myImage.sprite = characterSprite;
        myImage.color = Color.white;
    }

    // �Ó]�̐؂�ւ�
    public void SetBlackOut(bool isActive)
    {
        BlackMask.SetActive(isActive);
    }

    public void EntryPointReset()
    {
        // �L�����N�^�[���\��
        Remove();
        // �u���b�N�A�E�g����
        SetBlackOut(false);
    }
}

// �G���g���[�|�C���g�ɑ΂��鑀��̎��
public enum ENTRYPOINTOPERATIONTYPE
{
    REMOVE,
    JOINT,
    BLACKOUT,
}
