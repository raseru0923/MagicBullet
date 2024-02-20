using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// ���������Ǝ��g�̎q�v�f�Ƀ{�^�������̐ݒ���s��

public class MapTip : MonoBehaviour
{
    [SerializeField] private FullButton[] TipButton;
    private TipData[] TipDatas;

    private SetButtonActions.CallButton callButton = SetButtonActions.CallButton.Instance;
    [SerializeField] private MapPallet mapPallet;
    KeyNumberCombertion keyNumberCombertion = new KeyNumberCombertion();

    MapPallet.MAPTYPE mode = MapPallet.MAPTYPE.NUM;
    [SerializeField] private Dropdown CurrentMode;

    [SerializeField] private Dropdown AssetsList;
    List<Dropdown.OptionData> options = new List<Dropdown.OptionData> { new Dropdown.OptionData("") };

    // ���[�h�̕ύX���m�F
    bool isModeChange = false;

    // Start is called before the first frame update
    void Start()
    {
        TipDatas = new TipData[TipButton.Length];
        // �^�C���`�b�v�������ꂽ�Ƃ���TileSet�̏������s����悤�ɂ���B
        callButton.SetClickActions(TipButton, SetAsset);

        mode = (MapPallet.MAPTYPE)CurrentMode.value;
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
            Debug.Log("���[�h���ύX����܂���");

            mode = (MapPallet.MAPTYPE)CurrentMode.value;
            CreateList();
        }
    }

    private void SetAsset()
    {
        Debug.Log("Tile���Z�b�g���܂�");
        Debug.Log(mode);
        switch (mode)
        {
            case MapPallet.MAPTYPE.TILE:
                TileSet();
                break;
            case MapPallet.MAPTYPE.WALL:
                WallSet();
                break;
            case MapPallet.MAPTYPE.DOOR:
                DoorSet();
                break;
            default:
                break;
        }
    }

    // �^�C���Ƀ}�b�v�A�Z�b�g��ݒ�
    private void TileSet()
    {
        if (callButton.CallObj.tag == "TileTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("TileTip(�傫���}�X)�ɐݒ肵�Ă�������");
    }

    private void WallSet()
    {
        if (callButton.CallObj.tag == "WallDoorTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("WallDoorTip(�㉺���E�̏������}�X)�ɐݒ肵�Ă�������");
    }
    private void DoorSet()
    {
        if (callButton.CallObj.tag == "WallDoorTip")
        {
            SetTip();
            return;
        }
        Debug.LogWarning("WallDoorTip(�㉺���E�̏������}�X)�ɐݒ肵�Ă�������");
    }

    private void SetTip()
    {
        int setMode = (int)mode;
        MansionMapAssets useAssets = mapPallet.Pallets[setMode];
        GameObject[] useMapAssets = useAssets.MapAssets;

        Image tipImage = callButton.CallObj.GetComponent<Image>();

        int palletsIndex = AssetsList.value;

        if (0 <= palletsIndex && palletsIndex < useMapAssets.Length)
        {
            // �C���[�W���f����
            Texture mainTexture = useMapAssets[palletsIndex].GetComponent<MeshRenderer>().sharedMaterial.mainTexture;
            Texture2D texture2D = mainTexture.ToTexture2D();
            tipImage.sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.zero);
            Debug.Log(setMode + "��" + useMapAssets[palletsIndex].name + "��ݒ肵�܂����B");

            // �`�b�v�f�[�^��ۑ�
            int i = 0;
            foreach (var item in TipButton)
            {
                if (callButton.CallObj.name == item.name)
                {
                    TipDatas[i] = new TipData(palletsIndex, mode);
                    Debug.Log(item.name + "��" + mode + "��" + palletsIndex.ToString() + "��ݒ肵�܂����B");
                    return;
                }
                ++i;
            }
            return;
        }

        Debug.LogWarning("�g�������}�b�v�A�b�Z�g�̐����L�[�������Ȃ�����s���Ă�������");
    }

    // ���[�h�̃C�j�V�����ƍ��v���郂�[�h��ԋp����B
    private MapPallet.MAPTYPE ModeInitialKeyToMAPMODE()
    {
        for (int i = 0; i < (int)MapPallet.MAPTYPE.NUM; i++)
        {
            if (Input.GetKey(TextToLowerInitial(((MapPallet.MAPTYPE)i).ToString())))
            {
                return (MapPallet.MAPTYPE)i;
            }
        }
        return MapPallet.MAPTYPE.NUM;
    }

    // �C�j�V�������������ŕԋp
    private string TextToLowerInitial(string text)
    {
        return text.ToLower().Substring(0, 1);
    }

    void CreateList()
    {
        AssetsList.ClearOptions();
        if (options != null) { options.Clear(); }

        if (mode == MapPallet.MAPTYPE.NUM) { return; }
        int setMode = (int)mode;
        MansionMapAssets useAssets = mapPallet.Pallets[setMode];
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
