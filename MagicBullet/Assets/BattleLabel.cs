using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// âÊñ è„Ç…èÓïÒÇ»Ç«Çï\é¶Ç∑ÇÈ
public class BattleLabel : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private float PlaySpeed;
    public word[] words;

    public void PlayPrintLabel(int index)
    {
        StartCoroutine(PrintLabel(words[index]));
    }

    private IEnumerator PrintLabel(word textDatas)
    {
        for (int i = 0; i < textDatas.words.Length; i++)
        {
            LabelText.text = textDatas.words[i];
            yield return new WaitForSeconds(PlaySpeed);
        }
        LabelText.text = null;
        this.gameObject.SetActive(false);
    }

    [System.Serializable]
    public class word
    {
        public string[] words;
    }
}
