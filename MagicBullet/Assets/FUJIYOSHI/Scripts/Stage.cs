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

    private bool isShowStage;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ShowStage(TestStageData);
        }
    }

    // ������J�n
    public void ShowStage(StageData stageData)
    {
        // �R���[�`�������쒆
        if (isShowStage)
        {
            return;
        }
        StartCoroutine(PlayStage(stageData));
    }

    // ������Đ�
    IEnumerator PlayStage(StageData stageData)
    {
        isShowStage = true;
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

        StageReset();

        StageSetting.SetActive(false);
        Debug.Log("����̑��u���A�N�e�B�u�ɂ��܂����B");
        isShowStage = false;
    }

    // �X�e�[�W�����Z�b�g���܂��B
    private void StageReset()
    {
        Point1.EntryPointReset();
        Point2.EntryPointReset();
    }

    // �C�ӂ̃}�E�X�N���b�N��ҋ@
    IEnumerator WaitMouseClick(int targetButtonNumber)
    {
        while (!Input.GetMouseButtonDown(targetButtonNumber))
        {
            yield return null;
        }
    }

    // �V�[����\��
    private void PrintScene(Scene scene)
    {
        // �䎌�̕\��
        TalkLabel.PlayLabel(scene.word);

        if (scene.isReset)
        {
            StageReset();
            return;
        }

        // �L�����N�^�[�̑�������s
        foreach (var item in scene.characterOperations)
        {
            RunOperation(item);
        }
    }

    // ��������s
    private void RunOperation(CharacterOperation item)
    {
        // �g�p����G���g���[�|�C���g
        CharacterEntryPoint useEntryPoint = Point1;
        // �g�p����G���g���[�|�C���g����
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
        // ��������s
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

    // �W���C���g����
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
