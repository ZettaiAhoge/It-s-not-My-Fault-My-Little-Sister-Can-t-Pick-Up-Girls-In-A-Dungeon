using System;
using UnityEngine;

namespace Src.MusicScene
{
    public class MusicSceneInitialization : MonoBehaviour
    {
        private void Awake()
        {
            var globals = GameObject.Find("Globals");
            
            if (Config.Debug)
            {
                if (globals.GetComponentInChildren<MusicDataState>() == null)
                {
                    MusicDataState.AddToGameObject(globals, "shokuzainoserenade");
                }
            }
        }
    }
}