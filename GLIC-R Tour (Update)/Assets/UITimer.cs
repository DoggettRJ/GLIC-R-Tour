using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UITimer : MonoBehaviour
{
    public GameObject Map;
    public GameObject welcomeVideo;
    public float sec = 8f;
    public VideoPlayer videoPlayer;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        videoPlayer.Play();

        if (Map.activeInHierarchy)
            Map.SetActive(false);

        StartCoroutine(UIBegin());
    }



    IEnumerator UIBegin()
    {

        yield return new WaitForSeconds(sec);

        Map.SetActive(true);
        welcomeVideo.SetActive(false);
        
        //Do Function here...
    }
}
