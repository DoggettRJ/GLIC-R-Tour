using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Dropdown>().captionText.text = "LANGUAGES";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
