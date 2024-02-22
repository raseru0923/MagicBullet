using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityGUI;

#if UNITY_EDITOR
public class MansionCreater : EditorWindow
{
    // エリアの境界をタップされたことを感知する。
    private class Area
    {
        private RunAreaOperations operation;
        private Rect areaRect;

        // 自動プロパティ
        public Vector2 AreaPos
        {
            get; set;
        }

        public Rect AreaRect
        {
            get { return areaRect; }
            set { areaRect = value; }
        }
        public RunAreaOperations Operation
        {
            get { return operation; }
        }

        public Area(RunAreaOperations setOperation, Rect setAreaRect, Rect windowRect)
        {
            SetArea(setOperation, setAreaRect, windowRect);
            AreaPos = Vector2.zero;
        }

        public Area(RunAreaOperations setOperation, float beforeAreaX, Rect setAreaRect, Rect windowRect)
        {
            SetArea(setOperation, setAreaRect, windowRect);
            AreaPos = Vector2.zero;
            areaRect.x = beforeAreaX;
        }

        public void SetArea(RunAreaOperations setOperation, Rect setAreaRect, Rect windowRect)
        {
            operation = setOperation;
            areaRect.height = Mathf.Clamp(setAreaRect.height, 0, windowRect.height);
            areaRect.width = Mathf.Clamp(setAreaRect.width, 0, windowRect.width);
            areaRect.position = setAreaRect.position;
        }
    }

    // エディター上でのマウスイベント用
    GUIInput _GUIInput = GUIInput.GetInstance();
    [MenuItem("Editor/MansionCreater")]
    private static void Create()
    {
        // ウィンドウ生成
        MansionCreater window = GetWindow<MansionCreater>("MansionCreater");
        // 最小サイズ設定
        window.minSize = new Vector2(320, 320);
    }

    // 使用するアセットを選択するときの表示に関するパラメーターを持つ構造体
    private struct EnterFieldParameter
    {
        // アセットの名前
        private string name;
        // 表示するラベル
        private string label;

        // 配列の添え字の自動プロパティ
        public int Index
        {
            get; set;
        }

        // nameの読み取り専用プロパティ
        public string Name
        {
            get { return name; }
        }

        // labelの読み取り専用プロパティ
        public string Label
        {
            get { return label; }
        }

        // コンストラクタ
        public EnterFieldParameter(string _name, string _label)
        {
            Index = 0;
            name = _name;
            label = _label;
        }
    }

    EnterFieldParameter[] parameters =
    {
        new EnterFieldParameter("TileData.asset","タイルを選択"), // タイル
        new EnterFieldParameter("WallData.asset","壁を選択"),     // 壁
        new EnterFieldParameter("DoorData.asset","ドアを選択"),   // ドア
    };

    int toolbarInt = 0;
    string[] toolbarString = { "タイル", "壁", "ドア" };

    private delegate void RunAreaOperations();
    private delegate void AdjustArea(RunAreaOperations operation, Rect rect);

    private RunAreaOperations[] operations;

    Vector2 mousePositionBase;
    Vector2 mousePositionDelta;

    private Area[] areas = null;

    int currentAreaNum = 0;

    // アップデートする必要がある
    bool needUpdate = false;

    GUIContent StartGUIContent = new GUIContent("Start");

    Texture[] choiceTextures;
    int choiceI = 0;

