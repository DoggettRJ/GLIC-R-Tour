using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LocalizedText : MonoBehaviour {

    public string key;

	// Use this for initialization
	void Start () 
    {
        try
        {
            Text text = GetComponent<Text>();
            text.text = LocalizationManager.instance.GetLocalizedValue(key);
        }
        catch (NullReferenceException ex)
        {
            Debug.LogWarning(ex.Message);
        }
	}
}
