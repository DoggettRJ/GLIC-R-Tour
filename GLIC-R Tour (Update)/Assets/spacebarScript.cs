using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.Video;
using UnityEngine.UI;

public class spacebarScript : MonoBehaviour
{
    public GameObject Keyboard;
    public GameObject spacebar;
    public GameObject Trigger; 
    public Material material;
    Renderer rend;
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    // public Animator anim;

    public VideoPlayer outputVideoOption;

    // Use this for initialization
    void Start()
    {
       rend =  spacebar.GetComponent<Renderer>();
        // anim = Keyboard.GetComponent<Animator>();
        outputVideoOption = GetComponent<VideoPlayer>();
    }

    public void Update()
    {
        // when the trigger is pressed down.
        //if (SteamVR_Input._default.inActions.GrabPinch.GetLastStateDown(SteamVR_Input_Sources.Any))
        //SteamVR_Input._default.GripGrab
        //if (SteamVR_Input._default.GripGrab.GetLastStateDown(SteamVR_Input_Sources.Any))
        // SteamVR_Behaviour_Boolean
       // SteamVR_Behaviour_Boolean.
        {

            // anim.Play("spaceBar");

            if (!Trigger.activeInHierarchy)
            {
                Trigger.SetActive(true);
                material.EnableKeyword("_EMISSION");
                rend.material.SetColor("_Color", Color.red);
                rend.material.SetColor("_EmissionColor", Color.red);
                outputVideoOption.Play();
            }
            else
            {
                if (Trigger.activeInHierarchy)
                {
                    Trigger.SetActive(false);
                    material.DisableKeyword("_EMISSION");
                    rend.material.SetColor("_Color", Color.green);
                    rend.material.SetColor("_EmissionColor", Color.green);
                    outputVideoOption.Play();
                }
            }


        }
    }
}