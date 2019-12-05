using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomePanelExpHolo : MonoBehaviour {


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
            WelcomeExpHoloPad.Play("EXPShaveStart");

            ColliderBox.GetComponent<Collider>().enabled = false;
        }
    }
}
