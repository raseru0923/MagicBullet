using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
public class f_ScriptableObjectCreater : EditorWindow
{
    [MenuItem("Editor/ScriptableObjectCreater")]
    private static void Create()
    {
        // ����
        f_ScriptableObjectCreater window = GetWindow<f_ScriptableObjectCreater>("ScriptableObjectCreater");
        // �ŏ��T�C�Y�ݒ�
        window.minSize = new Vector2(320, 320);
    }

    private void OnGUI()
    {

    }
}
#endif