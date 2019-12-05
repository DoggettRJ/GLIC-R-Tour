using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
public class LevelSwitch : MonoBehaviour {

 
    private string[] levelNames = new string[] { "reception", "HSFLightTest", "RP-InteractionRoom", "VISRoom", "ShaveTestRoom", "SceneSwap" };

    static LevelSwitch s = null;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SteamVR_LoadLevel.Begin("reception");
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }


    public void receptionSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("reception");
      
    }

    public void HSFLightTestSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("HSFLightTest");

    }

    public void RPSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("RP-InteractionRoom");

    }

    public void visSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("VISRoom");

    }

    public void ShaveTestRoomSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("ShaveTestRoom");

    }

    public void SceneSwapSceneLoader(int SceneIndex)
    {
        SteamVR_LoadLevel.Begin("SceneSwap");

    }

}
