using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visCamOrigin : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Respawn").transform.position = new Vector3(4.11f, 0f, -2.449f);
        Camera.main.transform.Rotate(0f, 90f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
