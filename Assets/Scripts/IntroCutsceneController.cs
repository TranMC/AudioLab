using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class IntroCutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource bgm;
    public string gameplaySceneName = "Gameplay";

    void Start()
    {
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        vp.Play();
        bgm.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        LoadGameplay();
    }

    public void SkipIntro()
    {
        videoPlayer.Stop();
        bgm.Stop();
        LoadGameplay();
        Debug.Log("Intro Skipped");
    }

    void LoadGameplay()
    {
        SceneManager.LoadScene(gameplaySceneName);
        Debug.Log("Welcome to the Game hẹ hẹ hẹ T_T");
    }
}
