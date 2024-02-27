using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_ColorLinear : MonoBehaviour
{
    [Header("開始時にリニア")]
    [SerializeField] private bool PlayOnAwake = false;
    [Header("リニアするイメージを指定")]
    [SerializeField] private Image LinearImage;
    [Header("リニアの秒数")]
    [SerializeField] private float FlashSeconds = 1;
    [Header("スタート色とエンド色")]
    public Color StartColor = Color.black;
    [SerializeField] Color EndColor = Color.clear;

    // 稼働中のコルーチン
    private Coroutine operationCoroutine;

    void OnEnable()
    {
        if (PlayOnAwake)
        {
            operationCoroutine = StartCoroutine(LinearColor(StartColor, EndColor, FlashSeconds));
        }
    }

    void OnDisable()
    {
        if (operationCoroutine != null)
        {
            StopCoroutine(operationCoroutine);
        }
    }

    // 色の線形補間
    // 1:初めの色2:終わりの色3:秒数
    public IEnumerator LinearColor(Color startColor, Color endColor, float flashSeconds)
    {
        float ratio = 0;

        while (ratio < 1)
        {
            LinearImage.color = (1 - ratio) * startColor + endColor * ratio;
            ratio += Time.deltaTime * (1 / flashSeconds);
            yield return null;
        }
    }
}
