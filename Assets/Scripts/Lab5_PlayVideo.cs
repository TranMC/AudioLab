using UnityEngine;
using UnityEngine.Video;

public class Lab5_PlayVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
            Debug.Log("Video Played");
        }
    }
}
