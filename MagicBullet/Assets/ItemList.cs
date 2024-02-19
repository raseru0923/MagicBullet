using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ItemList : MonoBehaviour
{
    public Text Subject;
    [SerializeField] private GameObject Content;
    [SerializeField] private GameObject NodePrefab;
    [SerializeField] private Button DeleteButton;
    private Button origineButton;
    private Button defaultButton;
    private string contentTag = "Node";

    public void SetContent(Item[] contents)
    {
        StartCoroutine(CreateNodes(contents));
    }
    public void SetContent(string[] texts)
    {
        StartCoroutine(CreateNodes(texts));
    }

    private IEnumerator CreateNodes(Item[] contents)
    {
        string[] texts = new string[contents.Length];
        int i = 0;
        foreach (var item in contents)
        {
            texts[i] = item.Name;

            Debug.Log(item.Name);

            ++i;
        }
        yield return CreateNodes(texts);
    }

    private IEnumerator CreateNodes(string[] texts)
    {
        origineButton = EventSystem.current.currentSelectedGameObject.gameObject.GetComponent<Button>();

        foreach (var item in Content.GetChildren())
        {
            if (item.tag == contentTag) { Destroy(item); }
        }

        int textsLength = texts.Length;
        GameObject[] nodes = new GameObject[textsLength];
        for (int i = 0; i < textsLength; i++)
        {
            nodes[i] = Instantiate(NodePrefab);
        }

        // 1フレーム待機
        yield return null;

        for (int i = 0; i < textsLength; i++)
        {
            nodes[i].transform.SetParent(Content.transform);
            nodes[i].GetComponent<Node>().SetLabel(texts[i]);
        }

        yield return nodes[0].AddComponent<DefaultSelect>();

        StartCoroutine(CheckListExit());
    }

    IEnumerator CheckListExit()
    {
        Debug.Log("チェック開始");
        bool onList = true;

        //DeleteButton.gameObject.SetActive(false);

        while (onList)
        {
            onList = CheckSelectTag(onList, contentTag);
            yield return new WaitForFixedUpdate();
        }

        SetDeleteButton();
    }

    private void SetDeleteButton()
    {
        DeleteButton.Select();
        Navigation navigation = DeleteButton.navigation;
        navigation.mode = Navigation.Mode.Explicit;

        navigation = SetSelectTables(navigation, new Selectable[] { null, defaultButton, null, null });

        DeleteButton.navigation = navigation;

        // ボタンの選択切替チェック
        StartCoroutine(CheckSelectButtonExit());
    }

    private Navigation SetSelectTables(Navigation navigation, Selectable[] selectables)
    {
        navigation.selectOnDown = selectables[0];
        navigation.selectOnLeft = selectables[1];
        navigation.selectOnRight = selectables[2];
        navigation.selectOnUp = selectables[3];
        return navigation;
    }

    IEnumerator CheckSelectButtonExit()
    {
        GameObject selectObject = EventSystem.current.currentSelectedGameObject.gameObject;

        while (selectObject == EventSystem.current.currentSelectedGameObject.gameObject)
        {
            yield return new WaitForFixedUpdate();
        }

        StartCoroutine(CheckListExit());
    }

    private bool CheckSelectTag(bool onList, string tagName)
    {
        GameObject selectObject = EventSystem.current.currentSelectedGameObject.gameObject;

        Debug.Log(selectObject.tag);
        if (selectObject.tag == tagName)
        {
            defaultButton = selectObject.GetComponent<Button>();
            return true;
        }

        return false;
    }

    public void CloseList()
    {
        origineButton.Select();
        this.gameObject.SetActive(false);
    }
}

public static class GameObjectChild
{
    public static GameObject[] GetChildren(this GameObject gameObject)
    {
        int childLength = gameObject.transform.childCount;

        GameObject[] children = new GameObject[childLength];

        for (int i = 0; i < childLength; i++)
        {
            children[i] = gameObject.transform.GetChild(i).gameObject;
        }

        return children;
    }
}
