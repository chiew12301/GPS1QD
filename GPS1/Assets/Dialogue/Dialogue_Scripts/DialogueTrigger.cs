using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public BubbleSpeech bubble;
    public BubbleSpeech changedBubble;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerBubble()
    {
        FindObjectOfType<DialogueManager>().StartBubble(bubble);
    }
    public void TriggerChangedBubble()
    {
        FindObjectOfType<DialogueManager>().StartBubble(changedBubble);
    }
}
