using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperableObject : MonoBehaviour
{
    // OperableObject�̔ԍ�����
    private readonly int SETLAYERNUM = 6;
    [SerializeField] private GameObject SignalPrefab;

    private void Start()
    {
        this.gameObject.layer = SETLAYERNUM;
    }

    // ����\�I�u�W�F�N�g���ƍ��}����
    public void OperableSignal()
    {
        Debug.Log("����\�I");
        GameObject signal = Instantiate(SignalPrefab);
        signal.transform.localPosition = Vector3.up * 1;
    }

    public void Operation()
    {
        Debug.Log("���s�I");
    }
}
