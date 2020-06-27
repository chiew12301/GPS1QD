using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Bubble", menuName = "Bubbles")]
public class BubbleSpeech : ScriptableObject
{
    [System.Serializable]
    public class Info
    {
        [TextArea(1, 10)]
        public string sentences;
        public bool isJitter;
    }
    [Header("Write down the bubble speech below")]
    public Info[] bubbleInfo;
}
