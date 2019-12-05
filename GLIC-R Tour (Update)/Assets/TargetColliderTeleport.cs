using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderTeleport : MonoBehaviour
{
    public GameObject TeleportPointTwo;
    public GameObject TeleportPointOne;
    public GameObject TurnAround;
    public GameObject CanvasContainer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BodyCollider")
        {
            TeleportPointOne.SetActive(false);
            TeleportPointTwo.SetActive(true);
            TurnAround.SetActive(true);
            CanvasContainer.SetActive(false);
        }
        
    }
}
