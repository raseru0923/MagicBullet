using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_TipData
{
    // �g�p����Ă���A�Z�b�g�̃Q�[���I�u�W�F�N�g�ԍ��Ǝ�ނ�ۑ�
    public int AssetNumber;
    public f_MapPallet.MAPTYPE MapType;

    public f_TipData(int setAssetNumber,f_MapPallet.MAPTYPE setMapType)
    {
        AssetNumber = setAssetNumber;
        MapType = setMapType;
    }
}
