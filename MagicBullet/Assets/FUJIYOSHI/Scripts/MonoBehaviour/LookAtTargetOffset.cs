using UnityEngine;

/// <summary>
/// �^�[�Q�b�g�ɐU������X�N���v�g�i�I�t�Z�b�g�l���Łj
/// </summary>
public class LookAtTargetOffset : MonoBehaviour
{
    private Transform _self;

    // �^�[�Q�b�g��Transform
    public Transform _target;
    private Transform beforetarget;

    // �O���̊�ƂȂ郍�[�J����ԃx�N�g��
    [SerializeField] private Vector3 _forward = Vector3.forward;

    private void OnEnable()
    {
        beforetarget = _target;
        _self = this.transform;
    }

    private void Update()
    {
        if (_target != null && IsTargetNear(10))
        {
            // �^�[�Q�b�g�ւ̌����x�N�g���v�Z
            var dir = _target.position - _self.position;

            // �^�[�Q�b�g�̕����ւ̉�]
            var lookAtRotation = Quaternion.LookRotation(dir, Vector3.up);
            // ��]�␳
            var offsetRotation = Quaternion.FromToRotation(_forward, Vector3.forward);

            // ��]�␳���^�[�Q�b�g�����ւ̉�]�̏��ɁA���g�̌����𑀍삷��
            _self.rotation = lookAtRotation * offsetRotation;
            beforetarget = _target;
        }
    }

    private bool IsTargetNear(float range)
    {
        float distance = _self.position.magnitude - _target.position.magnitude;

        return Mathf.Abs(distance) <= range;
    }
}