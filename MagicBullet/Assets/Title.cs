using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await AnyKeyTapToNextScene("Status");
    }

    async UniTask AnyKeyTapToNextScene(string nextSceneName)
    {
        await UniTask.WaitForSeconds(1.0f);

        while (!Input.anyKey)
        {
            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
