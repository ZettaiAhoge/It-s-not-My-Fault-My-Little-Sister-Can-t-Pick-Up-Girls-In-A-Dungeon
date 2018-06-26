using UnityEngine;

namespace Src.MusicScene
{
    public class MusicDataState : MonoBehaviour
    {
        public string MusicFile;

        public static void AddToGameObject(GameObject obj, string musicFile)
        {
            var musicData = obj.AddComponent<MusicDataState>();
            musicData.MusicFile = musicFile;
        }
    }
}
