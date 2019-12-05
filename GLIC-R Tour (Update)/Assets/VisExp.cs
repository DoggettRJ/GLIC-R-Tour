using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisExp : MonoBehaviour {


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
            Debug.Log("work !!!");
            WelcomeExpHoloPad.Play("VisEXPStart");

            ColliderBox.GetComponent<Collider>().enabled = false;
        }
    }
}
