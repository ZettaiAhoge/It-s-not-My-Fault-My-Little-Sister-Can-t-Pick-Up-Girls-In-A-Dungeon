using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicData : MonoBehaviour
{
    public string musicFile;

    public static void AddToGameObject(GameObject obj, string musicFile)
    {
        obj.AddChild();
    }
}
