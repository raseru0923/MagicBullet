using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 自身のバッグ
    [SerializeField] private Bag MyBag;

    // Update is called once per frame
    private bool canOpen;
    private Animator animator;
    private BoxCollider boxCollider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            MyBag.PrintInventory();
        }

        if (animator == null)
        {
            return;
        }

        if (canOpen && Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("IsOpen", true);
        }
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
