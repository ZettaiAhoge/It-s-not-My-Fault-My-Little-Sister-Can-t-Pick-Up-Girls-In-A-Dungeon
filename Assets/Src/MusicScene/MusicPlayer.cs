using UnityEngine;
using UnityEngine.Audio;

namespace Src.MusicScene
{
    public class MusicPlayer : MonoBehaviour
    {
        public void Start()
        {
            var musicDataState = GameObject.Find("Globals").GetComponentInChildren<MusicDataState>();

            var audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = Resources.Load<AudioClip>(string.Format("Music/{0}", musicDataState.MusicFile));

            audioSource.Play();
        }
    }
}