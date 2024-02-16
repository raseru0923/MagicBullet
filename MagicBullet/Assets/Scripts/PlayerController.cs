using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SetButtonActions;

public class PlayerController : MonoBehaviour
{
    private GameObject plobj;
    private float deg = 0;
    // Start is called before the first frame update
    void Start()
    {
        plobj = this.gameObject;
        CallButton.Instance.SetActionWithTag("Save", Hello, E_BUTTONCALLBACKS.E_LONG);
    }

    // Update is called once per frame
    void Update()
    {
        deg += 1 * Time.deltaTime * 120;
        plobj.transform.position = new Vector3(Mathf.Cos(deg / 180 * Mathf.PI), Mathf.Sin(deg / 180 * Mathf.PI), 0);
    }

    private void Hello()
    {
        Debug.Log("Hello!");
    }
}
