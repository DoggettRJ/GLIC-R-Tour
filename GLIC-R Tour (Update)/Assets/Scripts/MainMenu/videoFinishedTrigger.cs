using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoFinishedTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject VideoScreen;
    public GameObject InteractionCube;
    public GameObject ThrowingCube;
    public Transform PosOrig;
    public GameObject TriggerToHold;

    void Start()
    {

        videoPlayer.Play();
        videoPlayer.loopPointReached += EndReached;

    }

    IEnumerator Example()
    {
        InteractionCube.SetActive(true);
        yield return new WaitForSeconds(1f);
        ThrowingCube.SetActive(true);
        yield return new WaitForSeconds(1f);
        TriggerToHold.SetActive(true);
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        videoPlayer.Stop();
        VideoScreen.SetActive(false);
        
        StartCoroutine(Example());

    }



}