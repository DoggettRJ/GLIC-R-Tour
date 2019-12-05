using UnityEngine;
// using UnityEngine.UI;

using TMPro;
using System;

public class LocalizedTextMeshPro : MonoBehaviour 
{

    public string key;

	// Use this for initialization
	void Start () 
    {
        //TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        //text.text = LocalizationManager.instance.GetLocalizedValue(key);

        try
        {
            GetComponent<TextMeshProUGUI>().text = LocalizationManager.instance.GetLocalizedValue(key);
        }
        catch (NullReferenceException ex)
        {
            Debug.LogWarning(ex.Message);
        }
    }
}
