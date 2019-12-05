using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class TestVideoScript : MonoBehaviour
{

    [SerializeField]


    //Raw Image to Show Video Images [Assign from the Editor]
    public RawImage image;

    public GameObject playIcon;

    //Video To Play [Assign from the Editor]
    public VideoClip videoToPlay;

    public VideoPlayer videoPlayer;
    public VideoSource videoSource;

    //Audio
    private AudioSource audioSource;

    private bool isPaused = false;
    private bool firstRun = true;

  

    IEnumerator playVideo()
    {
        playIcon.SetActive(false);

        firstRun = false;
        //Add VideoPlayer to the GameObject
        //videoPlayer = gameObject.AddComponent<VideoPlayer>();

        //Add AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        //Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;

        //We want to play from video clip not from url
        videoPlayer.source = VideoSource.VideoClip;

        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        //Assign the Audio from Video to AudioSource to be played
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        //Wait until video is prepared
        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");
            yield return null;
        }

        Debug.Log("Done Preparing Video");

        //Assign the Texture from Video to RawImage to be displayed
        image.texture = videoPlayer.texture;

        videoPlayer.playOnAwake = true;
        videoPlayer.isLooping = true;

        //Play Video
        videoPlayer.Play();

        //Play Sound
        audioSource.Play();

        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        Debug.Log("Done Playing Video");
    }

    public void PlayPause()
    {
        if (!firstRun && !isPaused)
        {
            videoPlayer.Pause();
            audioSource.Pause();
            isPaused = true;
            playIcon.SetActive(true);
        }
        else if (!firstRun && isPaused)
        {
            videoPlayer.Play();
            audioSource.Play();
            isPaused = false;
            playIcon.SetActive(false);
        }
        else
        {
            StartCoroutine(playVideo());
        }
    }

    public void Stop()
    {
        if (!firstRun && !isPaused)
        {
            videoPlayer.Stop();
            audioSource.Stop();
            isPaused = true;
            playIcon.SetActive(true);
        }
        else if (!firstRun && isPaused)
        {
            videoPlayer.Stop();
            audioSource.Stop();
            isPaused = false;
            playIcon.SetActive(false);
        }
        else
        {
            StartCoroutine(playVideo());
        }
    }



}
