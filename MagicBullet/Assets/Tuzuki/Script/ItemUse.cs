using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

public class ItemUse : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;
    [SerializeField] private f_Label ItemLabel;

    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;

    /// <summary>
    /// �g�p����Ƃ��ɌĂ΂��
    /// </summary>
    public async UniTask UseItem()
    {
        print("�g�p�I");

        // �g�p���鏈����ǉ�

        onPickUp.Invoke();
    }
}
