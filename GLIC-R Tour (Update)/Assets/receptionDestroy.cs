using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class receptionDestroy : MonoBehaviour
{
    void Update()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "reception") 
        {
            // Destroy the gameobject this script is attached to
            // Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
