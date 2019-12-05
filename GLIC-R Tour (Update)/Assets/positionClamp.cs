using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionClamp : MonoBehaviour
{
    public float minZ = -0.4f, maxZ = 0.4f;


    void Update()
    {
        // get the position to a variable
        Vector3 currentPosition = transform.position;
        // modify the variable to keep y within minY to maxY
        currentPosition.y =
           Mathf.Clamp(currentPosition.z, minZ, maxZ);
        // and now set the transform position to our modified vector
        transform.position = currentPosition;
    }
}
