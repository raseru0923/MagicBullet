using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exeption : MonoBehaviour
{
    [TextArea] public string[] ExeptionText;
    [SerializeField] GameMaster gameMaster;

    public void PlayExeption()
    {
        StartCoroutine(SetExeption());
    }

    IEnumerator SetExeption()
    {
        foreach (var item in ExeptionText)
        {
            gameMaster.Moderate(item);

            yield return null;

            while (!Input.GetMouseButtonDown(0))
            {
                yield return null;
            }

        }
    }
}
