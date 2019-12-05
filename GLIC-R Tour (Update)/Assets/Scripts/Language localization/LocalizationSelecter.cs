using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationSelecter : MonoBehaviour {

    [Tooltip("The dropdown box to populate with flags")]
    public Dropdown dropdown;

    [Tooltip("The flags of the languages our app supports")]
    public Sprite[] flags;

    private void Start()
    {

        dropdown.ClearOptions();

        List<Dropdown.OptionData> flagItems = new List<Dropdown.OptionData>();

        foreach (var flag in flags)
        {
            string flagName = flag.name;
            int dot = flag.name.IndexOf('.');
            if (dot >= 0)
            {
                flagName = flagName.Substring(dot + 1);
            }

            var flagOption = new Dropdown.OptionData(flag.name, flag);
            flagItems.Add(flagOption);
        }
        dropdown.AddOptions(flagItems);
    }

    void Update()
    {
        if (dropdown.value == 0)
        {
            Debug.Log("English");
        }

        if (dropdown.value == 1)
        {
            Debug.Log("German");
        }

        if (dropdown.value == 2)
        {
            Debug.Log("French");
        }

        if (dropdown.value == 3)
        {
            Debug.Log("Spanish");
        }
    }

}
