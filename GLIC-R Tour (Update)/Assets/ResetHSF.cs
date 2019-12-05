using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHSF : MonoBehaviour
{

    [SerializeField]
    private GameObject recTimer;
    [SerializeField]
    private Animator recAnim;
    private bool cameraHasBeenActivated;
    public GameObject RecordingDummy;
    public GameObject NotRecordingDummy;
    public GameObject BeginEXP;
    public GameObject rubRobot;
    public GameObject BeginEXPDummy;
    public GameObject RecCOllider;
    public GameObject recIndicator;


    /// ///////////

 

    public Light spotLight;

    public Material bulbMaterial;

    public Material indicator1;
    public Material indicator2;
    public Material indicator3;

    public GameObject LightControlDummy;
    public GameObject LightArrow;
    public GameObject CameraArrow;

    // Button Dummies 
    public GameObject LightLowDummy;
    public GameObject LightMedDummy;
    public GameObject LightHighDummy;

    //Arrows
    public GameObject cameraArrow;
    public GameObject SelectYourCameraSettings;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetExperiment()
    {

        recTimer.SetActive(false);
        recIndicator.SetActive(false);
        recAnim.Play("RecButton");
        cameraHasBeenActivated = false;
        RecordingDummy.SetActive(false);
        NotRecordingDummy.SetActive(true);
        RecCOllider.SetActive(true);

        /////////////////////////////////

        spotLight.intensity = 0f;

        bulbMaterial.DisableKeyword("_EMISSION");
        indicator1.DisableKeyword("_EMISSION");
        indicator2.DisableKeyword("_EMISSION");
        indicator3.DisableKeyword("_EMISSION");
        LightControlDummy.SetActive(false);
        LightArrow.SetActive(false);
        LightLowDummy.SetActive(false);
        LightMedDummy.SetActive(false);
        LightHighDummy.SetActive(false);

    }

}
