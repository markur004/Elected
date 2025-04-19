using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameplayScene");
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
