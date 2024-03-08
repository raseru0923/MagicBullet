using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class f_List : MonoBehaviour
{
    // �m�[�h�̐݌v�}
    [SerializeField] GameObject NodePrefab;
    // �m�[�h����ׂ�ꏊ
    [SerializeField] GameObject Content;
    // ���X�g�^�C�g��
    [SerializeField] Text TitleText;

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
        Node node = nodeObject.GetComponent<Node>();

        // �e��Content���w��
        nodeObject.transform.SetParent(Content.transform);

        yield return null;

        // �m�[�h�Ƀe�L�X�g��ݒ�
        node.SetLabel(nodeName);
    }

    // �^�C�g����ݒ�
    public void SetTitle(string name)
    {
        TitleText.text = name;
        if (name == "�U��")
        {
            StatusManager.Instance.SetMode(12);
            return;
        }
        if (name == "�X�e�[�^�X")
        {
            StatusManager.Instance.SetMode(0);
            return;
        }
        StatusManager.Instance.SetMode(58);
    }
}
