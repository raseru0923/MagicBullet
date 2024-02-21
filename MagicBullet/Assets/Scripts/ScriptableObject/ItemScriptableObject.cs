using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Manager", menuName = "ScriptableObjects/ItemManager")]
public class ItemScriptableObject : ScriptableObject
{
    [Header("�A�C�e���f�[�^��")]
    public List<ObjectItem> ItemData;
}
