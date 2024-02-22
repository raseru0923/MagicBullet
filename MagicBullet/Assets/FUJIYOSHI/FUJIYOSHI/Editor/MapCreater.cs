using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MansionMapAssets))]
public class MapCreater : Editor
{
    private MansionMapAssets m_target;

    private void OnEnable()
    {
        m_target = (MansionMapAssets)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("�}�b�v�A�Z�b�g���쐬"))
        {
            // �}�e���A���t�H���_�[�̃p�X
            string materialPath = "Assets/FUJIYOSHI/Sprite/Materials/";
            // �v���t�@�u�t�H���_�[�̃p�X
            string prefabPath = "Assets/FUJIYOSHI/Prefabs/";
            // �e�N�X�`���[�̖��O
            string textureName = m_target.MapAssetSprite.name;
            // �x�[�X�ƂȂ�}�e���A���̖��O
            string baseMaterialName = "BaseMaterial.mat";
            // �x�[�X�ƂȂ�A�Z�b�g�̖��O
            string baseAssetName = m_target.name + ".prefab";
            // �}�b�v�A�Z�b�g�̖��O
            string mapAssetName = textureName + baseAssetName;

            // �}�e���A���t�H���_�[����BaseMaterial���擾
            Material baseMaterial = AssetDatabase.LoadAssetAtPath<Material>(materialPath + baseMaterialName);
            Debug.Log(baseMaterial.name);

            // �}�b�v�A�Z�b�g�Ɏg����}�e���A����baseMaterial�Ɠ����l�Ő���
            Material mapAssetMaterial = new Material(baseMaterial);

            Debug.Log(textureName);
            // �e�N�X�`���[�Ɏw��e�N�X�`���[��ݒ�
            mapAssetMaterial.mainTexture = m_target.MapAssetSprite.texture;

            AssetDatabase.CreateAsset(mapAssetMaterial, materialPath + textureName + ".mat");
            AssetDatabase.SaveAssets();

            mapAssetMaterial = AssetDatabase.LoadAssetAtPath<Material>(materialPath + textureName + ".mat");
            // �x�[�X�^�C�����擾
            GameObject contentsRoot = PrefabUtility.LoadPrefabContents(prefabPath + baseAssetName);
            // �x�[�X�^�C����MeshRenderer���擾
            //MeshRenderer renderer = contentsRoot.GetComponent<MeshRenderer>();
            contentsRoot.GetComponent<MeshRenderer>().sharedMaterial = mapAssetMaterial;

            // ��Ԃ�ۑ�����
            PrefabUtility.SaveAsPrefabAsset(contentsRoot, prefabPath + mapAssetName);
            PrefabUtility.UnloadPrefabContents(contentsRoot);

            GameObject addContentsRoot = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath + mapAssetName);

            Debug.Log(addContentsRoot);

            var saveItem = m_target.MapAssets;
            m_target.MapAssets = new GameObject[m_target.MapAssets.Length + 1];

            for (int i = 0; i < saveItem.Length; i++)
            {
                m_target.MapAssets[i] = saveItem[i];
            }

            m_target.MapAssets[saveItem.Length] = addContentsRoot;
        }
    }
}