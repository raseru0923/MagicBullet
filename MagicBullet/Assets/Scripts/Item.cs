using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Item : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [System.NonSerialized] public int SelectItem;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Item))]
public class EditorButtonManager : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Item manager = (Item)this.target;
        // 未セットの場合はnullがありえる
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("自身アイテムを指定▼");
        manager.SelectItem = EditorGUILayout.Popup(
            manager.SelectItem,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );
    }
}
#endif
