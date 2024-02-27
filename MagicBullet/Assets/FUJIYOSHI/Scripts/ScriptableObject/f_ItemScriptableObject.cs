using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Manager", menuName = "ScriptableObjects/ItemManager")]
public class f_ItemScriptableObject : ScriptableObject
{
    [Header("�A�C�e���f�[�^��")]
    public List<f_ObjectItem> ItemData;
}
