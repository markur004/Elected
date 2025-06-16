using UnityEngine;

using UnityEngine;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.errorReceived += ErrorReceived;
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.Prepare();
    }

    void Update()
    {
        Debug.Log($"Video time: {videoPlayer.time}, isPlaying: {videoPlayer.isPlaying}");
    }

    void OnPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared. Starting playback.");
        vp.Play();
    }

    void ErrorReceived(VideoPlayer vp, string message)
    {
        Debug.LogError("VideoPlayer error: " + message);
    }
}
