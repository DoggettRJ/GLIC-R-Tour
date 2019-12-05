using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoFinishedTeleport : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject VideoScreen;
    public GameObject TeleportOne;
    public GameObject TeleportTools;

    void Start()
    {
        videoPlayer.Play();
        videoPlayer.loopPointReached += EndReached;

    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1f);
        TeleportTools.SetActive(true);
        yield return new WaitForSeconds(1f);
        TeleportOne.SetActive(true);
        TeleportOne.SetActive(true);
        
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        videoPlayer.Stop();
        VideoScreen.SetActive(false);
        
        StartCoroutine(Example());

    }



}