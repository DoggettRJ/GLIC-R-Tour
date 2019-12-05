using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour
{
    public GameObject ThrowingCube;
    public Animator RemoveTarget;
    public GameObject TeleportVideo;


    public GameObject Hit;

    private void OnTriggerEnter(Collider other)
    {
       // Vector3 point = other.contacts[0].point;
        //ThrowingCube.SetActive(false);
        RemoveTarget.Play("TargetInverse");
        Hit.SetActive(true);
        TeleportVideo.SetActive(true);
        ThrowingCube.SetActive(false);
    }

    private static void PlaceRedSphereAtPoint(Vector3 point)
    {
        Transform sphereTransform = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
        sphereTransform.position = point;
        sphereTransform.localScale = Vector3.one * 0.1f;
        sphereTransform.GetComponent<Renderer>().material.color = Color.red;
    }
}
