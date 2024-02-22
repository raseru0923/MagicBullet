using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MansionMapAssets")]
public class MansionMapAssets : ScriptableObject
{
    // シリアライズされていてもprivateは頭文字小文字
    [SerializeField] private GameObject[] mapAssets;

    [Header("------------------------------------\n追加するマップアセットのテクスチャーを指定\n------------------------------------")]
    [SerializeField] private Sprite mapAssetSprite;

    // publicなプロパティはpublicな変数と同じ命名規則
    public GameObject[] MapAssets
    {
        set { mapAssets = value; }
        get { return mapAssets; }
    }

    public Sprite MapAssetSprite
    {
        get { return mapAssetSprite; }
    }
}
