using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeRPExpHolo : MonoBehaviour {


    private Collider playerCollider;
    public Animator WelcomeExpHoloPad;
    public GameObject ColliderBox;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "BodyCollider")
        {

            Debug.Log("Work!!!!!!!!!!");
   
            WelcomeExpHoloPad.Play("WelcomeRPEXPRoomStart");

            ColliderBox.GetComponent<Collider>().enabled = false;
        }
    }
}
