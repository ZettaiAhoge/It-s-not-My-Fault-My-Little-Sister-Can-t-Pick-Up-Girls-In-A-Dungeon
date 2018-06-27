using UnityEngine;

namespace Src.MusicScene
{
    public class TemporaryNoteCanvas : MonoBehaviour
    {
        private float _startTime;

        public void Start()
        {
            _startTime = Time.time;
        }

        public void Update()
        {
            transform.SetPositionAndRotation(
                Vector3.down * (Time.time - _startTime) * 30,
                Quaternion.identity);
        }
    }
}