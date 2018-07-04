using UnityEngine;

namespace Src.MusicScene
{
    public class MusicPlayer : MonoBehaviour
    {
        private AudioSource _audioSource;

        public void Start()
        {
            var musicDataState = GameObject.Find("Globals").GetComponentInChildren<MusicDataState>();

            _audioSource = gameObject.AddComponent<AudioSource>();
            _audioSource.clip = Resources.Load<AudioClip>(string.Format("Music/{0}", musicDataState.MusicFile));

            _audioSource.Play();
        }

        public AudioSource GetAudioSource()
        {
            return _audioSource;
        }
    }
}