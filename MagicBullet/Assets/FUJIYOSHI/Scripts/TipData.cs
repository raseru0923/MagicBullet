using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipData
{
    // �g�p����Ă���A�Z�b�g�̃Q�[���I�u�W�F�N�g�ԍ��Ǝ�ނ�ۑ�
    public int AssetNumber;
    public MapPallet.MAPTYPE MapType;

    public TipData(int setAssetNumber,MapPallet.MAPTYPE setMapType)
    {
        AssetNumber = setAssetNumber;
        MapType = setMapType;
    }
}
