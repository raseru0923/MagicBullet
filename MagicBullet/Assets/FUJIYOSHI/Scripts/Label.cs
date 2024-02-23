using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Label : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private GameObject MainLabel;

    private void Update()
    {

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
        MainLabel.SetActive(true);

        LabelText.text = text;

        yield return null;

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        MainLabel.SetActive(false);
    }
}
