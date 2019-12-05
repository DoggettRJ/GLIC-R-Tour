using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderBeginGame : MonoBehaviour
{
    public GameObject ClickToBegin;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BodyCollider")
        {           
            ClickToBegin.SetActive(true);        
        }
        
    }
}
