using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class f_List : MonoBehaviour
{
    // �m�[�h�̐݌v�}
    [SerializeField] GameObject NodePrefab;
    // �m�[�h����ׂ�ꏊ
    [SerializeField] GameObject Content;

    [SerializeField] string[] TestNames;

    public void CreateList(GameObject iContentNames)
    {
        if (iContentNames.GetComponent<IContentNames>() != null)    // null�`�F�b�N
        {
            IContentNames contentNames = iContentNames.GetComponent<IContentNames>();
            CreateList(contentNames.GetNames());
            return;
        }
        Debug.LogError("IContentNames�C���^�[�t�F�[�X���p�������I�u�W�F�N�g���w�肵�Ă��������I");
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
        // �m�[�h�����
        GameObject nodeObject = Instantiate(NodePrefab);
        f_Node node = nodeObject.GetComponent<f_Node>();

        // �e��Content���w��
        nodeObject.transform.SetParent(Content.transform);

        yield return null;

        // �m�[�h�Ƀe�L�X�g��ݒ�
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
