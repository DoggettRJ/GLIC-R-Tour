using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneSwapCamOrig : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Respawn").transform.position = new Vector3(0f, 0f, 0f);
        Camera.main.transform.Rotate(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
