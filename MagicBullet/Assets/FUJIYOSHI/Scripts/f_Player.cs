using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_Player : MonoBehaviour
{
    [SerializeField] private f_PlayerStatus Status;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        Status.PlayerEye.SearchItem(Status.PlayerArm);
    }

    // 移動
    private void MovePlayer()
    {
        WalkPlayer();

        RotatePlayer();
    }

    private void WalkPlayer()
    {
        // 移動の力を保存
        Vector3 movePosition = this.transform.position;
        Vector3 moveForce = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) { moveForce += transform.forward; }
        if (Input.GetKey(KeyCode.S)) { moveForce += -transform.forward; }
        if (Input.GetKey(KeyCode.A)) { moveForce += -transform.right; }
        if (Input.GetKey(KeyCode.D)) { moveForce += transform.right; }

        // プレイヤーの移動を実行
        movePosition += moveForce * Status.MoveSpeed * Time.deltaTime * Status.BASEFRAMERATE;
        this.transform.position = movePosition;
    }

    private void RotatePlayer()
    {
        Vector3 playerAngle = this.transform.eulerAngles;
        Vector3 rotateForce = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow)) { rotateForce.y += Status.RotateSpeed; }
        if (Input.GetKey(KeyCode.LeftArrow)) { rotateForce.y -= Status.RotateSpeed; }

        playerAngle += rotateForce * Time.deltaTime * Status.BASEFRAMERATE;

        this.transform.eulerAngles = playerAngle;
    }
}
