using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exeption : MonoBehaviour
{
    [TextArea] public string[] ExeptionText;

    public void PlayExeption()
    {
        StartCoroutine(SetExeption());
    }

    IEnumerator SetExeption()
    {
        foreach (var item in ExeptionText)
        {
            GameMaster.Instance.Moderate(item);

            yield return null;

            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }

        }
    }
}
