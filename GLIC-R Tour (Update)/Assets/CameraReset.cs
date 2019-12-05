using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour {

   // public GameObject cameraTarget;
    public Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position; // talkig about the Gameobject the script is on 
    }

    public void resetCamera()
    {
        transform.position = startPosition;
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
    }
}
