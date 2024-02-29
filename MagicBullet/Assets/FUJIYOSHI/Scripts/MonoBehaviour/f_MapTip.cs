using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// ���������Ǝ��g�̎q�v�f�Ƀ{�^�������̐ݒ���s��

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

    // ���[�h�̕ύX���m�F
    bool isModeChange = false;

    // Start is called before the first frame update
    void Start()
    {
        TipDatas = new f_TipData[TipButton.Length];
        // �^�C���`�b�v�������ꂽ�Ƃ���TileSet�̏������s����悤�ɂ���B
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
            Debug.Log("���[�h���ύX����܂���");

            mode = (f_MapPallet.MAPTYPE)CurrentMode.value;
            CreateList();
        }
    }

    private void SetAsset()
    {
        Debug.Log("Tile���Z�b�g���܂�");
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
        f_MansionMapAssets useAssets = mapPallet.Pallets[setMode];
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
                    TipDatas[i] = new f_TipData(palletsIndex, mode);
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

    // �C�j�V�������������ŕԋp
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
