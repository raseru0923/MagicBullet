using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool canOpen;
    private Animator animator;
    private AudioSource audioSource;

    [SerializeField] AudioClip OpenClip;
    [SerializeField] AudioClip CloseClip;

    private void OnEnable()
    {
        animator = this.GetComponent<Animator>();
        audioSource = Camera.main.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (canOpen && !animator.GetBool("IsOpen") && Input.GetKeyDown(KeyCode.F))
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

    public void PlayOpenAudio()
    {
        audioSource.PlayOneShot(OpenClip);
    }
    
    public void PlayCloseAudio()
    {
        audioSource.PlayOneShot(CloseClip);
    }
}
