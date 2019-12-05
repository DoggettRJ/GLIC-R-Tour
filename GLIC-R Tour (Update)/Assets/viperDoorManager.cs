using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable))]
// [RequireComponent(typeof(Rigidbody))]

public class viperDoorManager : MonoBehaviour
{

    public bool Closed = true;

    public GameObject ViperDoor;
    private Animator ViperDoorAnimator;

    [SerializeField]
    private GameObject doink;

    [HideInInspector]
    public Interactable interactable;

    public GameObject viperDoor;
    
    private Animator viperdDoorAnim;


    void Start()
    {
        viperdDoorAnim = viperDoor.GetComponent<Animator>();

    }

    //-------------------------------------------------
    protected virtual void Awake()
    {
        interactable = GetComponent<Interactable>();
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
                if (Closed)
                {
                    Debug.Log("Hit");
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
                    Debug.Log("Debug is teh workings now?");
                    break;
            }


            hand.HideGrabHint();
        }
    }

    private void CreateDoink()
    {
        Instantiate(doink, new Vector3(0.0f, 3.0f, 0.0f), Quaternion.identity);
    }

    //-------------------------------------------------
    protected virtual void OnHandFocusAcquired(Hand hand)
    {
        throw new System.NotImplementedException("protected virtual void OnHandFocusAcquired(Hand hand)");
        gameObject.SetActive(true);
    }


    //-------------------------------------------------
    protected virtual void OnHandFocusLost(Hand hand)
    {
        throw new System.NotImplementedException("protected virtual void OnHandFocusLost(Hand hand)");
        gameObject.SetActive(false);
    }
}
