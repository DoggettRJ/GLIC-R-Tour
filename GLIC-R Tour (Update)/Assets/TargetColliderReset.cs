using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderReset : MonoBehaviour
{
    public GameObject ThrowingCube;
    public Transform PosOrig;

    public GameObject Retry;
    GameObject go = null;

    void Start()
    {
        go = GameObject.FindWithTag("ThrowingCubeTag");
    }

    IEnumerator Example()
    {
        //Destroy(ThrowingCube);
        Retry.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Instantiate(ThrowingCube, PosOrig.position , Quaternion.identity);
        Retry.SetActive(false);
        go.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube" || other.gameObject.name == "Cube(Clone)")
        {            
            StartCoroutine(Example());         
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
