using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPassword : MonoBehaviour {

    string passwordToEdit = string.Empty;

  

    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(850, 510, 200, 20), "Password");

        passwordToEdit = GUI.PasswordField(new Rect(850, 530, 200, 20), passwordToEdit, "*"[0], 25);
    }


   void Update()
    {
        if (passwordToEdit == "password" && Input.GetKeyDown("enter"))

        {
            Debug.Log("log-in");
        } else
        
        {
            Debug.Log("incorrect password");
        }
    }

}
