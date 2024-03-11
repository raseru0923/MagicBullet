using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    // 自身のバッグ
    public Bag MyBag;

    // Update is called once per frame
    private bool canDoorOperation;
    public List<Animator> Animators = new List<Animator>();

    [SerializeField] private GameObject Guide;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // 鞄を開く
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            GameMaster.Instance.IsSelectItem = false;
            MyBag.CallInventory();
        }

        // ドアの開閉処理はじめ
        if (Animators == null)
        {
            return;
        }

        if (canDoorOperation && Input.GetKeyDown(KeyCode.F))
        {
            var animator = PassAnimator(Animators, animator => animator.GetComponent<Operation>() != null);

            if (animator != null && !animator.GetComponent<Operation>().IsOperation)
            {
                GameMaster.Instance.Moderate("扉は固く閉ざされている");
                return;
            }

            animator = PassAnimator(Animators, animator => animator.GetComponent<ToBattleDoor>() != null);

            // バトル遷移可能な時
            if (animator != null)
            {
                if (GameMaster.Instance.canFinalBattle) { ToBattleScene(); return; }
                GameMaster.Instance.Moderate("扉は固く閉ざされている");
                return;
            }
            foreach (var item in Animators)
            {
                if (!item.GetBool("IsOpen"))
                {
                    item.SetBool("IsOpen", true);
                }
                else
                {
                    item.SetBool("IsOpen", false);
                }
            }
        }
        // ドアの開閉処理終わり
    }

    // 条件に一致したアニメーターを返却
    private Animator PassAnimator(List<Animator> targetAnimators, Func<Animator, bool> terms)
    {
        foreach (var item in targetAnimators)
        {
            if (terms(item)) { return item; }
        }
        return null;
    }

    private void ToBattleScene()
    {
        if (!GameMaster.Instance.isFinalBattle)
        {
            Guide.SetActive(true);

            GameMaster.Instance.isFinalBattle = true;
            return;
        }
        // ここでバトルシーンに遷移
        var animator = PassAnimator(Animators, animator => animator.GetComponent<ToBattleDoor>() != null);
        if (animator != null) { animator.GetComponent<ToBattleDoor>().ToBattleScene(); }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("DoorEnter!");

            var otherAnimator = other.GetComponent<Animator>();

            // ドアのアニメーターを取得
            if (!Animators.Contains(otherAnimator))
            {
                Animators.Add(otherAnimator);
                canDoorOperation = true;
            }
        }
    }
}
