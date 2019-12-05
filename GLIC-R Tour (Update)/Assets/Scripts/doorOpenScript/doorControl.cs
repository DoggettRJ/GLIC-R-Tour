using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class doorControl : MonoBehaviour
{
    
    public GameObject door;
    public GameObject dummy;
    private Animator doorAnim;

    // Use this for initialization

    public SteamVR_Action_Boolean grabPinchAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");

    void Start()
    {
        doorAnim = door.GetComponent<Animator>();
        
    }


   // public void Update()
    //{
  
      //  if (SteamVR_Input.GrabPinch.GetLastStateDown(SteamVR_Input_Sources.Any))


        //{
          //Debug.Log("Work ?");
           //if (dummy.activeInHierarchy)
         //{
           //   doorAnim.Play("doorOpen"); 
        //    }

        //    else
        //    {
               
        //    }
        //}
   // }
}
