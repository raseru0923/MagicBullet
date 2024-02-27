using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class f_ImageAnimation : MonoBehaviour
{
    [SerializeField] private float AnimationSpeed = 1;

    public void StartAniamtion(float animationSpeed)
    {
        StartCoroutine(ZeroToOneAnimation(animationSpeed));
    }
    public void StartAniamtion()
    {
        StartCoroutine(ZeroToOneAnimation(AnimationSpeed));
    }

    public void EndAnimation(float animationSpeed)
    {
        StartCoroutine(OneToZeroAnimation(animationSpeed));
    }
    public void EndAnimation()
    {
        StartCoroutine(OneToZeroAnimation(AnimationSpeed));
    }

    IEnumerator ZeroToOneAnimation(float animationSpeed)
    {
        Image myImage = this.GetComponent<Image>();

        myImage.fillAmount = 0;

        while (myImage.fillAmount < 1)
        {
            myImage.fillAmount += animationSpeed * Time.deltaTime;
            yield return null;
        }
        Debug.Log("終了！");
    }

    IEnumerator OneToZeroAnimation(float animationSpeed)
    {
        Image myImage = this.GetComponent<Image>();

        myImage.fillAmount = 1;

        while (myImage.fillAmount > 0)
        {
            myImage.fillAmount += animationSpeed * Time.deltaTime;
            yield return null;
        }
        Debug.Log("終了！");
    }
}
