using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class f_List : MonoBehaviour
{
    // ノードの設計図
    [SerializeField] GameObject NodePrefab;
    // ノードを並べる場所
    [SerializeField] GameObject Content;

    [SerializeField] string[] TestNames;

    public void CreateList(GameObject iContentNames)
    {
        if (iContentNames.GetComponent<IContentNames>() != null)    // nullチェック
        {
            IContentNames contentNames = iContentNames.GetComponent<IContentNames>();
            CreateList(contentNames.GetNames());
            return;
        }
        Debug.LogError("IContentNamesインターフェースを継承したオブジェクトを指定してください！");
    }

    public void CreateList(List<string> nodeNames)
    {
        for (int i = 0; i < Content.transform.childCount; i++)
        {
            GameObject childObject = Content.transform.GetChild(i).gameObject;
            if (childObject.tag == "Node")
            {
                Destroy(Content.transform.GetChild(i).gameObject);
            }
        }

        foreach (var item in nodeNames)
        {
            StartCoroutine(CreateNode(item));
        }
    }

    public void CreateList(string[] nodeNames)
    {
        CreateList(nodeNames.ToList());
    }

    IEnumerator CreateNode(string nodeName)
    {
        // ノードを作る
        GameObject nodeObject = Instantiate(NodePrefab);
        f_Node node = nodeObject.GetComponent<f_Node>();

        // 親にContentを指定
        nodeObject.transform.SetParent(Content.transform);

        yield return null;

        // ノードにテキストを設定
        node.SetLabel(nodeName);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreateList(TestNames);
        }
    }
}
