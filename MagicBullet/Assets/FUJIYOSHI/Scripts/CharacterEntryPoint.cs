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
        myImage = null;
    }

    // 登録
    public void Joint(Image characterImage)
    {
        myImage = characterImage;
    }

    // 暗転の切り替え
    public void SetBlackOut(bool isActive)
    {
        BlackMask.SetActive(isActive);
    }
}
