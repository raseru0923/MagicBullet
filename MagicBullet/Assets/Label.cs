using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Label : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private GameObject MainLabel;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            PlayLabel("é¿çsÅI");
        }

        
    }

    public void PlayLabel(string text)
    {
        StartCoroutine(PrintLabel(text));
    }

    IEnumerator PrintLabel(string text)
    {
        MainLabel.SetActive(true);

        LabelText.text = text;

        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        MainLabel.SetActive(false);
    }
}
