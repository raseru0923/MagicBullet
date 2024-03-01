using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System.Threading;

public class ItemUse : MonoBehaviour
{
    public ItemScriptableObject ItemManager;
    [HideInInspector] public int ItemIndex;
    [SerializeField] private f_Label ItemLabel;

    [Header("アイテムが拾われた時のイベント")]
    public UnityEvent onPickUp;

    /// <summary>
    /// 使用するときに呼ばれる
    /// </summary>
    public async UniTask UseItem()
    {
        print("使用！");

        // 使用する処理を追加

        onPickUp.Invoke();
    }
}
