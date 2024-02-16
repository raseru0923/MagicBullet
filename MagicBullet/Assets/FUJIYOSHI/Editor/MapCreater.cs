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

        if (GUILayout.Button("マップアセットを作成"))
        {
            // マテリアルフォルダーのパス
            string materialPath = "Assets/FUJIYOSHI/Sprite/Materials/";
            // プレファブフォルダーのパス
            string prefabPath = "Assets/FUJIYOSHI/Prefabs/";
            // テクスチャーの名前
            string textureName = m_target.MapAssetSprite.name;
            // ベースとなるマテリアルの名前
            string baseMaterialName = "BaseMaterial.mat";
            // ベースとなるアセットの名前
            string baseAssetName = m_target.name + ".prefab";
            // マップアセットの名前
            string mapAssetName = textureName + baseAssetName;

            // マテリアルフォルダー内のBaseMaterialを取得
            Material baseMaterial = AssetDatabase.LoadAssetAtPath<Material>(materialPath + baseMaterialName);
            Debug.Log(baseMaterial.name);

            // マップアセットに使われるマテリアルをbaseMaterialと同じ値で生成
            Material mapAssetMaterial = new Material(baseMaterial);

            Debug.Log(textureName);
            // テクスチャーに指定テクスチャーを設定
            mapAssetMaterial.mainTexture = m_target.MapAssetSprite.texture;

            AssetDatabase.CreateAsset(mapAssetMaterial, materialPath + textureName + ".mat");
            AssetDatabase.SaveAssets();

            mapAssetMaterial = AssetDatabase.LoadAssetAtPath<Material>(materialPath + textureName + ".mat");
            // ベースタイルを取得
            GameObject contentsRoot = PrefabUtility.LoadPrefabContents(prefabPath + baseAssetName);
            // ベースタイルのMeshRendererを取得
            //MeshRenderer renderer = contentsRoot.GetComponent<MeshRenderer>();
            contentsRoot.GetComponent<MeshRenderer>().sharedMaterial = mapAssetMaterial;

            // 状態を保存する
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