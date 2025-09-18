using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Necesario para usar botones

public class MenuManager : MonoBehaviour
{
    public Button startButton;   // Botón Jugar
    public Button creditsButton; // Botón Créditos
    public Button exitButton;    // Botón Salir (opcional)

    void Start()
    {
        // Le decimos qué hacer a cada botón cuando lo pulsen
        startButton.onClick.AddListener(PlayGame);
        creditsButton.onClick.AddListener(OpenCredits);

        if (exitButton != null) // solo si existe en la escena
            exitButton.onClick.AddListener(ExitGame);
    }

    public void PlayGame()
    {
        // Cambiar "Level1Scene" por el nombre exacto de tu escena de nivel
        SceneManager.LoadScene("Level1Scene");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void ExitGame()
    {
        Application.Quit(); 
        Debug.Log("El juego se cerraría aquí (solo funciona en build).");
    }
}