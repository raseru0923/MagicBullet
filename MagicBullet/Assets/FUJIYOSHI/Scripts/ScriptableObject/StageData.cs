using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TalkData", menuName = "ScriptableObjects/TalkData")]
public class StageData : ScriptableObject
{
    public Scene[] Scenes;
}

[System.Serializable]
public struct Scene
{
    [TextArea] public string word;
}
