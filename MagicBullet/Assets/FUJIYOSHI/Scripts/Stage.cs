using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    // 舞台の装置
    [SerializeField] GameObject StageSetting;

    // キャラクターの表示位置
    [SerializeField] CharacterEntryPoint Point1;
    [SerializeField] CharacterEntryPoint Point2;

    // 会話表示
    [SerializeField] Label TalkLabel;

    [SerializeField] StageData TestStageData;

    private void Start()
    {
        ShowStage(TestStageData);
    }

    public void ShowStage(StageData stageData)
    {
        StartCoroutine(PlayStage(stageData));
    }

    IEnumerator PlayStage(StageData stageData)
    {
        Debug.Log("舞台が再生されます。");

        StageSetting.SetActive(true);
        Debug.Log("舞台の装置をアクティブにしました。");

        foreach (var item in stageData.Scenes)
        {
            // シーンを表示
            PrintScene(item);
            Debug.Log("シーンを表示");

            // クリックで次へ
            yield return WaitMouseClick(0);

            Debug.Log("次のシーンへ");
            yield return null;
        }

        StageSetting.SetActive(false);
        Debug.Log("舞台の装置を非アクティブにしました。");
    }

    IEnumerator WaitMouseClick(int targetButtonNumber)
    {
        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }
    }

    private void PrintScene(Scene scene)
    {
        TalkLabel.PlayLabel(scene.word);
    }
}
