using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FPSSetting { FPSNone, FPS30, FPS250, FPS5000 }

public class CameraFPSSetting : MonoBehaviour
{
    [SerializeField]
    private GameObject fPS30;

    [SerializeField]
    private GameObject fPS250;

    [SerializeField]
    private GameObject fPS5000;

    public FPSSetting GetCurrentFPSSetting()
    {
        // TODO: No null checking

        if (fPS30.activeInHierarchy)
            return FPSSetting.FPS30;
        if (fPS250.activeInHierarchy)
            return FPSSetting.FPS250;
        if (fPS5000.activeInHierarchy)
            return FPSSetting.FPS5000;

        return FPSSetting.FPSNone;
    }
}
