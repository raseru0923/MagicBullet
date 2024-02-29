using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_UseGameObjects : MonoBehaviour
{
    // ディーラーの設計図
    [SerializeField] private GameObject DealerPrefab;
    // ディーラーの情報を保存
    public f_Dealer dealer = null;

    public static f_UseGameObjects UseGameObjectsInstance;

    private void Awake()
    {
        if (UseGameObjectsInstance != null)
        {
            Destroy(this);
            return;
        }
        UseGameObjectsInstance = this;
        DontDestroyOnLoad(UseGameObjectsInstance);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SwitchNextScene()
    {
        yield return new WaitForSeconds(5);
    }
}
