using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receptionCamOrigin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Respawn").transform.position = new Vector3(2.384987f, 0f, 3.439f);
        Camera.main.transform.Rotate(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
