using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

using Cysharp.Threading.Tasks;

#if UNITY_EDITOR
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
#endif
