using System;

using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightManager : MonoBehaviour
{
    [SerializeField]
    private LightSlider controlSlider;

    [SerializeField]
    private float lightMinimum = 0.0f;
    [SerializeField]
    private float lightMaximum = 1.0f;

    [SerializeField]
    private float recordingMinimum = 0.4f;
    [SerializeField]
    private float recordingMaximum = 0.6f;

    private Light lightSource;

    // private LightUpdate lightUpdate;

    public float LightIntensity
    {
        get
        {
            return lightSource.intensity;
        }
    }

    public void OnEnable()
    {
        Debug.Log(gameObject.name + " - " +  controlSlider.gameObject.name + " - controlSlider.LightUpdate += SetLightBrightness;");
        controlSlider.LightUpdatedEvent += SetLightBrightness;
    }

    public void OnDisable()
    {
        Debug.Log(gameObject.name + " - " + controlSlider.gameObject.name + "controlSlider.LightUpdate -= lightUpdate;");
        controlSlider.LightUpdatedEvent -= SetLightBrightness;
    }

    public RecordingLightLevel GetRecordingLightLevel()
    {
        if (LightIntensity < recordingMinimum)
        {
            return RecordingLightLevel.Dark;
        }
        else if (LightIntensity > recordingMaximum)
        {
            return RecordingLightLevel.Bright;
        }
        else
        {
            return RecordingLightLevel.Correct;
        }
    }

    // Does not work, left here as aide de memior
    [ExecuteInEditMode]
    private void CheckMinMaxLightRecordingLevels()
    {
        if (recordingMinimum < lightMinimum)
        {
            recordingMinimum = lightMinimum;
        }
    }

    // Use this for initialization
    public void Awake()
    {
        // Ideally use "is null" but you need to be on newer .net version (4.6)
        // Debug.Log("if (controlSlider == null)");
        if (controlSlider == null)
            throw new Exception(string.Format("{0} does not have a LightSlider assigned!", name));

        lightSource = GetComponent<Light>();
        lightSource.intensity = lightMinimum;

        // lightUpdate = SetLightBrightness;
    }

    public void SetLightBrightness(float brightnessValue)
    {
        // normalise value from 0 - 1
        float tempIntensity = Mathf.Lerp(lightMinimum, lightMaximum, brightnessValue);
        lightSource.intensity = tempIntensity;
        // lightSource.intensity = Mathf.Lerp(lightMinimum, lightMaximum, brightnessValue);
#if UNITY_EDITOR
        // Debug.Log(string.Format("Brightness / Intensity: {0} / {1}", brightnessValue, tempIntensity));
#endif
    }

    public void OnDestroy()
    {
        controlSlider.LightUpdatedEvent -= SetLightBrightness;
    }
}
