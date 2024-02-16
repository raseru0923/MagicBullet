using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ScriptableObjectCreater : EditorWindow
{
    [MenuItem("Editor/ScriptableObjectCreater")]
    private static void Create()
    {
        // 生成
        ScriptableObjectCreater window = GetWindow<ScriptableObjectCreater>("ScriptableObjectCreater");
        // 最小サイズ設定
        window.minSize = new Vector2(320, 320);
    }

    private void OnGUI()
    {

    }
}
