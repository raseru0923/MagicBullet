using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
public class ScriptableObjectCreater : EditorWindow
{
    [MenuItem("Editor/ScriptableObjectCreater")]
    private static void Create()
    {
        // ê∂ê¨
        ScriptableObjectCreater window = GetWindow<ScriptableObjectCreater>("ScriptableObjectCreater");
        // ç≈è¨ÉTÉCÉYê›íË
        window.minSize = new Vector2(320, 320);
    }

    private void OnGUI()
    {

    }
}
#endif
