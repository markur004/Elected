using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroHandler : MonoBehaviour
{
    [SerializeField] private VideoPlayer _player;
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
}
