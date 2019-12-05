using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderMiss : MonoBehaviour
{
    public GameObject ThrowingCube;
    public Animator RemoveTarget;
    public GameObject Miss;
    public GameObject TeleportVideo;
    public GameObject GrabInteraction;

    private void OnTriggerEnter(Collider other)
    {
        // Vector3 point = other.contacts[0].point;
        //ThrowingCube.SetActive(false);
        if (other.gameObject.name == "Cube")
        {
            RemoveTarget.Play("TargetInverse");
            
            Miss.SetActive(true);
            TeleportVideo.SetActive(true);
            GrabInteraction.SetActive(false);
        }

        else { }
    }

    private static void PlaceRedSphereAtPoint(Vector3 point)
    {
        Transform sphereTransform = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
        sphereTransform.position = point;
        sphereTransform.localScale = Vector3.one * 0.1f;
        sphereTransform.GetComponent<Renderer>().material.color = Color.red;
    }
}
