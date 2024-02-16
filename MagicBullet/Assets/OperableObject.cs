using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperableObject : MonoBehaviour
{
    // OperableObjectの番号を代入
    private readonly int SETLAYERNUM = 6;
    [SerializeField] private GameObject SignalPrefab;

    private void Start()
    {
        this.gameObject.layer = SETLAYERNUM;
    }

    // 操作可能オブジェクトだと合図する
    public void OperableSignal()
    {
        Debug.Log("操作可能！");
        GameObject signal = Instantiate(SignalPrefab);
        signal.transform.localPosition = Vector3.up * 1;
    }

    public void Operation()
    {
        Debug.Log("実行！");
    }
}
