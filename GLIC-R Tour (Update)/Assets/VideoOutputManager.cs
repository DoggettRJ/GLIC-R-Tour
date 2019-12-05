using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

using Valve.VR;
using Valve.VR.InteractionSystem;

public class VideoOutputManager : MonoBehaviour
{

    ///  space bar colour
    public GameObject spaceBarButton;
    public Material spaceBarMaterial;
    Renderer rend;
    Color colorStart = Color.red;
    Color colorEnd = Color.green;

    // Arrow functionality

    public GameObject CameraArrow;
    public GameObject RobotButtonArrow;
   // public GameObject SpacebarArrow;
    public GameObject LightArrow;
    public GameObject ResetArrow;
    public GameObject BeginEXP;

    public GameObject CameraDummy;
    public GameObject RobotButtonDummy;
    public GameObject LightControllerDummy;

    // Button Dummies 
    public GameObject LightLowDummy;
    public GameObject LightMedDummy;
    public GameObject LightHighDummy;

    //Camera Dummies
    public GameObject RecordingDummy;
    public GameObject NotRecordingDummy;

    //FPS Buttons
    public GameObject lowFPSDummy;
    public GameObject medFPSDummy;
    public GameObject highFPSDummy;




    // Ouputs
    public GameObject TooDark60FPS;

    public GameObject Perfect60FPS;

    public GameObject OverExpo60FPS;



    public GameObject TooDark1000FPS;

    public GameObject PerfectDark1000FPS;


    public GameObject All5000FPS;

    // Holo Animations

    public Animator HoloExpAnimator;

    public GameObject ActivateHoloPad;

    public GameObject notRecording;

    //arrows

    public GameObject selectCamArrow;


    // Start is called before the first frame update
    void Start()
    {
       // rend.material.DisableKeyword("_EMISSION");
    }

    public void enableRobotButton()
    {
        if (!BeginEXP.activeInHierarchy) {
          
            LightArrow.SetActive(true);
            CameraDummy.SetActive(true);
            RecordingDummy.SetActive(true);
            selectCamArrow.SetActive(false);
        }
    }


    private void H1L0Output()
    {
        if (LightLowDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            TooDark60FPS.SetActive(true);
        }

        else
        {
            TooDark60FPS.SetActive(false);
        }        
    }

    private void H1L1Output()
    {
        if (LightMedDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            Perfect60FPS.SetActive(true);
        }

        else
        {
            Perfect60FPS.SetActive(false);
        }
    }

    private void H1L2Output()
    {
        if (LightHighDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            OverExpo60FPS.SetActive(true);
        }

        else
        {
            OverExpo60FPS.SetActive(false);
        }
    }



    private void H2L0Output()
    {
       

        if (LightLowDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy || LightMedDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            TooDark1000FPS.SetActive(true);
        }

        else
        {
            TooDark1000FPS.SetActive(false);
        }
    }

 
    private void H2L2Output()
    {
        if (LightHighDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            PerfectDark1000FPS.SetActive(true);
        }

        else
        {
            PerfectDark1000FPS.SetActive(false);
        }
    }

    private void H3All1Output()
    {
        if (LightLowDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy || LightMedDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy || LightHighDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy)
        {
            All5000FPS.SetActive(true);
        }

        else
        {
            All5000FPS.SetActive(false);
        }
    }

    private void notREcording()
    {
        if (!RecordingDummy.activeInHierarchy)
        {
            notRecording.SetActive(true);
        }

        else
        {
            notRecording.SetActive(false);
        }
    }

    //----------------------------------------------------------------------------------------------------------
    //HoloPad Functions

    private void H1L0HoloPad()
    {
        if (LightLowDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {

            HoloExpAnimator.Play("H1L0Start");
        }
    }

    private void H1L1HoloPad()
    {
        if (LightMedDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {

            HoloExpAnimator.Play("H1L1Start");
        }
    }

    private void H1L2HoloPad()
    {
        if (LightHighDummy.activeInHierarchy & lowFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {
            HoloExpAnimator.Play("H1L2Start");
        }

    }

    private void H2L0HoloPad()
    {


        if (LightLowDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy || LightMedDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {
            HoloExpAnimator.Play("H2L0Start");
        }

    }

    private void H2L2HoloPad()
    {
        if (LightHighDummy.activeInHierarchy & medFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {
            HoloExpAnimator.Play("H2L2Start");
        }

    }


    private void H3AllHoloPad()
    {
        if (LightLowDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy || LightMedDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy || LightHighDummy.activeInHierarchy & highFPSDummy.activeInHierarchy & RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {
            HoloExpAnimator.Play("H3AllStart");
        }
    }

    private void notREcordingHoloPad()
    {
        if (!RecordingDummy.activeInHierarchy & ActivateHoloPad.activeInHierarchy)
        {
            HoloExpAnimator.Play("NotRecStart");
        }

    }

    //-----------------------------------------------------------------------------------------------------------

    private void Update()
    {
        if (RobotButtonDummy.activeInHierarchy & LightControllerDummy.activeInHierarchy & RobotButtonDummy.activeInHierarchy)
        {
            rend = spaceBarButton.GetComponent<Renderer>();
            rend.material.SetColor("_Color", Color.red);
            rend.material.SetColor("_EmissionColor", Color.red);
            spaceBarMaterial.EnableKeyword("_EMISSION");
            rend.material.EnableKeyword("_EMISSION");
            //SpacebarArrow.SetActive(true);
        }

        H1L0Output();
        H1L1Output();
        H1L2Output();
        H2L0Output();
        H2L2Output();
        H3All1Output();


        H1L0HoloPad();
        H1L1HoloPad();
        H1L2HoloPad();
        H2L0HoloPad();
        H2L2HoloPad();
        H3AllHoloPad();
        notREcording();
        notREcordingHoloPad();
    }


   
    

    //-------------------------------------------------
    protected virtual void Awake()
    {
        //interactable = GetComponent<Interactable>();
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverBegin(Hand hand)
    {
        // Debug.Log($"OnHandHoverBegin(Hand hand): { gameObject.name }");
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverEnd(Hand hand)
    {
        // Debug.Log($"OnHandHoverEnd(Hand hand): { gameObject.name }");
        hand.HideGrabHint();
    }


    //-------------------------------------------------
    protected virtual void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();

        if (startingGrabType != GrabTypes.None)
        {
            if (startingGrabType == GrabTypes.Pinch)
            {

             
            }

            switch (startingGrabType)
            {
                case GrabTypes.Pinch:
                    // do pinch stuff
                    break;
                case GrabTypes.Trigger:
                    // do trigger stuff
                    break;
                default:
                  // AREA FOR CLICK !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    break;
            }


            hand.HideGrabHint();
        }
    }
}
