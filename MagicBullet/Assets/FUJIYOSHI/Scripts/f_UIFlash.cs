using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f_UIFlash : MonoBehaviour
{
    [Header("�_�ł��������I�u�W�F�N�g���w��")]
    [SerializeField] private f_UIObjects UIObjects;
    [Header("�_�ŃX�s�[�h(�b)")]
    [SerializeField] private float FlashSpeed = 1;
    [Header("�\������(1 = ��ɃX�^�[�g�F)")]
    [SerializeField, Range(0, 1)] private float FlashRatio = 0.5f;
    [Header("�X�^�[�g�F�ƃG���h�F")]
    [SerializeField] Color StartColor = Color.white;
    [SerializeField] Color EndColor = Color.clear;

    // �ғ����̃R���[�`��
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
            // �X�^�[�g�F�\��
            SetColorUI(StartColor);
            yield return new WaitForSeconds(FlashSpeed * FlashRatio);

            // �G���h�F�\��
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
