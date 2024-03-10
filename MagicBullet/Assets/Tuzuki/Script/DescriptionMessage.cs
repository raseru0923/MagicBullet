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

    [Header("�A�C�e�����E��ꂽ���̃C�x���g")]
    public UnityEvent onPickUp;

    private void Start()
    {
        this.tag = "Item";
    }

    /// <summary>
    /// �E��ꂽ���Ă΂��
    /// </summary>
    public async UniTask PlayMessage()
    {
        print("�����I");
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
        //���Z�b�g�̏ꍇ��null�����蓾��
        if (manager.ItemManager.ItemData == null)
        {
            return;
        }

        EditorGUILayout.LabelField("���g�A�C�e�����w�聥");
        PopupProperty.intValue = EditorGUILayout.Popup(
            PopupProperty.intValue,
            manager.ItemManager.ItemData.Select((x) => x.Name).ToArray()
            );

        serializedObject.ApplyModifiedProperties();
    }
}
#endif
