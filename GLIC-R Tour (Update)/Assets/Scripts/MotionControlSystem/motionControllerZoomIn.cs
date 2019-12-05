// From "Throwable : MonoBehaviour"

using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

using Valve.VR;
using Valve.VR.InteractionSystem;



//-------------------------------------------------------------------------
[RequireComponent(typeof(Interactable))]
// [RequireComponent(typeof(Rigidbody))]
public class motionControllerZoomIn : MonoBehaviour
{
    [SerializeField]
    //private GameObject doink;

    [HideInInspector]
    public Interactable interactable;
    public float speed;
    public float maxZoom = 5f;
    public Camera motionCam;

    public float maxFOVZoom = 10;
    void Start()
    {
      
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
    public virtual void HandHoverUpdate(Hand hand)
    {
        motionCam.fieldOfView = Mathf.Lerp(motionCam.fieldOfView, 10, Time.deltaTime);
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

