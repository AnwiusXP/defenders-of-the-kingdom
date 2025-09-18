using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
    public RectTransform creditsText; // El objeto con tu texto (TMP)
    public float scrollSpeed = 50f;
    public float startY = -400f;
    public float endY = 400f;

    public Button skipButton;

    void Start()
    {
        // cuando se haga clic en Omitir
        skipButton.onClick.AddListener(SkipIntro);
    }

    private void OnEnable()
    {
        creditsText.anchoredPosition = new Vector2(
            creditsText.anchoredPosition.x, startY
        );
        StartCoroutine(ScrollCredits());
    }

    private IEnumerator ScrollCredits()
    {
        while (creditsText.anchoredPosition.y < endY)
        {
            creditsText.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("MenuScene"); // vuelve al menú cuando termina
    }

    void SkipIntro()
    {
        BackToMenu();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
