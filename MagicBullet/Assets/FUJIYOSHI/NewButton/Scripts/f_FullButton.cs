using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;
using SetButtonActions;

// ボタン化したいオブジェクトのLayerはUIに変更したうえで、Canvasの子オブジェクトに設定する。
[RequireComponent(typeof(Image))]
public class f_FullButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    // 呼び出されたら自分のオブジェクトを保存する
    private void Call()
    {
        f_CallButton.Instance.CallObj = this.gameObject;
    }


    public System.Action onClickCallback;
    public System.Action onDownCallback;
    public System.Action onUpCallback;
    public System.Action onLongTapCallback;

    // コールバックされた内容を実行するか。
    [NonSerialized] public bool canOperation;
    // 自身が必要か
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

    // 実装する機能
    // 基本的機能
    // タップ判定
    // 長押し判定
    // タップしても反応しない状態
    // タップアニメーション
    // タップ音の出し分け（OK、キャンセルなど）
    // 完全機能オフ
    // 外から実行内容を設定できる。

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
        if (isButtonTap && LongTap.canUseful)    // ボタンが押されておりかつロングタップ機能を使用するときの処理
        {
            OnPointerHold();
        }

        // 自身が存在しており、自身のレイ判定が機能していないとき
        // レイ判定を復活
        if (existsMine && !minebuttonimage.raycastTarget)
        {
            minebuttonimage.raycastTarget = true;
        }

        if (!existsMine)    // 自身が存在しないとき
        {
            if (ButtonText.color.a != 0)
            {
                minebuttonimage.raycastTarget = false;
                minebuttonimage.color = Color.clear;
                ButtonText.color = Color.clear;
            }
        }
        else if (canOperation && ButtonText.color != TextColor && !isButtonTap)
        {// 自身が存在しておりボタン機能が使用可能かつテキストカラーが通常時と異なりボタンが押されていない時の処理
            minebuttonimage.color = Color;
            ButtonText.color = TextColor;
        }
        else if (!canOperation && ButtonText.color != GrayTextColor)
        {// 自身が存在しておりボタン機能が使用不可かつテキストカラーが通常時と同じ時の処理
            this.GetComponent<Image>().color = GrayColor;
            ButtonText.color = GrayTextColor;
        }
        else if (canOperation && Color != this.GetComponent<Image>().color && !isButtonTap)
        {// 自身が存在しておりボタン機能が使用可能かつボタンカラーが通常時と異なりボタンが押されていないときの処理
            Color = minebuttonimage.color;
            GrayDown(ref GrayColor);
        }
        else if (canOperation && TextColor != ButtonText.color && !isButtonTap)
        {// 自身が存在しておりボタン機能が使用不可かつボタンカラーが通常時と同じ時の処理
            TextColor = ButtonText.color;
            GrayDown(ref GrayTextColor);
        }
    }

    // タップ  
    public void OnPointerClick(PointerEventData eventData)
    {
        // a③:変数名()で実行
        //onClickCallback();
        // nullチェックを入れると
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
    // タップダウン  
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
            Debug.Log("Down感知");
        }
        if (LongTap.canUseful && existsMine && canOperation && LongTapPrintGauge.canUseful)
        {
            Frame.color = Color.white;
            Bar.color = Color.white;
        }
    }
    // タップアップ  
    public void OnPointerUp(PointerEventData eventData)
    {
        Frame.color = Color.clear;
        Bar.color = Color.clear;
        isButtonTap = false;
        if (existsMine && canOperation)
        {
            Call();
            onUpCallback?.Invoke();
            Debug.Log("Up感知");
        }
        if (TapDownWithZoomOut.canUseful)
        {
            this.transform.DOScale(new Vector2(scale.x, scale.y), ZoomOutTime);
        }
        minebuttonimage.color = Color;
        ButtonText.color = TextColor;
        time = 0;
    }
    // 長押し
    public void OnPointerHold()
    {
        // LongTapTime未満
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
        // onLongTapCallbackを呼び出し代入
        onLongTapCallback?.Invoke();
        Debug.Log("長押し内容実行");
        isButtonTap = false;
        time = 0;
    }

    // 明度を下げる
    private void GrayDown(ref Color graycolor)
    {
        graycolor.r = Color.r - Brightness / 100;
        graycolor.g = Color.g - Brightness / 100;
        graycolor.b = Color.b - Brightness / 100;
        graycolor.a = 1;
    }
}
