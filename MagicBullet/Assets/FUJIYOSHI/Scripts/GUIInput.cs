using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGUI
{
    public class GUIInput
    {
        private static GUIInput GIInstance = new GUIInput();
        private bool[] mouseClicking = new bool[3];

        private GUIInput() { }

        public static GUIInput GetInstance()
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
