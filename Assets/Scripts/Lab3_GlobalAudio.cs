// using System.Diagnostics;
using UnityEngine;

public class Lab3_GlobalAudio : MonoBehaviour
{
    bool isMuted = false;
    bool isPaused = false;

    void Update()
    {
        // MUTE / UNMUTE
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Audio Muted" : "Audio Unmuted");
        }

        // PAUSE / RESUME ALL AUDIO
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            AudioListener.pause = isPaused;
            Debug.Log(isPaused ? "Audio Paused" : "Audio Resumed");
        }
    }
}
