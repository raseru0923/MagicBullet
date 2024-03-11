using UnityEngine;

/// <summary>
/// ターゲットに振り向くスクリプト（オフセット考慮版）
/// </summary>
public class LookAtTargetOffset : MonoBehaviour
{
    private Transform _self;

    // ターゲットのTransform
    public Transform _target;
    private Transform beforetarget;

    // 前方の基準となるローカル空間ベクトル
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
            // ターゲットへの向きベクトル計算
            var dir = _target.position - _self.position;

            // ターゲットの方向への回転
            var lookAtRotation = Quaternion.LookRotation(dir, Vector3.up);
            // 回転補正
            var offsetRotation = Quaternion.FromToRotation(_forward, Vector3.forward);

            // 回転補正→ターゲット方向への回転の順に、自身の向きを操作する
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