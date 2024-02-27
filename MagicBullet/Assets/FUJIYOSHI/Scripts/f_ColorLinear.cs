using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_ColorLinear : MonoBehaviour
{
    [Header("�J�n���Ƀ��j�A")]
    [SerializeField] private bool PlayOnAwake = false;
    [Header("���j�A����C���[�W���w��")]
    [SerializeField] private Image LinearImage;
    [Header("���j�A�̕b��")]
    [SerializeField] private float FlashSeconds = 1;
    [Header("�X�^�[�g�F�ƃG���h�F")]
    public Color StartColor = Color.black;
    [SerializeField] Color EndColor = Color.clear;

    // �ғ����̃R���[�`��
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

    // �F�̐��`���
    // 1:���߂̐F2:�I���̐F3:�b��
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
