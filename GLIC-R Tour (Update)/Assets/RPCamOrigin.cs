using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPCamOrigin : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Respawn").transform.position = new Vector3(-12.238f, 0f, -12.301f);
        Camera.main.transform.Rotate(0f, 0f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
