using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

using Cysharp.Threading.Tasks;

#if UNITY_EDITOR
[CustomEditor(typeof(f_TextParameter))]
public class f_TextParameterEditor : Editor
{
    private f_TextParameter m_target;

    private void OnEnable()
    {
        m_target = (f_TextParameter)target;
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
