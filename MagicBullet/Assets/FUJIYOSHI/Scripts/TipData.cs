using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipData
{
    // 使用されているアセットのゲームオブジェクト番号と種類を保存
    public int AssetNumber;
    public MapPallet.MAPTYPE MapType;

    public TipData(int setAssetNumber,MapPallet.MAPTYPE setMapType)
    {
        AssetNumber = setAssetNumber;
        MapType = setMapType;
    }
}
