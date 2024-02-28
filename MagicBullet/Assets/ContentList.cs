using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentList : MonoBehaviour
{
    // ���g�̕\���ꏊ
    [SerializeField] GameObject myContent;
    // ���g�̕\���I�u�W�F�N�g
    [SerializeField] GameObject Node;

    public void PrintList(List<ObjectItem> content)
    {
        StartCoroutine(CreateList(content));
    }

    IEnumerator CreateList(List<ObjectItem> content)
    {
        for (int i = 0; i < myContent.transform.childCount; i++)
        {
            GameObject ChildObject = myContent.transform.GetChild(i).gameObject;
            if (ChildObject.tag == "Node")
            {
                Destroy(ChildObject);
            }
        }

        for (int i = 0; i < content.Count; i++)
        {
            var item = content[i];

            GameObject NodeObject = Instantiate(Node);
            NodeObject.transform.SetParent(myContent.transform);

            yield return null;

            ItemNode node = NodeObject.GetComponent<ItemNode>();
            node.SetItem(item, i);
        }
    }
}
