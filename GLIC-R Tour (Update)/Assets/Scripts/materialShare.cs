using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialShare : MonoBehaviour
{
    public GameObject handle;

    public GameObject trimmerGuard;

    public GameObject housing;

    public GameObject frontElasomter;

    public GameObject backPlastic;

    public Material handleMaterial;
    public Material trimmerGuardMaterial;
    public Material housingMaterial;
    public Material frontElasomterMaterial;
    public Material backPlasticMaterial;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (handle.activeInHierarchy == true)
        {
            GetComponent<Renderer>().material = handleMaterial;
        }

        if (trimmerGuard.activeInHierarchy == true)
        {
            GetComponent<Renderer>().material = trimmerGuardMaterial;
        }

        if (housing.activeInHierarchy == true)
        {
            GetComponent<Renderer>().material = housingMaterial;
        }

        if (frontElasomter.activeInHierarchy == true)
        {
            GetComponent<Renderer>().material = frontElasomterMaterial;
        }

        if (backPlastic.activeInHierarchy == true)
        {
            GetComponent<Renderer>().material = backPlasticMaterial;
        }
    }
}
