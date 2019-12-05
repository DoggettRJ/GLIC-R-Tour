using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelFunctionalityManager : MonoBehaviour
{
    public GameObject wheelRotation;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        wheelRotation.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
