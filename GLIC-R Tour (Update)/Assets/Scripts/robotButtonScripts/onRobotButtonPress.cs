using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class onRobotButtonPress : MonoBehaviour
{
    public GameObject Robot;
    public GameObject Button;
    public GameObject Green;
    public GameObject Red;
    private Animator buttonAnim;
    private Animator robotAnim;
    // Use this for initialization

    void Start()
    {
        buttonAnim = Button.GetComponent<Animator>();
        robotAnim = Robot.GetComponent<Animator>();
    }


    public void Update()
    {

       /* if (SteamVR_Input._default.inActions.GrabPinch.GetLastStateDown(SteamVR_Input_Sources.Any))
        {
            if (Red.activeInHierarchy)
            {

                Red.SetActive(false);
                Green.SetActive(true);
                buttonAnim.Play("robotButtonPress");
                robotAnim.Play("mugGrab");
                
            }

            else
            {
                Red.SetActive(true);
                Green.SetActive(false);
                buttonAnim.Play("robotButtonPress");
                robotAnim.Play("cancelRobot");
            }
        }*/
    }
}
