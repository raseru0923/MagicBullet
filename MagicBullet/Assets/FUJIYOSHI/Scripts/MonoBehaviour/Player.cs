using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    // ���g�̃o�b�O
    public Bag MyBag;

    // Update is called once per frame
    private bool canDoorOperation;
    public List<Animator> Animators = new List<Animator>();

    [SerializeField] private GameObject Guide;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // �����J��
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            GameMaster.Instance.IsSelectItem = false;
            MyBag.CallInventory();
        }

        // �h�A�̊J�����͂���
        if (Animators == null)
        {
            return;
        }

        if (canDoorOperation && Input.GetKeyDown(KeyCode.F))
        {
            var animator = PassAnimator(Animators, animator => animator.GetComponent<Operation>() != null);

            if (animator != null && !animator.GetComponent<Operation>().IsOperation)
            {
                GameMaster.Instance.Moderate("���͌ł�������Ă���");
                return;
            }

            animator = PassAnimator(Animators, animator => animator.GetComponent<ToBattleDoor>() != null);

            // �o�g���J�ډ\�Ȏ�
            if (animator != null)
            {
                if (GameMaster.Instance.canFinalBattle) { ToBattleScene(); return; }
                GameMaster.Instance.Moderate("���͌ł�������Ă���");
                return;
            }
            foreach (var item in Animators)
            {
                if (!item.GetBool("IsOpen"))
                {
                    item.SetBool("IsOpen", true);
                }
                else
                {
                    item.SetBool("IsOpen", false);
                }
            }
        }
        // �h�A�̊J�����I���
    }

    // �����Ɉ�v�����A�j���[�^�[��ԋp
    private Animator PassAnimator(List<Animator> targetAnimators, Func<Animator, bool> terms)
    {
        foreach (var item in targetAnimators)
        {
            if (terms(item)) { return item; }
        }
        return null;
    }

    private void ToBattleScene()
    {
        if (!GameMaster.Instance.isFinalBattle)
        {
            Guide.SetActive(true);

            GameMaster.Instance.isFinalBattle = true;
            return;
        }
        // �����Ńo�g���V�[���ɑJ��
        var animator = PassAnimator(Animators, animator => animator.GetComponent<ToBattleDoor>() != null);
        if (animator != null) { animator.GetComponent<ToBattleDoor>().ToBattleScene(); }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("DoorEnter!");

            var otherAnimator = other.GetComponent<Animator>();

            // �h�A�̃A�j���[�^�[���擾
            if (!Animators.Contains(otherAnimator))
            {
                Animators.Add(otherAnimator);
                canDoorOperation = true;
            }
        }
    }
}