    private void OnGUI()
    {
        //Debug.Log("Window Position:" + position.position);
        //Debug.Log("Window Size:" + position.size);
        // ウィンドウの左上を基準としたマウス座標
        //Debug.Log("Mouse Position:" + Event.current.mousePosition);

        // windowの中身を作成
        operations = AddOperationWrapper(new Vector2(50, 0), () =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                choiceI = i;
                parameters[i].Index = CreateMapAssetsEnterField(parameters[i]);
            }
        });
        operations = AddOperationWrapper(new Vector2(50, 0), () =>
        {
            toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarString);
            EditorGUILayout.LabelField("ここにマップ作成画面を表示");

            Vector2 areaSize = areas[currentAreaNum].AreaRect.size;

            Vector2 buttonSize = Vector2.one * 50;
            Vector2 buttonPos = (areaSize / 2 - buttonSize / 2);

            Vector2 VerticalWallSize = new Vector2(25, 50);
            Vector2 HorizontalWallSize = new Vector2(50, 25);

            if (ScrollButton(buttonPos, buttonSize, StartGUIContent))
            {
                StartGUIContent = new GUIContent(choiceTextures[toolbarInt]);
            }
            if (ScrollButton(buttonPos - new Vector2(VerticalWallSize.x, 0), VerticalWallSize, StartGUIContent))
            {
                StartGUIContent = new GUIContent(choiceTextures[toolbarInt]);
            }
            if (ScrollButton(buttonPos + new Vector2(buttonSize.x, 0), VerticalWallSize, StartGUIContent))
            {
                StartGUIContent = new GUIContent(choiceTextures[toolbarInt]);
            }
            if (ScrollButton(buttonPos - new Vector2(0, HorizontalWallSize.y), HorizontalWallSize, StartGUIContent))
            {
                StartGUIContent = new GUIContent(choiceTextures[toolbarInt]);
            }
            if (ScrollButton(buttonPos + new Vector2(0, buttonSize.y), HorizontalWallSize, StartGUIContent))
            {
                StartGUIContent = new GUIContent(choiceTextures[toolbarInt]);
            }

            if (_GUIInput.MOUSEBUTTONDOWN(2))
            {
                mousePositionBase = Event.current.mousePosition;
                needUpdate = true;
            }
            else if (_GUIInput.MOUSEBUTTON(2))
            {
                mousePositionDelta = Event.current.mousePosition - mousePositionBase;
                areas[currentAreaNum].AreaPos += mousePositionDelta;
                mousePositionBase = Event.current.mousePosition;
            }

            if (_GUIInput.MOUSEBUTTONUP(2))
            {
                needUpdate = false;
            }
        });

        // ウィンドウを生成
        CreateArea(operations);

        // ウィンドウの重複を防ぐ
        operations = new RunAreaOperations[0];
    }

    private void Update()
    {
        if (needUpdate)
        {
            Repaint();
        }
    }

    private bool ScrollButton(Vector2 buttonPos, Vector2 buttonSize, GUIContent gUIContent)
    {
        return GUI.Button(new Rect(areas[currentAreaNum].AreaPos + buttonPos, buttonSize), gUIContent);
    }

    private RunAreaOperations[] AddOperationWrapper(Vector2 AreaSize, RunAreaOperations operation)
    {
        return AddOperation(AreaSize, operations, operation);
    }

    private RunAreaOperations[] AddOperation(Vector2 AreaSize, RunAreaOperations[] operations, RunAreaOperations operation)
    {
        int length = (operations != null) ? operations.Length : 0;
        RunAreaOperations[] _operations = operations;
        operations = new RunAreaOperations[length + 1];

        for (int i = 0; i < length; i++)
        {
            operations[i] = _operations[i];
        }

        operations[length] = operation;
        return operations;
    }

    private void CreateArea(RunAreaOperations[] operations)
    {
        int operationsLength = operations.Length;

        if (areas == null || areas.Length != operationsLength || areas[areas.Length - 1].AreaRect.x + areas[areas.Length - 1].AreaRect.width != position.x + position.width)
        {
            areas = new Area[operationsLength];
            for (int i = 0; i < operationsLength; i++)
            {
                Rect areaRect = new Rect((position.size.x * i) / operationsLength, 0, position.size.x / operationsLength, position.size.y);
                areas[i] = new Area(operations[i], areaRect, position);
            }
            Debug.Log("実行");
        }

        for (int i = 0; i < operationsLength; i++)
        {
            if (i != 0)
            {
                areas[i].SetArea(areas[i].Operation, areas[i].AreaRect, position);
                Rect areaRect = areas[i].AreaRect;
                areaRect.x = areas[i - 1].AreaRect.x + areas[i - 1].AreaRect.width;
                areas[i].AreaRect = areaRect;
            }
            CreateAdjustArea(areas[i].Operation, areas[i].AreaRect);
        }
        currentAreaNum = 0;
    }

    // 
    private void CreateAdjustArea(RunAreaOperations operation, Rect rect)
    {
        using (new GUILayout.AreaScope(rect))
        {
            operation?.Invoke();
        }
        ++currentAreaNum;
    }

    // マップアセット選択領域を表示
    private int CreateMapAssetsEnterField(EnterFieldParameter parameter)
    {
        string[] m_PopupDisplayOptions;
        MansionMapAssets mapAssetData;

        string scriptableObjectPath = "Assets/FUJIYOSHI/Scripts/ScriptableObject/";

        // マップアセットをファイルから取得
        mapAssetData = AssetDatabase.LoadAssetAtPath<MansionMapAssets>(scriptableObjectPath + parameter.Name);

        // 選択リストをマップアセットの個数分確保する。
        m_PopupDisplayOptions = new string[mapAssetData.MapAssets.Length];

        for (int i = 0; i < mapAssetData.MapAssets.Length; i++)
        {
            int typeWordCount = 25;                 // ファイルタイプの文字数
            string assetName = mapAssetData.MapAssets[i].ToString();
            // ファイルタイプの文字列を除く
            assetName = assetName.Substring(0, assetName.Length - typeWordCount);
            m_PopupDisplayOptions[i] = assetName;   // 選択リストに名前を登録
        }

        // 選択リストを表示
        parameter.Index = EditorGUILayout.Popup(
    label: parameter.Label,
    selectedIndex: parameter.Index,
    displayedOptions: m_PopupDisplayOptions
);
        Texture texture = mapAssetData.MapAssets[parameter.Index].GetComponent<MeshRenderer>().sharedMaterials[0].mainTexture;
        choiceTextures = (choiceTextures == null) ? new Texture[parameters.Length] : choiceTextures;
        choiceTextures[choiceI] = texture;
        int imageHeight = 50,
            imageWidth = 50;

        EditorGUILayout.LabelField("テクスチャ▼");
        EditorGUILayout.LabelField(new GUIContent(texture), GUILayout.Height(imageHeight), GUILayout.Width(imageWidth));

        return parameter.Index;
    }

    private IEnumerator CountUp()
    {
        int time = 0;
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(++time);
        }
    }
}
#endif
