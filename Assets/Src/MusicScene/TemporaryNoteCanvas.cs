using UnityEngine;

namespace Src.MusicScene
{
    public class TemporaryNoteCanvas : MonoBehaviour
    {
        public GameObject MusicPlayerObject;

        private int _noteSpeed;

        public void Start()
        {
            _noteSpeed = GameObject.Find("Globals").GetComponentInChildren<MusicDataState>().NoteSpeed;
        }

        public void Update()
        {
            transform.SetPositionAndRotation(
                Vector3.down * MusicPlayerObject.GetComponent<MusicPlayer>().GetAudioSource().time * _noteSpeed,
                Quaternion.identity);
        }
    }
}