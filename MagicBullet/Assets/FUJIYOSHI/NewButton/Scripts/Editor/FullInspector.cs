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
    //OnInspectorGUI�ŃJ�X�^�}�C�Y��GUI�ɕύX����
    public override void OnInspectorGUI()
    {
        //������\��
        EditorGUILayout.LabelField("LongTap��true���ƒ�����������s���܂��B");

        //����Inspector������\������
        base.OnInspectorGUI();
    }
}
#endif
