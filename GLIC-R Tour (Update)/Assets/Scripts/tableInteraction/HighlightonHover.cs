// From "Throwable : MonoBehaviour"

using System;
using System.Collections;

using UnityEngine;
using UnityEngine.Events;

using Valve.VR;
using Valve.VR.InteractionSystem;

using TMPro;
using UnityEngine.UI;


//-------------------------------------------------------------------------
[RequireComponent(typeof(Interactable))]
// [RequireComponent(typeof(Rigidbody))]
public class HighlightonHover : MonoBehaviour
{
    [SerializeField]
    //private GameObject doink;

    [HideInInspector]
    public Interactable interactable;
 

    public TextMeshProUGUI textmeshPro;

  
    void Start()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
    }

    //-------------------------------------------------
    protected virtual void Awake()
    {
        interactable = GetComponent<Interactable>();
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverBegin(Hand hand)
    {
        textmeshPro.color = new Color32(255, 128, 0, 255);
        GetComponent<Image>().color = Color.red;
    }


    //-------------------------------------------------
    protected virtual void OnHandHoverEnd(Hand hand)
    {
     
        textmeshPro.color = new Color32(0, 0, 0, 255);
        GetComponent<Image>().color = Color.black;
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

