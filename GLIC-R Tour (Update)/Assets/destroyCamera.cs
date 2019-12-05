using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCamera : MonoBehaviour
{

    public GameObject receptionRig;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(receptionRig);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
