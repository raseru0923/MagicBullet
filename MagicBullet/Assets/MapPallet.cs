using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPallet : MonoBehaviour
{
    public enum MAPTYPE
    {
        TILE = 0,
        WALL,
        DOOR,
        NUM
    }

    public MansionMapAssets[] Pallets;
}
