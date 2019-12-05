using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecOnClickFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject recTimer;
    [SerializeField]
    private GameObject recIndicator;

    private Animator recAnim;
    private bool cameraHasBeenActivated;

    public GameObject RecordingDummy;
    public GameObject NotRecordingDummy;
    public GameObject BeginEXP;

    public GameObject rubRobot;
    public GameObject BeginEXPDummy;

    public GameObject RecCOllider;



    public bool CameraActivated
    {
        get
        {
            return cameraHasBeenActivated;
        }
    }

    // Remember ! All you have to do is create a custom function and assign it to the event. Then select the function in the drop down.

    void Start()
    {
        recAnim = GetComponent<Animator>();
        cameraHasBeenActivated = false;
    }

    public void onRecClick()
    {
        if (BeginEXP.activeInHierarchy)
        {

        }

        else if (!rubRobot.activeInHierarchy)
        {
            recTimer.SetActive(true);
            recIndicator.SetActive(true);
            recAnim.Play("RecButton");
            cameraHasBeenActivated = true;
            RecordingDummy.SetActive(true);
            NotRecordingDummy.SetActive(false);
            RecCOllider.SetActive(false);
        }
        else if(recIndicator.activeInHierarchy || BeginEXPDummy.activeInHierarchy)
        {
            recTimer.SetActive(false);
            recIndicator.SetActive(false);
            recAnim.Play("RecButton");
            cameraHasBeenActivated = false;
            RecordingDummy.SetActive(false);
            NotRecordingDummy.SetActive(false);
        }

    }
 }
