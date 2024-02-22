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
    // �G���A�̋��E���^�b�v���ꂽ���Ƃ����m����B
    private class Area
    {
        private RunAreaOperations operation;
        private Rect areaRect;

        // �����v���p�e�B
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

    // �G�f�B�^�[��ł̃}�E�X�C�x���g�p
    GUIInput _GUIInput = GUIInput.GetInstance();
    [MenuItem("Editor/MansionCreater")]
    private static void Create()
    {
        // �E�B���h�E����
        MansionCreater window = GetWindow<MansionCreater>("MansionCreater");
        // �ŏ��T�C�Y�ݒ�
        window.minSize = new Vector2(320, 320);
    }

    // �g�p����A�Z�b�g��I������Ƃ��̕\���Ɋւ���p�����[�^�[�����\����
    private struct EnterFieldParameter
    {
        // �A�Z�b�g�̖��O
        private string name;
        // �\�����郉�x��
        private string label;

        // �z��̓Y�����̎����v���p�e�B
        public int Index
        {
            get; set;
        }

        // name�̓ǂݎ���p�v���p�e�B
        public string Name
        {
            get { return name; }
        }

        // label�̓ǂݎ���p�v���p�e�B
        public string Label
        {
            get { return label; }
        }

        // �R���X�g���N�^
        public EnterFieldParameter(string _name, string _label)
        {
            Index = 0;
            name = _name;
            label = _label;
        }
    }

    EnterFieldParameter[] parameters =
    {
        new EnterFieldParameter("TileData.asset","�^�C����I��"), // �^�C��
        new EnterFieldParameter("WallData.asset","�ǂ�I��"),     // ��
        new EnterFieldParameter("DoorData.asset","�h�A��I��"),   // �h�A
    };

    int toolbarInt = 0;
    string[] toolbarString = { "�^�C��", "��", "�h�A" };

    private delegate void RunAreaOperations();
    private delegate void AdjustArea(RunAreaOperations operation, Rect rect);

    private RunAreaOperations[] operations;

    Vector2 mousePositionBase;
    Vector2 mousePositionDelta;

    private Area[] areas = null;

    int currentAreaNum = 0;

    // �A�b�v�f�[�g����K�v������
    bool needUpdate = false;

    GUIContent StartGUIContent = new GUIContent("Start");

    Texture[] choiceTextures;
    int choiceI = 0;

    private void OnGUI()
    {
        //Debug.Log("Window Position:" + position.position);
        //Debug.Log("Window Size:" + position.size);
        // �E�B���h�E�̍������Ƃ����}�E�X���W
        //Debug.Log("Mouse Position:" + Event.current.mousePosition);

        // window�̒��g���쐬
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
            EditorGUILayout.LabelField("�����Ƀ}�b�v�쐬��ʂ�\��");

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

        // �E�B���h�E�𐶐�
        CreateArea(operations);

        // �E�B���h�E�̏d����h��
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
            Debug.Log("���s");
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

    // �}�b�v�A�Z�b�g�I��̈��\��
    private int CreateMapAssetsEnterField(EnterFieldParameter parameter)
    {
        string[] m_PopupDisplayOptions;
        MansionMapAssets mapAssetData;

        string scriptableObjectPath = "Assets/FUJIYOSHI/Scripts/ScriptableObject/";

        // �}�b�v�A�Z�b�g���t�@�C������擾
        mapAssetData = AssetDatabase.LoadAssetAtPath<MansionMapAssets>(scriptableObjectPath + parameter.Name);

        // �I�����X�g���}�b�v�A�Z�b�g�̌����m�ۂ���B
        m_PopupDisplayOptions = new string[mapAssetData.MapAssets.Length];

        for (int i = 0; i < mapAssetData.MapAssets.Length; i++)
        {
            int typeWordCount = 25;                 // �t�@�C���^�C�v�̕�����
            string assetName = mapAssetData.MapAssets[i].ToString();
            // �t�@�C���^�C�v�̕����������
            assetName = assetName.Substring(0, assetName.Length - typeWordCount);
            m_PopupDisplayOptions[i] = assetName;   // �I�����X�g�ɖ��O��o�^
        }

        // �I�����X�g��\��
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

        EditorGUILayout.LabelField("�e�N�X�`����");
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
