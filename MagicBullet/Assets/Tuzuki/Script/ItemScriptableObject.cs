using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Manager",menuName = "ScriptableObject/ItemManager")]
public class ItemScriptableObject : ScriptableObject
{
    [Header("アイテムデータ▼")]
    public List<ObjectItem> ItemData;
}
