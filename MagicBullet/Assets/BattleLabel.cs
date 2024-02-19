using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// âÊñ è„Ç…èÓïÒÇ»Ç«Çï\é¶Ç∑ÇÈ
public class BattleLabel : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private GameObject Label;
    [SerializeField] private float PlaySpeed;
    public word[] words;

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
        public string[] words;
    }
}
