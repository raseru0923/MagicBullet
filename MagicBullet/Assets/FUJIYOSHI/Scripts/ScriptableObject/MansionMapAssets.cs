using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MansionMapAssets")]
public class MansionMapAssets : ScriptableObject
{
    // �V���A���C�Y����Ă��Ă�private�͓�����������
    [SerializeField] private GameObject[] mapAssets;

    [Header("------------------------------------\n�ǉ�����}�b�v�A�Z�b�g�̃e�N�X�`���[���w��\n------------------------------------")]
    [SerializeField] private Sprite mapAssetSprite;

    // public�ȃv���p�e�B��public�ȕϐ��Ɠ��������K��
    public GameObject[] MapAssets
    {
        set { mapAssets = value; }
        get { return mapAssets; }
    }

    public Sprite MapAssetSprite
    {
        get { return mapAssetSprite; }
    }
}
