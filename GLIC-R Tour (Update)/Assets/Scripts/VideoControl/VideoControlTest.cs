using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoControlTest : MonoBehaviour
{
    [SerializeField]
    private VideoClip[] videoClips;

    [SerializeField]
    private Text debugOutput;

    private VideoPlayer videoPlayer;

    public void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Use this for initialization
    public void Start()
    {
        videoPlayer.targetTexture.Release();
        // videoPlayer.clip = 
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (!videoPlayer.isPlaying)
                {
                    videoPlayer.clip = videoClips[0];
                    if (debugOutput != null)
                    {
                        debugOutput.text = videoClips[0].name;
                    }
                }
                else
                {
                    if (debugOutput != null)
                    {
                        debugOutput.text = "Cannot change while playing";
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (!videoPlayer.isPlaying)
                {
                    videoPlayer.clip = videoClips[1];
                    if (debugOutput != null)
                    {
                        debugOutput.text = videoClips[1].name;
                    }
                }
                else
                {
                    if (debugOutput != null)
                    {
                        debugOutput.text = "Cannot change while playing";
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Stop();
                    videoPlayer.targetTexture.Release();
                }
                else
                {
                    videoPlayer.Play();
                }
            }
        }
    }
}
