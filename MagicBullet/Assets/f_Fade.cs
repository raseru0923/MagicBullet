using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_Fade : MonoBehaviour
{
    [Header("�t�F�[�h�Ɏg�p����C���[�W")]
    [SerializeField] private Image FadeImage;
    [Header("�t�F�[�h�C���̃X�s�[�h")]
    [SerializeField] private float FadeInSpeed = 1;
    [Header("�t�F�[�h�A�E�g�̃X�s�[�h")]
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

    // �t�F�[�h�C��(���X�ɖ��邭)
    public IEnumerator FadeIn()
    {
        Debug.Log("FadeIn");
        yield return FadeColor(1, i => i <= 0, -Time.deltaTime * FadeInSpeed);
    }

    // �t�F�[�h�A�E�g(���X�ɈÂ�)
    public IEnumerator FadeOut()
    {
        Debug.Log("FadeOut");
        yield return FadeColor(0, i => i >= 1, Time.deltaTime * FadeOutSpeed);
    }

    // �t�F�[�h
    // 1:�����l2:�I������3:���Z�l
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
