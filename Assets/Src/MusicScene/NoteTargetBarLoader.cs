using UnityEngine;

namespace Src.MusicScene
{
    public class NoteTargetBarLoader : MonoBehaviour
    {
        public GameObject NoteTargetPrefab;

        public void Start()
        {
            for (int i = -3; i < 4; i++)
            {
                var noteTarget = Instantiate(NoteTargetPrefab);
                noteTarget.transform.parent = transform;
                noteTarget.transform.SetPositionAndRotation(
                    new Vector3(i * 6, -25, 0),
                    Quaternion.identity);
            }
        }
    }
}