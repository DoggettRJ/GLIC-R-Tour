using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Valve.VR;
using Valve.VR.InteractionSystem;

//-------------------------------------------------------------------------
[RequireComponent(typeof(Interactable))]
// [RequireComponent(typeof(Rigidbody))]

public class resetVisVideo : MonoBehaviour
{

    public Animator buttonAnim;
    public GameObject Video;
    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

                buttonAnim.Play("robotButtonPress");
               // Video.SetActive(false);
                videoPlayer.Stop();
                videoPlayer.Play();

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
        // Instantiate(doink, new Vector3(0.0f, 3.0f, 0.0f), Quaternion.identity);
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


