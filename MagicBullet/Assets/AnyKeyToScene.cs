using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class AnyKeyToScene : MonoBehaviour
{
    [SerializeField] private string Destination;

    // Start is called before the first frame update
    async void Start()
    {
        await AnyKeyTapToNextScene();
    }

    async UniTask AnyKeyTapToNextScene()
    {
        await UniTask.WaitForSeconds(1.0f);

        while (!Input.anyKey)
        {
            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        SceneManager.LoadScene(Destination);
    }
}
