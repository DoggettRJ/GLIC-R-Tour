using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour {

	// Use this for initialization.
	private IEnumerator Start ()
    {
       
        while (!LocalizationManager.instance.GetIsReady())
        {
            // wait one frame.
            yield return null;
        }
        // Load scene by name.
        SceneManager.LoadScene("Region Scene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
