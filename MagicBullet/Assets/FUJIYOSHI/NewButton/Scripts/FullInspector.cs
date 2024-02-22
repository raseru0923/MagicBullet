using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
