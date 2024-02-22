using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStageGenerator : MonoBehaviour
{
    [SerializeField] private GameObject GroundObj;
    [SerializeField] private GameObject HiGroundObj;
    private GameObject groundobj;
    [SerializeField] private int MaxRoomSize;
    [SerializeField] private int MinRoomSize;
    [SerializeField] private int MaxRoomDistance;
    [SerializeField] private int MinRoomDistance;
    [SerializeField] private int roomsize;
    // �}�b�v�z��
    private int[,] map;
    private float deg = 0;
    // �}�b�v�̐����̎d��
    // �傫�ڂ̃t�B�[���h�Ɠ��ɂȂ�Ƃ��낪���݂���B
    // �R�␅��ōs���~�܂�ɂȂ邱�Ƃ͂Ȃ�
    // �G�����悢�Ԋu�Őݒu����Ă���
    // ��΂Ɏ��̊K�w�ւ̓�����ɍs�����Ƃ��ł���B

    private void Start()
    {
        // ���[���̃T�C�Y�������Ȃ��ƃo�O���N���܂��B
        if (roomsize % 2 == 0)
        {
            map = new int[roomsize + 1, roomsize + 1];
        }
        else
        {
            map = new int[roomsize, roomsize];
        }

        // �c�̈ʒu�A���̈ʒu��ۑ�����ϐ�
        int x, y;

        while (deg != 361)
        {
            // int�̐؂�̂ĕϊ��𗘗p���ĉ~�̂ӂ��̈ʒu�����
            x = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Cos(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            y = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Sin(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            // �ӂ��̂���ꏊ��1(�n��)�����t���܂��B
            map[x, y] = 1;
            ++deg;
        }

        deg = 0;

        // ����͂ӂ����m�̊Ԃ𑖍����Ė��߂�v���O�����ł��B
        for (int i = 0; i < Mathf.Sqrt(map.Length); i++)
        {
            int cap = -1;
            for (int j = 0; j < Mathf.Sqrt(map.Length); j++)
            {
                if (map[i, j] == 1)
                {
                    if (cap != -1)
                    {
                        for (int k = cap; k < j; k++)
                        {
                            map[i, k] = Random.Range(1, 3);
                        }
                    }
                    cap = j;
                }
            }
        }

        // �ӂ�������ăi�`��������
        while (deg != 361)
        {
            x = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Cos(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            y = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Sin(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            map[x, y] = Random.Range(0, 2);
            ++deg;
        }

        deg = 0;
        while (deg != 361)
        {
            x = (int)((int)(Mathf.Sqrt(map.Length) / 2 - 1) * Mathf.Cos(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            y = (int)((int)(Mathf.Sqrt(map.Length) / 2 - 1) * Mathf.Sin(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            map[x, y] = Random.Range(0, 2);
            ++deg;
        }

        deg = 0;
        PrintArr2(map);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �ϐ��ō�����}�b�v�����ۂɍ쐬���܂��B
            MapOutput();
        }
    }

    // ���Ȃ݂ɏ����^��1��1�u���b�N�Ŗ��߂Ă��邽�ߑ�Ϗd���ł��B
    private void MapOutput()
    {
        // ��ԍ�������W0,0�Ƃ���
        // ��̗v�f��1,1�̑傫��
        for (int i = 0; i < Mathf.Sqrt(map.Length); i++)
        {
            for (int j = 0; j < Mathf.Sqrt(map.Length); j++)
            {
                if (map[i, j] == 1)
                {
                    groundobj = Instantiate(GroundObj);
                    groundobj.transform.position = new Vector3(i, 0, j);
                }
                else if (map[i, j] == 2)
                {
                    groundobj = Instantiate(HiGroundObj);
                    groundobj.transform.position = new Vector3(i, 0.5f, j);
                }
            }
        }
    }

    // �s���Ƃɕϐ��̓��e��\�����܂��B
    private void PrintArr2<T>(T[,] Arr2)
    {
        Debug.Log(Mathf.Sqrt(Arr2.Length));
        for (int i = 0; i < Mathf.Sqrt(Arr2.Length); i++)
        {
            string verticaltext = null;
            for (int j = 0; j < Mathf.Sqrt(Arr2.Length); j++)
            {
                verticaltext += Arr2[i, j] + ",";
            }
            Debug.Log(verticaltext);
        }
    }
}
