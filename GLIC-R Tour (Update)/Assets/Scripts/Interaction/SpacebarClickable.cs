using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable))]
public class SpacebarClickable : MonoBehaviour
{
    
    [HideInInspector]
    public Interactable interactable;

    public GameObject videoCanvas;
    public Material spacebar;

    public GameObject Play;
    public GameObject Reset;
    public GameObject SpaceBarArrow;
    public GameObject LightArrow;
    public GameObject ActivateHoloPad;
    public Material robotButtonMaterial;

    //Arrows
    public GameObject robotArrow;
    public GameObject rubRobot;
    public GameObject BeginEXP;

    //Rec

    [SerializeField]
    private GameObject recTimer;
    [SerializeField]

    private GameObject recIndicator;

    private Animator recAnim;


    public GameObject RecordingDummy;
    public GameObject NotRecordingDummy;

    //Animation

   
    public Animator robotAnim;

    public GameObject Red;

    //-------------------------------------------------
    protected virtual void Awake()
    {
        interactable = GetComponent<Interactable>();
    }

    //-------------------------------------------------

    private void Start()
    {
        spacebar.DisableKeyword("_EMISSION");
        robotButtonMaterial = GetComponent<Renderer>().material;
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

                if (robotArrow.activeInHierarchy)
                {
                    rubRobot.SetActive(true);
                }

                else if (!BeginEXP.activeInHierarchy)
                {

                    if (!videoCanvas.activeInHierarchy)
                    {
                        videoCanvas.SetActive(true);
                        Play.SetActive(false);
                        Reset.SetActive(true);
                        ActivateHoloPad.SetActive(true);
                        robotAnim.Play("EntryState");
                        robotButtonMaterial.color = Color.red;
                        Red.SetActive(true);
                   
                    }

                    else
                    {
                        videoCanvas.SetActive(false);
                        Reset.SetActive(false);
                        Play.SetActive(true);
                        SpaceBarArrow.SetActive(false);
                        LightArrow.SetActive(true);
                        


                        recTimer.SetActive(false);
                        recIndicator.SetActive(false);
                        recAnim.Play("RecButtonReverse");
                        RecordingDummy.SetActive(false);
                        NotRecordingDummy.SetActive(false);

                        Red.SetActive(true);
                      
                    }
                }
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

                    videoCanvas.SetActive(true);
                    Debug.Log("Debug is teh workings now?");
                    break;
            }


            hand.HideGrabHint();
        }
    }


   

    //-------------------------------------------------
    protected virtual void OnHandFocusAcquired(Hand hand)
    {
        throw new NotImplementedException("protected virtual void OnHandFocusAcquired(Hand hand)");
        gameObject.SetActive(true);
    }


    //-------------------------------------------------
    protected virtual void OnHandFocusLost(Hand hand)
    {
        throw new NotImplementedException("protected virtual void OnHandFocusLost(Hand hand)");
        gameObject.SetActive(false);
    }

}
