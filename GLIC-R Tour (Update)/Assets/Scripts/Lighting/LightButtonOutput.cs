using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class LightButtonOutput : MonoBehaviour
{
    public GameObject Switch;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public  Animator anim;

    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;
    public Material material;

    void Start()
    {
        
        anim = Switch.GetComponent<Animator>();
        rend = Switch.GetComponent<Renderer>();
    }

    public void Update()
    {
        // when the trigger is pressed down.
      /*  if (SteamVR_Input._default.inActions.GrabPinch.GetLastStateDown(SteamVR_Input_Sources.Any))
        {
            if (!light1.activeInHierarchy)
            {
                light1.SetActive(true);
                light2.SetActive(true);
                light3.SetActive(true);
                anim.Play("Lights on");
                material.EnableKeyword("_EMISSION");
                rend.material.SetColor("_Color", Color.green);
                rend.material.SetColor("_EmissionColor", Color.green);
            }
            else
            {
                light1.SetActive(false);
                light2.SetActive(false);
                light3.SetActive(false);

                anim.Play("Lights off");
                rend.material.SetColor("_Color", Color.red);
                rend.material.SetColor("_EmissionColor", Color.red);
                material.DisableKeyword("_EMISSION");
            }
        }*/
    }
}


/*
using UnityEngine;
using UnityEngine.Events;

public class LightButtonOutput : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    public UnityEvent onHandHoverBegin;
    public Animation animButtonOn;
    Animator anim;

    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;




    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<Renderer>();
    }

    // Use this for initialization
    private void OnHandHoverBegin()
    {
        onHandHoverBegin.Invoke();

        if (!light1.activeInHierarchy)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            anim.Play("Lights on");

            rend.material.SetColor("_Color", Color.green);
            rend.material.SetColor("_EmissionColor", Color.green);
        }
        else
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);

            anim.Play("Lights off");
            rend.material.SetColor("_Color", Color.red);
            rend.material.SetColor("_EmissionColor", Color.red);
        }
    }
}

*/
