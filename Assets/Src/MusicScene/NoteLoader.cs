using System;
using System.IO;
using UnityEngine;

namespace Src.MusicScene
{
    public class NoteLoader : MonoBehaviour
    {
        public GameObject NotePrefab;

        public void Start()
        {
            var musicDataState = GameObject.Find("Globals").GetComponentInChildren<MusicDataState>();
            var museFilePath = string.Format("{0}/Resources/Muse/{1}.muse", Application.dataPath, musicDataState.MusicFile);

            using (var file = File.Open(museFilePath, FileMode.Open))
            {
                using (var reader = new StreamReader(file))
                {
                    while (!reader.EndOfStream)
                    {
                        try
                        {
                            var line = reader.ReadLine();
                            var split = line.Split(' ');
                            var time = split[0];
                            var channel = split[1];

                            CreateNote(Convert.ToDecimal(time) * musicDataState.NoteSpeed, Convert.ToInt32(channel));
                        }
                        catch (Exception)
                        {
                            Debug.LogError("found bad data in muse file");
                        }
                    }
                }
            }
        }

        private void CreateNote(decimal position, int channel)
        {
            var note = Instantiate(NotePrefab);
            note.transform.SetParent(transform);
            note.transform.SetPositionAndRotation(
                new Vector3((channel - 3) * 6, Convert.ToSingle(position) - 25, 0),
                Quaternion.identity);
        }
    }
}