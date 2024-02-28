using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COMMAND
{
    ATTACK = 0,
    ITEM,
    SKILL
}

public class ContentList : MonoBehaviour
{
    // 中身の表示場所
    [SerializeField] GameObject myContent;
    // 中身の表示オブジェクト
    [SerializeField] GameObject Node;

    public void PrintList(Bag bag)
    {
        StartCoroutine(CreateList(bag));
    }

    IEnumerator CreateList(Bag bag)
    {
        // リストをリセット
        ResetList();

        // ノードをセット
        for (int i = 0; i < bag.Content.Count; i++)
        {
            // プレファブを子要素として設定
            GameObject NodeObject = SetChild(Node);

            yield return null;

            ItemNode node = NodeObject.GetComponent<ItemNode>();
            node.SetItem(bag, i);
        }
    }

    private GameObject SetChild(GameObject prefab)
    {
        GameObject PrefabObject = Instantiate(prefab);
        PrefabObject.transform.SetParent(myContent.transform);
        return PrefabObject;
    }

    private void ResetList()
    {
        for (int i = 0; i < myContent.transform.childCount; i++)
        {
            GameObject ChildObject = myContent.transform.GetChild(i).gameObject;
            if (ChildObject.tag == "Node")
            {
                Destroy(ChildObject);
            }
        }
    }
}
