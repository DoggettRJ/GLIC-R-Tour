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
public class motionControllerLeft : MonoBehaviour
{
    [SerializeField]
    //private GameObject doink;

    [HideInInspector]
    public Interactable interactable;
    public float speed;
    public GameObject slider;

   


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

            slider.transform.Translate(0, 0, speed * Time.deltaTime);
     
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

