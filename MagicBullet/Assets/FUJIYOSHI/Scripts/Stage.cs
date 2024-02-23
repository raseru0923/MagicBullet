using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    // ����̑��u
    [SerializeField] GameObject StageSetting;

    // �L�����N�^�[�̕\���ʒu
    [SerializeField] CharacterEntryPoint Point1;
    [SerializeField] CharacterEntryPoint Point2;

    // ��b�\��
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
        Debug.Log("���䂪�Đ�����܂��B");

        StageSetting.SetActive(true);
        Debug.Log("����̑��u���A�N�e�B�u�ɂ��܂����B");

        foreach (var item in stageData.Scenes)
        {
            // �V�[����\��
            PrintScene(item);
            Debug.Log("�V�[����\��");

            // �N���b�N�Ŏ���
            yield return WaitMouseClick(0);

            Debug.Log("���̃V�[����");
            yield return null;
        }

        StageSetting.SetActive(false);
        Debug.Log("����̑��u���A�N�e�B�u�ɂ��܂����B");
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
