using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool canOpen;
    private Animator animator;

    private void OnEnable()
    {
        animator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        if (canOpen && !animator.GetBool("IsOpen"))
        {
            animator.SetBool("IsOpen", true);
        }
        if (!canOpen && animator.GetBool("IsOpen"))
        {
            animator.SetBool("IsOpen", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = false;
        }
    }
}
