using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_UIFlash : MonoBehaviour
{
    [Header("�J�n���ɓ_��")]
    [SerializeField] private bool PlayOnAwake = true;
    [Header("���j�A���g�p���邩")]
    [SerializeField] private bool IsLinear = true;
    [Header("�_�ł��������I�u�W�F�N�g���w��")]
    [SerializeField] private f_UIObjects UIObjects;
    [Header("�_��1��̕b��")]
    [SerializeField] private float FlashSeconds = 1;
    [Header("�\������")]
    [SerializeField, Range(0, 1)] private float FlashRatio = 0.5f;
    [Header("�X�^�[�g�F�ƃG���h�F")]
    [SerializeField] Color StartColor = Color.white;
    [SerializeField] Color EndColor = Color.clear;

    // ���j�A�_��
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
                // �X�^�[�g�F�\��
                yield return LinearColor(StartColor, EndColor, flashSeconds);

                SetColorUI(EndColor);
                yield return new WaitForSeconds(FlashSeconds * FlashRatio);

                // �G���h�F�\��
                yield return LinearColor(EndColor, StartColor, flashSeconds);
                continue;
            }
            // �X�^�[�g�F�\��
            SetColorUI(StartColor);
            yield return new WaitForSeconds(FlashSeconds * FlashRatio);

            // �G���h�F�\��
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

    // �F�̐��`���
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
