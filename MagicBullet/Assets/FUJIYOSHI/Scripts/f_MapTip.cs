using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// 生成されると自身の子要素にボタン処理の設定を行う

public class f_MapTip : MonoBehaviour
{
    [SerializeField] private f_FullButton[] TipButton;
    private f_TipData[] TipDatas;

    private SetButtonActions.f_CallButton callButton = SetButtonActions.f_CallButton.Instance;
    [SerializeField] private f_MapPallet mapPallet;
    f_KeyNumberCombertion keyNumberCombertion = new f_KeyNumberCombertion();

    f_MapPallet.MAPTYPE mode = f_MapPallet.MAPTYPE.NUM;
    [SerializeField] private Dropdown CurrentMode;

    [SerializeField] private Dropdown AssetsList;
    List<Dropdown.OptionData> options = new List<Dropdown.OptionData> { new Dropdown.OptionData("") };

    // モードの変更を確認
    bool isModeChange = false;

    // Start is called before the first frame update
    void Start()
    {
        TipDatas = new f_TipData[TipButton.Length];
        // タイルチップが押されたときにTileSetの処理を行えるようにする。
        callButton.SetClickActions(TipButton, SetAsset);

        mode = (f_MapPallet.MAPTYPE)CurrentMode.value;
        CreateList();
        StartCoroutine(CheckModeChange());
    }

    IEnumerator CheckModeChange()
    {
        int mapMode = (int)mode;
        while (true)
        {
            ModeChange(mapMode);
            mapMode = CurrentMode.value;
            yield return null;
        }
    }

    private void ModeChange(int mapMode)
    {
        if (mapMode != CurrentMode.value)
        {
            isModeChange = true;

            return;
        }
        isModeChange = false;
    }

    private void Update()
    {
        if (
            Input.GetKeyDown("t") ||
            Input.GetKeyDown("w") ||
            Input.GetKeyDown("d") ||
            Input.GetKeyDown("n")
            )
        {
            mode = ModeInitialKeyToMAPMODE();
            CurrentMode.value = (int)mode;
            CreateList();
        }

        if (isModeChange)
        {
            Debug.Log("モードが変更されました");

            mode = (f_MapPallet.MAPTYPE)CurrentMode.value;
            CreateList();
        }
    }

    private void SetAsset()
    {
        Debug.Log("Tileをセットします");
        Debug.Log(mode);
        switch (mode)
        {
            case f_MapPallet.MAPTYPE.TILE:
                TileSet();
                break;
            case f_MapPallet.MAPTYPE.WALL:
                WallSet();
                break;
            case f_MapPallet.MAPTYPE.DOOR:
                DoorSet();
                break;
            default:
                break;
        }
    }

    // タイルにマップアセットを設定
    private void TileSet()
    {
        if (callButton.CallObj.tag == "TileTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("TileTip(大きいマス)に設定してください");
    }

    private void WallSet()
    {
        if (callButton.CallObj.tag == "WallDoorTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("WallDoorTip(上下左右の小さいマス)に設定してください");
    }
    private void DoorSet()
    {
        if (callButton.CallObj.tag == "WallDoorTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("WallDoorTip(上下左右の小さいマス)に設定してください");
    }

    private void SetTip()
    {
        int setMode = (int)mode;
        f_MansionMapAssets useAssets = mapPallet.Pallets[setMode];
        GameObject[] useMapAssets = useAssets.MapAssets;

        Image tipImage = callButton.CallObj.GetComponent<Image>();

        int palletsIndex = AssetsList.value;

        if (0 <= palletsIndex && palletsIndex < useMapAssets.Length)
        {
            // イメージ反映処理
            Texture mainTexture = useMapAssets[palletsIndex].GetComponent<MeshRenderer>().sharedMaterial.mainTexture;
            Texture2D texture2D = mainTexture.ToTexture2D();
            tipImage.sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.zero);
            Debug.Log(setMode + "に" + useMapAssets[palletsIndex].name + "を設定しました。");

            // チップデータを保存
            int i = 0;
            foreach (var item in TipButton)
            {
                if (callButton.CallObj.name == item.name)
                {
                    TipDatas[i] = new f_TipData(palletsIndex, mode);
                    Debug.Log(item.name + "に" + mode + "の" + palletsIndex.ToString() + "を設定しました。");
                    return;
                }
                ++i;
            }
            return;
        }

        Debug.LogWarning("使いたいマップアッセトの数字キーを押しながら実行してください");
    }

    // モードのイニシャルと合致するモードを返却する。
    private f_MapPallet.MAPTYPE ModeInitialKeyToMAPMODE()
    {
        for (int i = 0; i < (int)f_MapPallet.MAPTYPE.NUM; i++)
        {
            if (Input.GetKey(TextToLowerInitial(((f_MapPallet.MAPTYPE)i).ToString())))
            {
                return (f_MapPallet.MAPTYPE)i;
            }
        }
        return f_MapPallet.MAPTYPE.NUM;
    }

    // イニシャルを小文字で返却
    private string TextToLowerInitial(string text)
    {
        return text.ToLower().Substring(0, 1);
    }

    void CreateList()
    {
        AssetsList.ClearOptions();
        if (options != null) { options.Clear(); }

        if (mode == f_MapPallet.MAPTYPE.NUM) { return; }
        int setMode = (int)mode;
        f_MansionMapAssets useAssets = mapPallet.Pallets[setMode];
        GameObject[] useMapAssets = useAssets.MapAssets;

        int i = 0;
        foreach (var item in useMapAssets)
        {
            Texture mainTexture = item.GetComponent<MeshRenderer>().sharedMaterial.mainTexture;
            Texture2D texture2D = mainTexture.ToTexture2D();
            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.zero);

            options.Add(new Dropdown.OptionData(i.ToString(), sprite));
            ++i;
        }

        AssetsList.AddOptions(options);
    }
}



public static class TextureExt
{
    public static Texture2D ToTexture2D(this Texture self)
    {
        var sw = self.width;
        var sh = self.height;
        var format = TextureFormat.RGBA32;
        var result = new Texture2D(sw, sh, format, false);
        var currentRT = RenderTexture.active;
        var rt = new RenderTexture(sw, sh, 32);
        Graphics.Blit(self, rt);
        RenderTexture.active = rt;
        var source = new Rect(0, 0, rt.width, rt.height);
        result.ReadPixels(source, 0, 0);
        result.Apply();
        RenderTexture.active = currentRT;
        return result;
    }
}
