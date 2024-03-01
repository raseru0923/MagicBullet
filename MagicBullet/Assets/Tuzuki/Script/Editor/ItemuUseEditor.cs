using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

[CustomEditor(typeof(ItemUse))]
public class ItemUseEditor : Editor
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

        ItemUse manager = (ItemUse)this.target;
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
