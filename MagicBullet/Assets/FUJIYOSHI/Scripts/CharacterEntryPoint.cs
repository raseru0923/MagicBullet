using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CharacterEntryPoint : MonoBehaviour
{
    private Image myImage;
    // 暗転用のマスクオブジェクト
    [SerializeField] private GameObject BlackMask;

    private void Start()
    {
        // 自身のイメージを取得
        myImage = this.GetComponent<Image>();
    }

    // 削除
    public void Remove()
    {
        myImage.sprite = null;
        myImage.color = Color.clear;
    }

    // 登録
    public void Joint(Image characterImage)
    {
        myImage = characterImage;
        myImage.color = Color.white;
    }

    public void Joint(Sprite characterSprite)
    {
        myImage.sprite = characterSprite;
    }

    // 暗転の切り替え
    public void SetBlackOut(bool isActive)
    {
        BlackMask.SetActive(isActive);
    }
}

// エントリーポイントに対する操作の種類
public enum ENTRYPOINTOPERATIONTYPE
{
    REMOVE,
    JOINT,
    BLACKOUT,
}
