using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OpenUI : MonoBehaviour
{

    public GameObject OpenButton;

    public float Appear = 0.01f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Open());
    }

    void Update()
    {

    }

    IEnumerator Open()
    {
        yield return new WaitForSeconds(Appear);
        OpenButton.SetActive(true);
    }


}