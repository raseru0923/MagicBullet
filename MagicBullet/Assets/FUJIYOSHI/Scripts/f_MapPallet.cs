using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_MapPallet : MonoBehaviour
{
    public enum MAPTYPE
    {
        TILE = 0,
        WALL,
        DOOR,
        NUM
    }

    public f_MansionMapAssets[] Pallets;
}
