using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Cysharp.Threading.Tasks;

[CustomEditor(typeof(TextParameter))]
public class TextParameterEditor : Editor
{
    private TextParameter m_target;

    private void OnEnable()
    {
        m_target = (TextParameter)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("ïœçXÇìKóp"))
        {
        }
    }
}
