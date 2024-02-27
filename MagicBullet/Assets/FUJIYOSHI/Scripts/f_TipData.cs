using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_TipData
{
    // 使用されているアセットのゲームオブジェクト番号と種類を保存
    public int AssetNumber;
    public f_MapPallet.MAPTYPE MapType;

    public f_TipData(int setAssetNumber,f_MapPallet.MAPTYPE setMapType)
    {
        AssetNumber = setAssetNumber;
        MapType = setMapType;
    }
}
