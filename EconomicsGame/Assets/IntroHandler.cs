using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroHandler : MonoBehaviour
{
    [SerializeField] private VideoPlayer _player;
    [SerializeField] private GameObject _krystianLis;
    void Start()
    {
        _player.Prepare();
        _player.prepareCompleted += OnVideoPrepared;
        _player.loopPointReached += OnVideoEnd;
    }
    
    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene("GamePlayScene");
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        vp.Play();
    }
    
    public void EasterEgg()
    {
        _krystianLis.SetActive(true);
    }
}
