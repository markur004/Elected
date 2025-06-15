using GameLogic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("DUpa");
        SoundManager.Instance.ButtonPressed();
        Application.Quit();
    }
}
