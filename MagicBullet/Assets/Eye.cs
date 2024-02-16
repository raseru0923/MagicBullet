using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    // 操作可能オブジェクトを見極めるフィルター
    [SerializeField] private LayerMask OperableObjectLayer;

    // 手の届く範囲にあるアイテムを捜索
    public void SearchItem(Arm arm)
    {
        // 自身前方手の届く範囲の操作可能オブジェクトを捜索
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, arm.Length, OperableObjectLayer))
        {
            hit.collider.GetComponent<OperableObject>().OperableSignal();
            OperationItem(hit);
        }
    }

    private void OperationItem(RaycastHit hit)
    {
        // Fキーで操作
        if (Input.GetKeyDown(KeyCode.F))
        {
            hit.collider.GetComponent<OperableObject>().Operation();
        }
    }
}
