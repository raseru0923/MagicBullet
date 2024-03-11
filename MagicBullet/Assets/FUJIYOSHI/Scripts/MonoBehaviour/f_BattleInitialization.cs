using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Linq;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class f_BattleInitialization : MonoBehaviour
{
    [SerializeField] private GameObject BattleDisplay;
    // Start is called before the first frame update
    void OnEnable()
    {
        GameMaster.Instance.BattleObject = this.gameObject;
        BattleDisplay.GetComponent<f_ImageAnimation>().StartAniamtion();
    }

    private void Start()
    {
        GameMaster.Instance.BattleObject = this.gameObject;
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Playground")
        {
            GameMaster.Instance.BattleObject.SetActive(false);
        }
    }
}
