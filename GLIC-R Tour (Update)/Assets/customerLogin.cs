using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customerLogin : MonoBehaviour {

    string passwordToEdit = string.Empty;

    public GUIStyle style;

    void Start()
    {
     
    }

    private void OnGUI()
    {
        GUI.contentColor = Color.white;

        GUI.skin.textField = style;

        GUI.Label(new Rect(850, 510, 500, 500),"Password");
        passwordToEdit = GUI.PasswordField(new Rect(850, 530, 500, 50), passwordToEdit, "*"[0], 25);
    }


    void Update()
    {
        if (passwordToEdit == "password" && Input.GetKeyDown("enter"))

        {
            Debug.Log("log-in");
        }
    }
}
