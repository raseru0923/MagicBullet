using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f_Enemy : MonoBehaviour
{
    private void Start()
    {
        f_ImageAnimation imageAnimation = this.GetComponent<f_ImageAnimation>();
        imageAnimation.StartAniamtion();
    }

    // “G‚Ìƒ^[ƒ“‚Ìˆ—
    public IEnumerator EnemyTurn()
    {
        yield return StartCoroutine(f_BattleLabel.Instance.PrintLabel(2));
    }
}
