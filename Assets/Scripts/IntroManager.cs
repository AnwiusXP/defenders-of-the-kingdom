using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class IntroManager : MonoBehaviour
{
    public VideoPlayer videoPlayer; // tu componente Video Player
    public Button skipButton;       // botón Omitir

    void Start()
    {
        // cuando se haga clic en Omitir
        skipButton.onClick.AddListener(SkipIntro);

        // cuando el video termine
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void SkipIntro()
    {
        LoadMenu();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        LoadMenu();
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene"); // usa exactamente el nombre de tu escena
    }
}