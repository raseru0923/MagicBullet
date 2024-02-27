using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_UIFlash : MonoBehaviour
{
    [Header("点滅させたいオブジェクトを指定")]
    [SerializeField] private f_UIObjects UIObjects;
    [Header("点滅スピード(秒)")]
    [SerializeField] private float FlashSpeed = 1;
    [Header("表示割合(1 = 常にスタート色)")]
    [SerializeField, Range(0, 1)] private float FlashRatio = 0.5f;
    [Header("スタート色とエンド色")]
    [SerializeField] Color StartColor = Color.white;
    [SerializeField] Color EndColor = Color.clear;

    // 稼働中のコルーチン
    private Coroutine operationCoroutine;

    // Start is called before the first frame update
    void OnEnable()
    {
        operationCoroutine = StartCoroutine(FlashUI());
    }

    void OnDisable()
    {
        StopCoroutine(operationCoroutine);
    }

    IEnumerator FlashUI()
    {
        while (true)
        {
            // スタート色表示
            SetColorUI(StartColor);
            yield return new WaitForSeconds(FlashSpeed * FlashRatio);

            // エンド色表示
            SetColorUI(EndColor);
            yield return new WaitForSeconds(FlashSpeed * (1 - FlashRatio));
        }
    }

    private void SetColorUI(Color color)
    {
        if (UIObjects.ImageUI != null) { UIObjects.ImageUI.color = color; }
        if (UIObjects.TextUI != null) { UIObjects.TextUI.color = color; }
        if (UIObjects.SpriteUI != null) { UIObjects.SpriteUI.color = color; }
    }
}
