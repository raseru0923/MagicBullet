using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGUI
{
    public class f_GUIInput
    {
        private static f_GUIInput GIInstance = new f_GUIInput();
        private bool[] mouseClicking = new bool[3];

        private f_GUIInput() { }

        public static f_GUIInput GetInstance()
        {
            return GIInstance;
        }

        public bool MOUSEBUTTONDOWN(int mouseNum)
        {
            if (Event.current.type == EventType.MouseDown && Event.current.button == mouseNum)
            {
                mouseClicking[mouseNum] = true;
                return true;
            }
            return false;
        }
        public bool MOUSEBUTTONUP(int mouseNum)
        {
            if (Event.current.type == EventType.MouseUp && Event.current.button == mouseNum)
            {
                mouseClicking[mouseNum] = false;
                return true;
            }
            return false;
        }
        public bool MOUSEBUTTON(int mouseNum)
        {
            MOUSEBUTTONDOWN(mouseNum);
            MOUSEBUTTONUP(mouseNum);

            return mouseClicking[mouseNum];
        }
    }
}
