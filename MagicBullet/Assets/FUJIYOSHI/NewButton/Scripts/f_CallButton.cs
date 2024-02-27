using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace SetButtonActions
{
    public enum E_BUTTONCALLBACKS
    {
        E_CLICK,
        E_DOWN,
        E_UP,
        E_LONG,
        E_NUM
    }
    public class f_CallButton
    {
        // プロパティとしてsingleton実装
        public static f_CallButton Instance
        {
            get { return callButtonInstance; }
        }

        public GameObject CallObj
        {
            get { return callobj; }
            set { callobj = value; }
        }

        // 引数に渡されたタグ名を持つすべてのオブジェクトに引数に渡された関数を設定する。
        public void SetActionWithTag(string tagname, Action action, E_BUTTONCALLBACKS E_MODE)
        {
            foreach (var item in GameObject.FindGameObjectsWithTag(tagname))
            {
                SetAction(item.GetComponent<f_FullButton>(), action, E_MODE);
            }
        }

        public void SetActions(f_FullButton[] fullButtons, Action action, E_BUTTONCALLBACKS E_MODE)
        {
            foreach (f_FullButton item in fullButtons)
            {
                SetAction(item, action, E_MODE);
            }
        }

        public void SetClickActions(f_FullButton[] fullButtons, Action clickAction)
        {
            foreach (var item in fullButtons)
            {
                SetClickAction(item, clickAction);
            }
        }

        public void SetClickAction(f_FullButton _fullButton, Action clickAction)
        {
            SetAction(_fullButton, clickAction, E_BUTTONCALLBACKS.E_CLICK);
        }

        // 引数に渡されたボタンに引数に渡された関数を設定する。
        public void SetAction(f_FullButton fullButton, Action action, E_BUTTONCALLBACKS E_MODE)
        {
            switch (E_MODE)
            {
                case E_BUTTONCALLBACKS.E_CLICK:
                    fullButton.onClickCallback = action;
                    break;
                case E_BUTTONCALLBACKS.E_DOWN:
                    fullButton.onDownCallback = action;
                    break;
                case E_BUTTONCALLBACKS.E_UP:
                    fullButton.onUpCallback = action;
                    break;
                case E_BUTTONCALLBACKS.E_LONG:
                    fullButton.onLongTapCallback = action;
                    break;
            }
        }

        // 機能をオフにする 引数：機能をオフにするボタンの名前
        public void StopButton(f_FullButton fullButton)
        {
            fullButton.existsMine = true;
        }

        // 使用するボタン
        private static f_CallButton callButtonInstance = new f_CallButton();

        // ボタンの処理を外部から設定すると
        // どれが押されたのかわからなくなるので
        // 押されたゲームオブジェクトを保存するものをつくった
        private GameObject callobj;

        private f_CallButton() { }
    }
}
