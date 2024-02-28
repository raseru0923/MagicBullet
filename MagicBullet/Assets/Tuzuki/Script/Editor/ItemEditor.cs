using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

[CustomEditor(typeof(Item))]
public class ItemEditor : Editor
{
    SerializedProperty PopupProperty;

    private void OnEnable()
    {
        PopupProperty = serializedObject.FindProperty("ItemIndex");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        serializedObject.Update();

        Item manager = (Item)this.target;
        //未セットの場合はnullがあり得る
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("自身アイテムを指定▼");
        PopupProperty.intValue = EditorGUILayout.Popup(
            PopupProperty.intValue,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );

        serializedObject.ApplyModifiedProperties();
    }
}
