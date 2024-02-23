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

    // BGMを流すところ
    [SerializeField] AudioSource audioSource;

    // クリック音
    [SerializeField] AudioClip ClickSE;

    private bool isShowStage;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ShowStage(TestStageData);
        }
    }

    // 舞台を開始
    public void ShowStage(StageData stageData)
    {
        // コルーチンが動作中
        if (isShowStage)
        {
            return;
        }
        StartCoroutine(PlayStage(stageData));
    }

    // 舞台を再生
    IEnumerator PlayStage(StageData stageData)
    {
        isShowStage = true;
        Debug.Log("舞台が再生されます。");

        StageSetting.SetActive(true);
        Debug.Log("舞台の装置をアクティブにしました。");

        // かかっていたBGM
        AudioClip audioClip = audioSource.clip;

        // シーンを再生
        yield return PlayScene(stageData);

        // ステージをリセットする。
        StageReset();

        // BGMを元に戻す
        SetBGM(audioClip);

        StageSetting.SetActive(false);
        Debug.Log("舞台の装置を非アクティブにしました。");
        isShowStage = false;
    }

    IEnumerator PlayScene(StageData stageData)
    {
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
    }

    private void SetBGM(AudioClip BGM)
    {
        audioSource.clip = BGM;
        audioSource.Play();
    }

    // ステージをリセットします。
    private void StageReset()
    {
        Point1.EntryPointReset();
        Point2.EntryPointReset();
    }

    // 任意のマウスクリックを待機
    IEnumerator WaitMouseClick(int targetButtonNumber)
    {
        while (!Input.GetMouseButtonDown(targetButtonNumber))
        {
            yield return null;
        }
        audioSource.PlayOneShot(ClickSE);
    }

    // シーンを表示
    private void PrintScene(Scene scene)
    {
        // BGMがセットされたいたらBGMを変更
        if (scene.BGM != null)
        {
            SetBGM(scene.BGM);
        }

        // 台詞の表示
        TalkLabel.PlayLabel(scene.word);

        if (scene.IsReset)
        {
            StageReset();
            return;
        }

        // キャラクターの操作を実行
        foreach (var item in scene.characterOperations)
        {
            RunOperation(item);
        }
    }

    // 操作を実行
    private void RunOperation(CharacterOperation item)
    {
        // 使用するエントリーポイント
        CharacterEntryPoint useEntryPoint = Point1;
        // 使用するエントリーポイントを代入
        switch (item.Target)
        {
            case CharacterOperation.OPERATIONTARGET.FIRST:
                useEntryPoint = Point1;
                break;
            case CharacterOperation.OPERATIONTARGET.SECOND:
                useEntryPoint = Point2;
                break;
            default:
                break;
        }
        // 操作を実行
        switch (item.Type)
        {
            case ENTRYPOINTOPERATIONTYPE.REMOVE:
                useEntryPoint.Remove();
                break;
            case ENTRYPOINTOPERATIONTYPE.JOINT:
                JointOperation(item, useEntryPoint);
                break;
            case ENTRYPOINTOPERATIONTYPE.BLACKOUT:
                useEntryPoint.SetBlackOut(item.IsBlackOut);
                break;
            default:
                break;
        }
    }

    // ジョイント操作
    private static void JointOperation(CharacterOperation item, CharacterEntryPoint useEntryPoint)
    {
        if (item.JointImage != null)
        {
            useEntryPoint.Joint(item.JointImage);
            return;
        }
        if (item.JointSprite != null)
        {
            useEntryPoint.Joint(item.JointSprite);
        }
    }
}
