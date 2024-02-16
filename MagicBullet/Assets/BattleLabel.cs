using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// âÊñ è„Ç…èÓïÒÇ»Ç«Çï\é¶Ç∑ÇÈ
public class BattleLabel : MonoBehaviour
{
    [SerializeField] private Text LabelText;
    [SerializeField] private float PlaySpeed;
    public string[] words;

    public void PlayPrintLabel()
    {
        StartCoroutine(PrintLabel(words));
    }

    private IEnumerator PrintLabel(string[] textDatas)
    {
        for (int i = 0; i < textDatas.Length; i++)
        {
            LabelText.text = textDatas[i];
            yield return new WaitForSeconds(PlaySpeed);
        }
        LabelText.text = null;
        this.gameObject.SetActive(false);
    }
}
