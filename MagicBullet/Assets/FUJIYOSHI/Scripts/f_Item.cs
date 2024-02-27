using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class f_Item : MonoBehaviour
{
    public f_ItemScriptableObject ItemManager;
    [System.NonSerialized] public int SelectItem;
}

#if UNITY_EDITOR
[CustomEditor(typeof(f_Item))]
public class EditorButtonManager : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        f_Item manager = (f_Item)this.target;
        // ���Z�b�g�̏ꍇ��null�����肦��
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("���g�A�C�e�����w�聥");
        manager.SelectItem = EditorGUILayout.Popup(
            manager.SelectItem,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );
    }
}
#endif
