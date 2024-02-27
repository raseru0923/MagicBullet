using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_UIFlash : MonoBehaviour
{
    [Header("開始時に点滅")]
    [SerializeField] private bool PlayOnAwake = true;
    [Header("リニアを使用するか")]
    [SerializeField] private bool IsLinear = true;
    [Header("点滅させたいオブジェクトを指定")]
    [SerializeField] private f_UIObjects UIObjects;
    [Header("点滅1回の秒数")]
    [SerializeField] private float FlashSeconds = 1;
    [Header("表示割合")]
    [SerializeField, Range(0, 1)] private float FlashRatio = 0.5f;
    [Header("スタート色とエンド色")]
    [SerializeField] Color StartColor = Color.white;
    [SerializeField] Color EndColor = Color.clear;

    // リニア点滅
    private Coroutine operationCoroutine;

    // Start is called before the first frame update
    void OnEnable()
    {
        if (PlayOnAwake)
        {
            operationCoroutine = StartCoroutine(FlashUI());
        }
    }

    void OnDisable()
    {
        if (operationCoroutine != null)
        {
            StopCoroutine(operationCoroutine);
        }
    }

    public void FlashUI(Color startColor, Color endColor, float flashSeconds, float flashRatio, bool isLinear = true)
    {
        StartColor = startColor;
        EndColor = endColor;
        FlashSeconds = flashSeconds;
        FlashRatio = flashRatio;
        IsLinear = isLinear;
        StartCoroutine(FlashUI());
    }

    IEnumerator FlashUI()
    {
        while (true)
        {
            if (IsLinear)
            {
                float flashSeconds = FlashSeconds * (1 - FlashRatio) / 2;
                // スタート色表示
                yield return LinearColor(StartColor, EndColor, flashSeconds);

                SetColorUI(EndColor);
                yield return new WaitForSeconds(FlashSeconds * FlashRatio);

                // エンド色表示
                yield return LinearColor(EndColor, StartColor, flashSeconds);
                continue;
            }
            // スタート色表示
            SetColorUI(StartColor);
            yield return new WaitForSeconds(FlashSeconds * FlashRatio);

            // エンド色表示
            SetColorUI(EndColor);
            yield return new WaitForSeconds(FlashSeconds * (1 - FlashRatio));
        }
    }

    private void SetColorUI(Color color)
    {
        if (UIObjects.ImageUI != null) { UIObjects.ImageUI.color = color; }
        if (UIObjects.TextUI != null) { UIObjects.TextUI.color = color; }
        if (UIObjects.SpriteUI != null) { UIObjects.SpriteUI.color = color; }
    }

    // 色の線形補間
    // 
    public IEnumerator LinearColor(Color startColor, Color endColor, float flashSeconds)
    {
        float ratio = 0;
        while (ratio < 1)
        {
            SetColorUI((1 - ratio) * startColor + endColor * ratio);
            ratio += Time.deltaTime / flashSeconds;
            yield return null;
        }
    }
}
