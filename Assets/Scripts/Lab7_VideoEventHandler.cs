using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Lab7_VideoEventHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Đăng ký event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        // Chuẩn bị video
        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã sẵn sàng và chạy");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video đã kết thúc");
        // Ví dụ: chuyển scene (có thể thay bằng bật UI)
        SceneManager.LoadScene("Lab7");
    }
}
