using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReceptionDestroyOnSceneChange1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Main Menu")
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
