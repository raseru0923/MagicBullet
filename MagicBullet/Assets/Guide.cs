using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Guide : MonoBehaviour
{
    [SerializeField] private List<ThirdPersonTalk> TalkInformation;

    [SerializeField] private LookAtTargetOffset TargetLookAtTargetOffset;

    [SerializeField] private bool TalkAfterDestroy = false;
    // Start is called before the first frame update
    async void OnEnable()
    {
        await TalkThirdPerson(TalkInformation);
    }
    async void Start()
    {
        await TalkThirdPerson(TalkInformation);
    }

    [System.Serializable]
    public class ThirdPersonTalk
    {
        public string Text;
        public Transform TargetTransform;
    }

    private async UniTask TalkThirdPerson(List<ThirdPersonTalk> talkInformation)
    {
        foreach (var item in talkInformation)
        {
            if (item.TargetTransform != null)
            {
                TargetLookAtTargetOffset._target = item.TargetTransform;
            }

            if (item.Text != "")
            {
                await GameMaster.Instance.informationLabel.PlayLabelTask(item.Text);
            }

            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        TargetLookAtTargetOffset._target = null;

        if (TalkAfterDestroy)
        {
            this.gameObject.SetActive(false);

            await UniTask.WaitForSeconds(1.0f);

            UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
        }
    }
}
