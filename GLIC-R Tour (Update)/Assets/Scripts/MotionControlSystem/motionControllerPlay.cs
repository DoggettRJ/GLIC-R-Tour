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
public class motionControllerPlay : MonoBehaviour
{
    [SerializeField]
    //private GameObject doink;

    [HideInInspector]
    public Interactable interactable;
    public float speed;
    public GameObject slider;

    public Transform[] origPos;
    Transform currentView;

    public Animator motionAnim;

    void Start()
    {


    }

    void LateUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * speed);
    }

    //-------------------------------------------------
    protected virtual void Awake()
    {
        interactable = GetComponent<Interactable>();
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverBegin(Hand hand)
    {
        motionAnim.Play("motionControl"); 
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

