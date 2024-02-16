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
    // マップ配列
    private int[,] map;
    private float deg = 0;
    // マップの生成の仕方
    // 大き目のフィールドと道になるところが存在する。
    // 崖や水場で行き止まりになることはない
    // 敵が程よい間隔で設置されている
    // 絶対に次の階層への入り口に行くことができる。

    private void Start()
    {
        // ルームのサイズが奇数じゃないとバグが起きます。
        if (roomsize % 2 == 0)
        {
            map = new int[roomsize + 1, roomsize + 1];
        }
        else
        {
            map = new int[roomsize, roomsize];
        }

        // 縦の位置、横の位置を保存する変数
        int x, y;

        while (deg != 361)
        {
            // intの切り捨て変換を利用して円のふちの位置を特定
            x = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Cos(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            y = (int)((int)(Mathf.Sqrt(map.Length) / 2) * Mathf.Sin(deg / 180 * Mathf.PI) + (int)(Mathf.Sqrt(map.Length) / 2));
            // ふちのある場所に1(地面)判定を付けます。
            map[x, y] = 1;
            ++deg;
        }

        deg = 0;

        // これはふち同士の間を走査して埋めるプログラムです。
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

        // ふちを削ってナチュラルに
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
            // 変数で作ったマップを実際に作成します。
            MapOutput();
        }
    }

    // ちなみに初期型は1つを1ブロックで埋めているため大変重いです。
    private void MapOutput()
    {
        // 一番左上を座標0,0とする
        // 一つの要素は1,1の大きさ
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

    // 行ごとに変数の内容を表示します。
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
