using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRectAnimation : MonoBehaviour
{

    bool isExpanded = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            isExpanded = !isExpanded;

        if (isExpanded)
        {
            //Do stuff...
        }
        else
        {
            //Do opposite stuff...
        }
    }
}
