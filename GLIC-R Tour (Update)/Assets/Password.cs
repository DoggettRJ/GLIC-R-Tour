using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{


    public string levelCode;
    public bool isBlank;
    public bool isWrongKey;

    void OnGUI()
    {

        levelCode = GUI.PasswordField(new Rect(163, 400, 150, 20), levelCode,"*"[0]);

        GUI.contentColor = Color.black;
        GUI.Label(new Rect(163, 375, 150, 20),"ENTER PASSWORD");

        if (GUI.Button(new Rect(163, 425, 150, 20), "OK"))
        {
            GetInput(levelCode);
        }

        if (isBlank)
        {
            GUI.Label(new Rect(163, 450, 150, 20), "Invalid Key!");
        }

        if (isWrongKey)
        {
            GUI.Label(new Rect(163, 450, 150, 20), "Wrong Key!");
        }
    }

    public void GetInput(string guess)
    {
        if ((guess == "gillette01"))
        {
            SceneManager.LoadScene(1);
            isBlank = false;
            isWrongKey = false;
            //Debug.Log("Load Select scene");
        }
        else if (guess == "")
        {
            isBlank = true;
            isWrongKey = false;
            Debug.Log("Invalid Key!");
            
        }

        else
        {
            isWrongKey = true;
            isBlank = false;
            Debug.Log("Wrong Key!");
        }
    }

}