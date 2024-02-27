using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class f_PlayerStatus
{
    public float MoveSpeed = 0.5f;
    public float RotateSpeed = 0.5f;
    public float MaxSpeed = 3;
    //[System.NonSerialized] public Vector3 MoveForce = Vector3.zero;
    public readonly int BASEFRAMERATE = 60;

    public f_Arm PlayerArm;
    public f_Eye PlayerEye;
}
