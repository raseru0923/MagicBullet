using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class f_List : MonoBehaviour
{
    // ノードの設計図
    [SerializeField] GameObject NodePrefab;
    // ノードを並べる場所
    [SerializeField] GameObject Content;
    // リストタイトル
    [SerializeField] Text TitleText;

    public void CreateList(GameObject iContentNames)
    {
        Cursor.lockState = CursorLockMode.None;
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
        Cursor.lockState = CursorLockMode.None;
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
        Cursor.lockState = CursorLockMode.None;
        CreateList(nodeNames.ToList());
    }

    IEnumerator CreateNode(string nodeName)
    {
        // ノードを作る
        GameObject nodeObject = Instantiate(NodePrefab);
        Node node = nodeObject.GetComponent<Node>();

        // 親にContentを指定
        nodeObject.transform.SetParent(Content.transform);

        yield return null;

        // ノードにテキストを設定
        node.SetLabel(nodeName);
    }

    // タイトルを設定
    public void SetTitle(string name)
    {
        TitleText.text = name;
        if (name == "攻撃")
        {
            StatusManager.Instance.SetMode(12);
            return;
        }
        if (name == "ステータス")
        {
            StatusManager.Instance.SetMode(0);
            return;
        }
        StatusManager.Instance.SetMode(58);
    }


    private void FixedUpdate()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
