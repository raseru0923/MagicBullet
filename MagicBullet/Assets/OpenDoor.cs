using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

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

    public async void OpenningDoor()
    {
        while (this.GetComponent<Animator>())
        {
            await UniTask.WaitForFixedUpdate();
        }
        this.GetComponent<Animator>().SetBool("IsOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Animators.Remove(this.GetComponent<Animator>());
        }
    }

}
