using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ボタンが選択された状態になる
        this.GetComponent<Button>().Select();
    }
}
