using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    // 自身のバッグ
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
            // バトル遷移可能な時
            if (animator.gameObject.GetComponent<ToBattleDoor>() != null)
            {
                if (GameMaster.Instance.canFinalBattle) { ToBattleScene(); return; }
                GameMaster.Instance.Moderate("扉は固く閉ざされている");
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
