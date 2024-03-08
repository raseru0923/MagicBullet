using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class f_Label : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private GameObject MainLabel;
    [SerializeField] private AudioClip ClickClip;
    private AudioSource audioSource;

    private void OnEnable()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
    }

    public void PlayLabel(string text)
    {
        StartCoroutine(PrintLabel(text));
    }

    public async UniTask PlayLabelTask(string text)
    {
        await PrintLabel(text);
    }

    IEnumerator PrintLabel(string text)
    {
        audioSource.PlayOneShot(ClickClip);

        MainLabel.SetActive(true);

        LabelText.text = text;

        yield return null;

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        MainLabel.SetActive(false);
    }

    public void OnLabel(string text)
    {
        audioSource.PlayOneShot(ClickClip);
        MainLabel.SetActive(true);

        LabelText.text = text;
    }

    public void OffLabel()
    {
        MainLabel.SetActive(false);
    }
}
