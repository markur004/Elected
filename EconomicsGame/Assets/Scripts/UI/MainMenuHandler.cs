using GameLogic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject _optionsPanel;
    [SerializeField] private Slider _soundSlider;
    public void PlayButton()
    {
        SceneManager.LoadScene("GameplayScene");
        SoundManager.Instance.ButtonPressed();
    }

    public void OptionsButton()
    {
        SoundManager.Instance.ButtonPressed();
        _soundSlider.value = SoundManager.Instance.currentVolume;
        _optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        SoundManager.Instance.ButtonPressed();
        _optionsPanel.SetActive(false);
    }

    public void AudioSlider()
    {
        SoundManager.Instance.Volume(_soundSlider.value);
    }

    public void QuitButton()
    {
        SoundManager.Instance.ButtonPressed();
        Application.Quit();
    }
}
