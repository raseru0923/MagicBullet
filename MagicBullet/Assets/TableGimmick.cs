using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableGimmick : MonoBehaviour
{
    // �I�𒆂̃J�[�h�����X�g�`���ŕۑ�
    private List<string> SelectCardName = new List<string>();

    // �����̃J�[�h�̖��O��ۑ�
    [SerializeField] private List<string> GimmickPassCardName = new List<string>();

    // �v���C���[
    [SerializeField] private Player CurrentPlayer;

    // �J�����̔�
    [SerializeField] private Operation DoorOperation;

    private Coroutine SelectCoroutine = null;

    private Image SelectImage = null;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;

        var count = 4;

        SelectCardName.Clear();
        for (int i = 0; i < count; i++)
        {
            SelectCardName.Add(default);
        }
    }
    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void SetImage(Image selectImage)
    {
        SelectImage = selectImage;
    }

    public void SetCard(int CardPositionIndex)
    {
        if (SelectCoroutine != null)
        {
            StopCoroutine(SelectCoroutine);
            SelectCoroutine = null;
        }
        SelectCoroutine = StartCoroutine(SelectCard(CardPositionIndex));
    }
    public IEnumerator SelectCard(int CardPositionIndex)
    {
        // �A�C�e�����I����Ԃɂ���
        GameMaster.Instance.IsSelectItem = false;

        GameMaster.Instance.Moderate("�J�[�h��I�����Ă��������I");
        // �N���b�N�����܂őҋ@
        while (!Input.GetMouseButtonDown(0)) { yield return null; }

        // �����J��
        CurrentPlayer.MyBag.CallInventory();
        Cursor.lockState = CursorLockMode.None;

        // �A�C�e�����I�������܂őҋ@�B
        while (!GameMaster.Instance.IsSelectItem) { yield return null; }

        GameMaster.Instance.IsSelectItem = false;

        // �I�����ꂽ�A�C�e�����擾
        var selectItem = GameMaster.Instance.SelectItem;

        if (selectItem.Type != "�J�[�h")
        {
            GameMaster.Instance.Moderate("�J�[�h��I�����Ă��������I");
            CurrentPlayer.MyBag.CallInventory();
            yield break;
        }

        // ���Ɏg�p����Ă���Ƃ��ēx�I��ҋ@
        foreach (var item in SelectCardName)
        {
            if (item == selectItem.Name)
            {
                GameMaster.Instance.Moderate("���łɎg�p����Ă��܂��I");
                CurrentPlayer.MyBag.CallInventory();
                yield break;
            }
        }
        // �������
        CurrentPlayer.MyBag.CallInventory();
        Cursor.lockState = CursorLockMode.None;

        // �A�C�e���̖��O��ݒ�
        SelectCardName[CardPositionIndex] = selectItem.Name;

        // �A�C�e���̌����ڂ�ݒ�
        SelectImage.sprite = selectItem.ItemImage;

        // �M�~�b�N�ʉ߃`�F�b�N
        var passCount = 0;

        // ���������Ƃ��ʉ߃J�E���g���v���X1
        foreach (var item in GimmickPassCardName)
        {
            if (SelectCardName.Contains(item))
            {
                ++passCount;
                Debug.Log("�ʉ߁I" + passCount);
            }
        }

        // 4���Ƃ����ׂĂ�����Ă���Ƃ�
        if (passCount >= 4)
        {
            var bag = GameObject.Find("Bag").GetComponent<Bag>();
            foreach (var item in bag.Content)
            {
                if ("�J�[�h" == item.Type)
                {
                    bag.Content.Remove(item);
                }
            }
            DoorOperation.isOperation = true;
            yield return null;
            while (!Input.GetMouseButtonDown(0)) { yield return null; }
            GameMaster.Instance.Moderate("�ǂ����Ō��̊J�������������I");
            // �N���b�N�����܂őҋ@
            while (!Input.GetMouseButtonDown(0)) { yield return null; }
        }
    }

}