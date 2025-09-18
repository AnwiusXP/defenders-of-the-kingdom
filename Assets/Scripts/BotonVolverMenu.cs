using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonVolverMenu : MonoBehaviour
{
    public void VolverMenu()
    {
        SceneManager.LoadScene("MenuScene"); 
    }
}