using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoFinished : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject VideoScreen;
    public GameObject InteractionCube;
   

    void Start()
    {
        videoPlayer.Play();
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        VideoScreen.SetActive(false);
        VideoScreen.SetActive(false);
        InteractionCube.SetActive(true);
    
    }
}