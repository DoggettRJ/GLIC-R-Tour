using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UICollaspeEvent : MonoBehaviour {

    public GameObject CollapseButton;

    public float _shootWaitTime = 0.01f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(replayContinue());
    }

    void Update()
    {

    }

    IEnumerator replayContinue()
    {
        yield return new WaitForSeconds(_shootWaitTime);
        CollapseButton.SetActive(false);
    }


}

