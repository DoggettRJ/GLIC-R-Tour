using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    public Transform PlayerPos;
    public Transform RefObject;

    void Awake()
    {

        PlayerPos.position = RefObject.position;
        PlayerPos.transform.eulerAngles = RefObject.transform.eulerAngles;
    }
        //transform.parent.localPosition = -transform.localPosition;
    }

