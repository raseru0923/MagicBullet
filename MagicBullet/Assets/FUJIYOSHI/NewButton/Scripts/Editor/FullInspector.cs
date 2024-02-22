using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CustomEditor(typeof(FullButton))]
public class FullInspector : Editor
{
    //OnInspectorGUIでカスタマイズのGUIに変更する
    public override void OnInspectorGUI()
    {
        //メモを表示
        EditorGUILayout.LabelField("LongTapがtrueだと長押し判定を行います。");

        //元のInspector部分を表示する
        base.OnInspectorGUI();
    }
}
#endif
