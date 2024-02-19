using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageAnimation : MonoBehaviour
{
    [SerializeField] private float AnimationSpeed;

    private void Start()
    {
        StartAniamtion(AnimationSpeed);
    }

    public void StartAniamtion(float animationSpeed)
    {
        StartCoroutine(ZeroToOneAnimation(animationSpeed));
    }

    public void EndAnimation(float animationSpeed)
    {
        StartCoroutine(OneToZeroAnimation(animationSpeed));
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
        Debug.Log("�I���I");
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
        Debug.Log("�I���I");
    }
}
