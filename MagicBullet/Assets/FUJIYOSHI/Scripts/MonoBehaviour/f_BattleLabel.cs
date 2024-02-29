using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��ʏ�ɏ��Ȃǂ�\������
public class f_BattleLabel : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private GameObject Label;
    [SerializeField] private float PlaySpeed;
    public static f_BattleLabel Instance;
    public word[] words;

    [SerializeField, TextArea] string[] texts;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayPrintLabel(int index)
    {
        StartCoroutine(PrintLabel(words[index]));
    }

    public IEnumerator PrintLabel(int index)
    {
        yield return StartCoroutine(PrintLabel(words[index]));
    }

    private IEnumerator PrintLabel(word textDatas)
    {
        Label.SetActive(true);
        for (int i = 0; i < textDatas.words.Length; i++)
        {
            //LabelText.text = textDatas.words[i];
            LabelText.text = null;
            foreach (var item in textDatas.words[i])
            {
                LabelText.text += item;
                yield return new WaitForFixedUpdate();
            }
            yield return new WaitForSeconds(PlaySpeed);
        }
        LabelText.text = null;
        Label.SetActive(false);
    }

    [System.Serializable]
    public class word
    {
        [SerializeField, TextArea] public string[] words;
    }
}