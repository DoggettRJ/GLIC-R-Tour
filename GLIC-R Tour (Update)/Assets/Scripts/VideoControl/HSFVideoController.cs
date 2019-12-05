using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public enum RecordingLightLevel { Dark, Bright, Correct, Error }

public class HSFVideoController : MonoBehaviour
{
    [SerializeField]
    private bool debug;

    [SerializeField]
    private VideoClip[] videoClips;

    [SerializeField]
    private VideoPlayer[] videoPlayers;

    [SerializeField]
    private LightButtonOutput lightSwitch;

    [SerializeField]
    private RecOnClickFunction cameraSwitch;

    [SerializeField]
    private LightManager lightManager;

    [SerializeField]
    private CameraFPSSetting cameraFPSSetting;

    private enum ExperimentVideo { NoRecording, UnderExposed, OverExposed, LowFPS30, LowFPS250, Perfect, EvaluationFault }

    private void DebugOutout(string debugText)
    {
#if UNITY_EDITOR
        if (debug)
        {
            Debug.Log(debugText);
        }
#endif
    }

    /// <summary>
    /// 
    /// </summary>
    public void InitiateHSFExperimentEvaluation()
    {
        DebugOutout("public void InitiateHSFExperimentEvaluation()");

        // Evaluate which video clip to play
        ExperimentVideo clipEnumeration = EvaluateExperimentOutput();

        int clipID = ExperimentVideoClipLookup(clipEnumeration);

        // Start clip playing if valid
        if (clipID > -1)
        {
            PlayVideoClip(Convert.ToUInt32(clipID));
        }
    }

    /// <summary>
    /// IMPORTANT: 
    ///     return values need to match videos in:
    ///         private VideoClip[] videoClips;
    /// Nb. Yes, this is a dirty hack.
    /// </summary>
    /// <param name="experimentOutout"></param>
    /// <returns></returns>
    private int ExperimentVideoClipLookup(ExperimentVideo experimentOutout)
    {
        switch (experimentOutout)
        {
            case ExperimentVideo.NoRecording:
                return 0;
            case ExperimentVideo.UnderExposed:
                return 1;
            case ExperimentVideo.OverExposed:
                return 2;
            case ExperimentVideo.LowFPS30:
                return 3;
            case ExperimentVideo.LowFPS250:
                return 4;
            case ExperimentVideo.Perfect:
                return 5;
            case ExperimentVideo.EvaluationFault:
                // Error in assigning experiment outcome
                return int.MinValue;  // -2147483648
            default:
                // New unaccounted for ExperimentVideo value
                return -1;
        }
    }

    #region Evaluation Checks

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private ExperimentVideo EvaluateExperimentOutput()
    {
        // Video determination logic
        // ??
        ExperimentVideo videoEvaluation; // = ExperimentVideo.EvaluationFault;

        if (CheckCameraActivation(out videoEvaluation))
        {
            if (CheckLightActivation(out videoEvaluation))
            {
                if (CheckLightLevel(out videoEvaluation))
                {
                    CheckFrameRate(out videoEvaluation);
                }
            }
        }
        
        return videoEvaluation;
    }

    private bool CheckCameraActivation(out ExperimentVideo videoEvaluation)
    {
        if (cameraSwitch.CameraActivated)
        {
            videoEvaluation = ExperimentVideo.EvaluationFault;
            return true;
        }
        else
        {
            videoEvaluation = ExperimentVideo.NoRecording;
            return false;
        }
    }

    private bool CheckLightActivation(out ExperimentVideo videoEvaluation)
    {
        // Check if lightSwitchScript is active
        if (lightSwitch.gameObject.activeInHierarchy)
        {
            videoEvaluation = ExperimentVideo.EvaluationFault;
            return true;
        }
        else
        {
            videoEvaluation = ExperimentVideo.UnderExposed;
            return false;
        }
    }


    private bool CheckLightLevel(out ExperimentVideo videoEvaluation)
    {
        // TODO: Add if (lightManager != null)
        bool lightOK = false;
        
        switch(lightManager.GetRecordingLightLevel())
        {
            case RecordingLightLevel.Dark:
                videoEvaluation = ExperimentVideo.UnderExposed;
                break;
            case RecordingLightLevel.Bright:
                videoEvaluation = ExperimentVideo.OverExposed;
                break;
            case RecordingLightLevel.Correct:
                videoEvaluation = ExperimentVideo.EvaluationFault;
                lightOK = true;
                break;
            default:
                videoEvaluation = ExperimentVideo.EvaluationFault;
                break;
        }

        return lightOK;
    }

    private bool CheckFrameRate(out ExperimentVideo videoEvaluation)
    {
        bool frameRateCheck = false;
        videoEvaluation = ExperimentVideo.EvaluationFault;

        FPSSetting fPSSetting = cameraFPSSetting.GetCurrentFPSSetting();

        switch (fPSSetting)
        {
            case FPSSetting.FPS30:
                videoEvaluation = ExperimentVideo.LowFPS30;
                frameRateCheck = true;
                break;
            case FPSSetting.FPS250:
                videoEvaluation = ExperimentVideo.LowFPS250;
                frameRateCheck = true;
                break;
            case FPSSetting.FPS5000:
                videoEvaluation = ExperimentVideo.Perfect;
                frameRateCheck = true;
                break;
            default:
                throw new Exception("Something rotten in the state of experiment evaluation!");
        }

        return frameRateCheck;
    }

    #endregion Evaluation Checks

    #region Video Player Control

    private void PlayVideoClip(uint clipID)
    {
        SetCurrentClip(clipID);
        PlayCurrentClip();
    }

    private void SetCurrentClip(uint clipID)
    {
        if (clipID < videoClips.Length)
        {
            foreach (VideoPlayer player in videoPlayers)
            {
                player.clip = videoClips[clipID];
            }
        }
        else
        {
            throw new Exception("Requested clipID not in HSFVideoController.videoClips");
        }
    }

    public void PlayCurrentClip()
    {
        foreach (VideoPlayer player in videoPlayers)
        {
            if (!player.isPlaying)
            {
                player.Play();
            }
        }
    }

    #endregion Video Player Control
}
