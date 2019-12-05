using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaveTestCamOrig : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Respawn").transform.position = new Vector3(7.27f, 0f, -7.983f);
        Camera.main.transform.Rotate(0f, 26f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
