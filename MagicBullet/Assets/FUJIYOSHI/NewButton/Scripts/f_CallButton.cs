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
        // �v���p�e�B�Ƃ���singleton����
        public static f_CallButton Instance
        {
            get { return callButtonInstance; }
        }

        public GameObject CallObj
        {
            get { return callobj; }
            set { callobj = value; }
        }

        // �����ɓn���ꂽ�^�O���������ׂẴI�u�W�F�N�g�Ɉ����ɓn���ꂽ�֐���ݒ肷��B
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

        // �����ɓn���ꂽ�{�^���Ɉ����ɓn���ꂽ�֐���ݒ肷��B
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

        // �@�\���I�t�ɂ��� �����F�@�\���I�t�ɂ���{�^���̖��O
        public void StopButton(f_FullButton fullButton)
        {
            fullButton.existsMine = true;
        }

        // �g�p����{�^��
        private static f_CallButton callButtonInstance = new f_CallButton();

        // �{�^���̏������O������ݒ肷���
        // �ǂꂪ�����ꂽ�̂��킩��Ȃ��Ȃ�̂�
        // �����ꂽ�Q�[���I�u�W�F�N�g��ۑ�������̂�������
        private GameObject callobj;

        private f_CallButton() { }
    }
}
