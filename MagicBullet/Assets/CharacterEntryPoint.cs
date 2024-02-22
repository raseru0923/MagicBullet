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

    private void Start()
    {
        // ���g�̃C���[�W���擾
        myImage = this.GetComponent<Image>();
    }

    // �폜
    public void Remove()
    {
        myImage = null;
    }

    // �o�^
    public void Joint(Image characterImage)
    {
        myImage = characterImage;
    }

    // �Ó]�̐؂�ւ�
    public void SetBlackOut(bool isActive)
    {
        BlackMask.SetActive(isActive);
    }
}
