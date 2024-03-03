using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] AudioClip OpenClip;
    [SerializeField] AudioClip CloseClip;

    private void OnEnable()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
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
