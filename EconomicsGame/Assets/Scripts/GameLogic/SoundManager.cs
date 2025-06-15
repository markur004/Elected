using UnityEngine;

namespace GameLogic
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;
        [SerializeField] private AudioSource _button;
        [SerializeField] private AudioSource _source;
        public float currentVolume = 0.5f;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }

        public void Volume(float volume)
        {
            _source.volume = volume;
            _button.volume = volume;
            currentVolume = volume;
        }

        public float ReturnCurrentVolume()
        {
            return currentVolume;
        }

        public void ButtonPressed()
        {
            _button.Play();
        }
    }
}