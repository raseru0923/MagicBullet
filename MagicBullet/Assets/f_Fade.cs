using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(f_ColorLinear))]
public class f_Fade : MonoBehaviour
{
    [Header("フェードインの秒数")]
    [SerializeField] private float FadeInSpeed = 1;
    [Header("フェードアウトの秒数")]
    [SerializeField] private float FadeOutSpeed = 1;
    private f_ColorLinear colorLinear;

    private void OnEnable()
    {
        colorLinear = this.GetComponent<f_ColorLinear>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(FadeIn());
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(FadeOut());
        }
    }

    // フェードイン(徐々に明るく)
    public IEnumerator FadeIn()
    {
        Debug.Log("FadeIn");
        Color endColor = colorLinear.StartColor;
        endColor.a = 0;
        yield return StartCoroutine(colorLinear.LinearColor(colorLinear.StartColor, endColor, FadeInSpeed));
    }

    // フェードアウト(徐々に暗く)
    public IEnumerator FadeOut()
    {
        Debug.Log("FadeOut");
        Color endColor = colorLinear.StartColor;
        endColor.a = 0;
        yield return StartCoroutine(colorLinear.LinearColor(endColor, colorLinear.StartColor, FadeOutSpeed));
    }
}
