using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(f_ColorLinear))]
public class f_Fade : MonoBehaviour
{
    [Header("�t�F�[�h�C���̕b��")]
    [SerializeField] private float FadeInSpeed = 1;
    [Header("�t�F�[�h�A�E�g�̕b��")]
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

    // �t�F�[�h�C��(���X�ɖ��邭)
    public IEnumerator FadeIn()
    {
        Debug.Log("FadeIn");
        Color endColor = colorLinear.StartColor;
        endColor.a = 0;
        yield return StartCoroutine(colorLinear.LinearColor(colorLinear.StartColor, endColor, FadeInSpeed));
    }

    // �t�F�[�h�A�E�g(���X�ɈÂ�)
    public IEnumerator FadeOut()
    {
        Debug.Log("FadeOut");
        Color endColor = colorLinear.StartColor;
        endColor.a = 0;
        yield return StartCoroutine(colorLinear.LinearColor(endColor, colorLinear.StartColor, FadeOutSpeed));
    }
}
