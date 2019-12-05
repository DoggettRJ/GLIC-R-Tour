using UnityEngine;

using Valve.VR.InteractionSystem;


// delegate void Del(string str);
public delegate void LightUpdate(float sliderValue);


// RequireComponent restricts attachment of this script to an object with the stated component already attached
[RequireComponent(typeof(LinearDrive))]
public class LightSlider : MonoBehaviour
{
    public event LightUpdate LightUpdatedEvent;

    private LinearDrive sourceDrive;

    private float lastSliderValue;

    private float sliderValue;


    public void Awake()
    {
        lastSliderValue = float.MinValue;
        sliderValue = float.MinValue;
        sourceDrive = GetComponent<LinearDrive>();

        // Debug.Log("sourceDrive: " + sourceDrive.name);
    }

    public void Start()
    {
        // SliderUpdate(sourceDrive.linearMapping.value);
    }

    public void Update()
    {
        SliderUpdate(sourceDrive.linearMapping.value);
    }

//        #if UNITY_EDITOR
//        foreach(Delegate d in controlSlider.LightUpdate.GetInvocationList())
//        {
//            Debug.Log(d);
//        }
//#endif

public void SliderUpdate(float newSliderValue)
    {
        if (newSliderValue != lastSliderValue)
        {
#if UNITY_EDITOR
            // Debug.Log(string.Format("Slider Value / Last Value: {0} / {1}", sliderValue, lastSliderValue));
#endif
            if (LightUpdatedEvent != null)
                LightUpdatedEvent(sliderValue);
            else
                Debug.Log("LightSlider.LightUpdate has no invocation targets");


            // sliderValue = newSliderValue;
            lastSliderValue = newSliderValue;
        }
    }
}
