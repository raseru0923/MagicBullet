using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;
using SetButtonActions;

// �{�^�����������I�u�W�F�N�g��Layer��UI�ɕύX���������ŁACanvas�̎q�I�u�W�F�N�g�ɐݒ肷��B
[RequireComponent(typeof(Image))]
public class f_FullButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    // �Ăяo���ꂽ�玩���̃I�u�W�F�N�g��ۑ�����
    private void Call()
    {
        f_CallButton.Instance.CallObj = this.gameObject;
    }


    public System.Action onClickCallback;
    public System.Action onDownCallback;
    public System.Action onUpCallback;
    public System.Action onLongTapCallback;

    // �R�[���o�b�N���ꂽ���e�����s���邩�B
    [NonSerialized] public bool canOperation;
    // ���g���K�v��
    [NonSerialized] public bool existsMine;

    [SerializeField] private Image minebuttonimage;
    [SerializeField] private f_Useful LongTap = new f_Useful(true);
    [SerializeField] private f_Useful LongTapPrintGauge = new f_Useful(true);
    [SerializeField] private f_Useful TapDownWithZoomOut = new f_Useful(true);
    [SerializeField] private float ZoomOutTime = 0.125f;
    [SerializeField] private f_Useful TapDownWithGray = new f_Useful(true);
    [SerializeField] private Text ButtonText;
    [SerializeField] private Image Frame;
    [SerializeField] private Image Bar;
    [SerializeField] private float LongTapTime = 3;
    [SerializeField] private float Brightness = 50;
    private Vector3 scale;
    private bool isButtonTap = false;
    private bool isPlayLongTap = false;
    private float time = 0;
    private Color Color;
    private Color GrayColor;
    private Color TextColor;
    private Color GrayTextColor;

    // ��������@�\
    // ��{�I�@�\
    // �^�b�v����
    // ����������
    // �^�b�v���Ă��������Ȃ����
    // �^�b�v�A�j���[�V����
    // �^�b�v���̏o�������iOK�A�L�����Z���Ȃǁj
    // ���S�@�\�I�t
    // �O������s���e��ݒ�ł���B

    void Start()
    {
        Color = this.GetComponent<Image>().color;
        GrayDown(ref GrayColor);
        TextColor = ButtonText.color;
        GrayDown(ref GrayTextColor);
        canOperation = true;
        existsMine = true;
        scale = this.transform.localScale;
    }

    void Update()
    {
        if (isButtonTap && LongTap.canUseful)    // �{�^����������Ă��肩�����O�^�b�v�@�\���g�p����Ƃ��̏���
        {
            OnPointerHold();
        }

        // ���g�����݂��Ă���A���g�̃��C���肪�@�\���Ă��Ȃ��Ƃ�
        // ���C����𕜊�
        if (existsMine && !minebuttonimage.raycastTarget)
        {
            minebuttonimage.raycastTarget = true;
        }

        if (!existsMine)    // ���g�����݂��Ȃ��Ƃ�
        {
            if (ButtonText.color.a != 0)
            {
                minebuttonimage.raycastTarget = false;
                minebuttonimage.color = Color.clear;
                ButtonText.color = Color.clear;
            }
        }
        else if (canOperation && ButtonText.color != TextColor && !isButtonTap)
        {// ���g�����݂��Ă���{�^���@�\���g�p�\���e�L�X�g�J���[���ʏ펞�ƈقȂ�{�^����������Ă��Ȃ����̏���
            minebuttonimage.color = Color;
            ButtonText.color = TextColor;
        }
        else if (!canOperation && ButtonText.color != GrayTextColor)
        {// ���g�����݂��Ă���{�^���@�\���g�p�s���e�L�X�g�J���[���ʏ펞�Ɠ������̏���
            this.GetComponent<Image>().color = GrayColor;
            ButtonText.color = GrayTextColor;
        }
        else if (canOperation && Color != this.GetComponent<Image>().color && !isButtonTap)
        {// ���g�����݂��Ă���{�^���@�\���g�p�\���{�^���J���[���ʏ펞�ƈقȂ�{�^����������Ă��Ȃ��Ƃ��̏���
            Color = minebuttonimage.color;
            GrayDown(ref GrayColor);
        }
        else if (canOperation && TextColor != ButtonText.color && !isButtonTap)
        {// ���g�����݂��Ă���{�^���@�\���g�p�s���{�^���J���[���ʏ펞�Ɠ������̏���
            TextColor = ButtonText.color;
            GrayDown(ref GrayTextColor);
        }
    }

    // �^�b�v  
    public void OnPointerClick(PointerEventData eventData)
    {
        // a�B:�ϐ���()�Ŏ��s
        //onClickCallback();
        // null�`�F�b�N�������
        if (existsMine && canOperation && !isPlayLongTap)
        {
            Call();
            onClickCallback?.Invoke();
        }
        else
        {
            isPlayLongTap = false;
        }
    }
    // �^�b�v�_�E��  
    public void OnPointerDown(PointerEventData eventData)
    {
        if (existsMine && canOperation)
        {
            isButtonTap = true;
            if (TapDownWithZoomOut.canUseful)
            {
                this.transform.DOScale(new Vector2(scale.x - scale.x / 8, scale.y - scale.y / 8), ZoomOutTime);
            }
            if (TapDownWithGray.canUseful)
            {
                minebuttonimage.color = GrayColor;
                ButtonText.color = GrayTextColor;
            }
            Call();
            onDownCallback?.Invoke();
            Debug.Log("Down���m");
        }
        if (LongTap.canUseful && existsMine && canOperation && LongTapPrintGauge.canUseful)
        {
            Frame.color = Color.white;
            Bar.color = Color.white;
        }
    }
    // �^�b�v�A�b�v  
    public void OnPointerUp(PointerEventData eventData)
    {
        Frame.color = Color.clear;
        Bar.color = Color.clear;
        isButtonTap = false;
        if (existsMine && canOperation)
        {
            Call();
            onUpCallback?.Invoke();
            Debug.Log("Up���m");
        }
        if (TapDownWithZoomOut.canUseful)
        {
            this.transform.DOScale(new Vector2(scale.x, scale.y), ZoomOutTime);
        }
        minebuttonimage.color = Color;
        ButtonText.color = TextColor;
        time = 0;
    }
    // ������
    public void OnPointerHold()
    {
        // LongTapTime����
        if (time < LongTapTime)
        {
            time += Time.deltaTime;
            Bar.fillAmount = time / LongTapTime;
            return;
        }

        Frame.color = Color.clear;
        Bar.color = Color.clear;

        if (TapDownWithZoomOut.canUseful)
        {
            this.transform.DOScale(new Vector2(scale.x, scale.y), ZoomOutTime);
        }
        isPlayLongTap = true;
        Call();
        // onLongTapCallback���Ăяo�����
        onLongTapCallback?.Invoke();
        Debug.Log("���������e���s");
        isButtonTap = false;
        time = 0;
    }

    // ���x��������
    private void GrayDown(ref Color graycolor)
    {
        graycolor.r = Color.r - Brightness / 100;
        graycolor.g = Color.g - Brightness / 100;
        graycolor.b = Color.b - Brightness / 100;
        graycolor.a = 1;
    }
}
