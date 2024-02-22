using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Manager", menuName = "ScriptableObjects/ItemManager")]
public class ItemScriptableObject : ScriptableObject
{
    [Header("アイテムデータ▼")]
    public List<ObjectItem> ItemData;
}
