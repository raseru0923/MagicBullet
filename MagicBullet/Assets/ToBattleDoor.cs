using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBattleDoor : MonoBehaviour
{
    // Update is called once per frame

    public void ToBattleScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
    }
}
