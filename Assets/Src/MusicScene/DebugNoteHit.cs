using UnityEngine;

namespace Src.MusicScene
{
    public class DebugNoteHit : MonoBehaviour
    {
        public void Update()
        {
            if (transform.position.y < -25)
            {
                Destroy(gameObject);
            }
        }
    }
}