using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Linq;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class DescriptionMessage : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex = 11;

    [Header("アイテムが拾われた時のイベント")]
    public UnityEvent onPickUp;

    private void Start()
    {
        this.tag = "Item";
    }

    /// <summary>
    /// 拾われた時呼ばれる
    /// </summary>
    public async UniTask PlayMessage()
    {
        print("説明！");
        var item = ItemManager.ItemData[ItemIndex];

        await GameMaster.Instance.AssessmentDiceRoll(item, item.SkillSprite.name);

        onPickUp.Invoke();
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(DescriptionMessage))]
public class DescriptionMessageEditor : Editor
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

        DescriptionMessage manager = (DescriptionMessage)this.target;
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
#endif
