using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeTrigger : MonoBehaviour
{

    public GameObject holoPad;
    private Animator welcomeAnim;
    public Collider playerCollider;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        welcomeAnim = holoPad.GetComponent<Animator>();
    }

  
    void OnTriggerEnter(Collider other)
    {
        welcomeAnim.Play("Start");
        Debug.Log("Working ?");
    }
}
