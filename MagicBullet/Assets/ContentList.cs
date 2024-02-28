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
    // ���g�̕\���ꏊ
    [SerializeField] GameObject myContent;
    // ���g�̕\���I�u�W�F�N�g
    [SerializeField] GameObject Node;

    public void PrintList(Bag bag)
    {
        StartCoroutine(CreateList(bag));
    }

    IEnumerator CreateList(Bag bag)
    {
        // ���X�g�����Z�b�g
        ResetList();

        // �m�[�h���Z�b�g
        for (int i = 0; i < bag.Content.Count; i++)
        {
            // �v���t�@�u���q�v�f�Ƃ��Đݒ�
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
