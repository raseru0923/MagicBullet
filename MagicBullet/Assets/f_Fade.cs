using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_Fade : MonoBehaviour
{
    [Header("フェードに使用するイメージ")]
    [SerializeField] private Image FadeImage;
    [Header("フェードインのスピード")]
    [SerializeField] private float FadeInSpeed = 1;
    [Header("フェードアウトのスピード")]
    [SerializeField] private float FadeOutSpeed = 1;

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
        yield return FadeColor(1, i => i <= 0, -Time.deltaTime * FadeInSpeed);
    }

    // フェードアウト(徐々に暗く)
    public IEnumerator FadeOut()
    {
        Debug.Log("FadeOut");
        yield return FadeColor(0, i => i >= 1, Time.deltaTime * FadeOutSpeed);
    }

    // フェード
    // 1:初期値2:終了条件3:加算値
    private IEnumerator FadeColor(float initialValue, Func<float, bool> isEnd, float add)
    {
        float alphaValue = initialValue;
        Color ImageColor = FadeImage.color;

        while (isEnd(alphaValue))
        {
            ImageColor.a = alphaValue;
            FadeImage.color = ImageColor;
            alphaValue += add;
            yield return null;
        }
    }
}
