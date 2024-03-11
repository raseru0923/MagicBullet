using System.Collections;
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
    private bool canOpen;
    private Animator animator;
    private BoxCollider boxCollider;

    [SerializeField] private GameObject Guide;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            MyBag.CallInventory();
        }

        if (animator == null)
        {
            return;
        }

        if (canOpen && Input.GetKeyDown(KeyCode.F))
        {
            // �o�g���J�ډ\�Ȏ�
            if (animator.gameObject.GetComponent<ToBattleDoor>() != null)
            {
                if (GameMaster.Instance.canFinalBattle) { ToBattleScene(); return; }
                GameMaster.Instance.Moderate("���͌ł�������Ă���");
                return;
            }
            animator.SetBool("IsOpen", true);
        }
    }

    private void ToBattleScene()
    {
        if (!GameMaster.Instance.isFinalBattle)
        {
            Guide.SetActive(true);

            GameMaster.Instance.isFinalBattle = true;
            return;
        }
        animator.gameObject.GetComponent<ToBattleDoor>().ToBattleScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("DoorEnter!");

            if (animator != null)
            {
                animator.SetBool("IsOpen", false);
            }

            animator = other.GetComponent<Animator>();
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("DoorExit!");

            other.GetComponent<Animator>().SetBool("IsOpen", false);

            animator = null;

            canOpen = false;
        }
    }
}
