using GameLogic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {
        SoundManager.Instance.ButtonPressed();
        Application.Quit();
    }
}
