using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_Eye : MonoBehaviour
{
    // ����\�I�u�W�F�N�g�����ɂ߂�t�B���^�[
    [SerializeField] private LayerMask OperableObjectLayer;

    // ��̓͂��͈͂ɂ���A�C�e����{��
    public void SearchItem(f_Arm arm)
    {
        // ���g�O����̓͂��͈͂̑���\�I�u�W�F�N�g��{��
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, arm.Length, OperableObjectLayer))
        {
            hit.collider.GetComponent<f_OperableObject>().OperableSignal();
            OperationItem(hit);
        }
    }

    private void OperationItem(RaycastHit hit)
    {
        // F�L�[�ő���
        if (Input.GetKeyDown(KeyCode.F))
        {
            hit.collider.GetComponent<f_OperableObject>().Operation();
        }
    }
}
