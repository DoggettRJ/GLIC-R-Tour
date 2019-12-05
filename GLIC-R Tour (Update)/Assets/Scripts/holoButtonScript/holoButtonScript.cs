using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holoButtonScript : MonoBehaviour {

    public GameObject Hologram;
    public Animation HoloGen;
    Animator anim;

    // Use this for initialization

    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    public void onHoloButtonPress () {


        if (!Hologram.activeInHierarchy)
        {
            anim.Play("Start");
        }
        else
        {
            anim.Play("End");
        }

    }
	
}
