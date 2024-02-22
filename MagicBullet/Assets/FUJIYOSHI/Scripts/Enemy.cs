using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        ImageAnimation imageAnimation = this.GetComponent<ImageAnimation>();
        imageAnimation.StartAniamtion();
    }

    // �G�̃^�[���̏���
    public IEnumerator EnemyTurn()
    {
        yield return StartCoroutine(BattleLabel.Instance.PrintLabel(2));
    }
}
