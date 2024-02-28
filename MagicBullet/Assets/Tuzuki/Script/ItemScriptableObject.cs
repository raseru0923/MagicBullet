using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Manager",menuName = "ScriptableObject/ItemManager")]
public class ItemScriptableObject : ScriptableObject
{
    [Header("�A�C�e���f�[�^��")]
    public List<ObjectItem> ItemData;
}
