using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(0, speed, 0);

     
    }
}
