using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{

    public Image dialoguePortrait;
    public Text nameText;
    public Text dialogueText;
    public Text bubbleText;
    private Queue<string> sentences;
    private Queue<Dialogue.Info> dialogueInfo = new Queue<Dialogue.Info>();

    private bool isBubble;

    public Animator dialogueAnimator;
    public Animator bubbleAnimator;
    public Animator panelAnimator;
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        isBubble = false;
        dialogueAnimator.SetBool("isOpen", true);
        panelAnimator.SetBool("isOpen", true);
        dialogueInfo.Clear();

        //for each seperate info(name, portrait, dialogue text) in the list of information(dialogueInfo)....
        foreach (Dialogue.Info info in dialogue.dialogueInfo) 
        {
            dialogueInfo.Enqueue(info);
        }
        DisplayNextSentence();
    }

    public void StartBubble(BubbleSpeech bubble)
    {
        isBubble = true;
        bubbleAnimator.SetBool("isOpen", true);
        panelAnimator.SetBool("isOpen", true);
        sentences.Clear();

        foreach (string sentence in bubble.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(isBubble)
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
        else
        {
            if (dialogueInfo.Count == 0)
            {
                EndDialogue();
                return;
            }

            Dialogue.Info info = dialogueInfo.Dequeue();
            nameText.text = info.name;
            dialoguePortrait.sprite = info.portrait;
            dialogueText.text = info.sentences;
            StopAllCoroutines();
            StartCoroutine(TypeSceneDialogue(info));
        }
    }

    IEnumerator TypeSentence (string sentence)
    {
        bubbleText.text = "";
           
        foreach (char letter in sentence.ToCharArray())
        {
            bubbleText.text += letter;
            yield return null;
        }
    }

    IEnumerator TypeSceneDialogue(Dialogue.Info info)
    {
        dialogueText.text = "";
 
        foreach (char letter in info.sentences.ToCharArray())
        {  
            dialogueText.text += letter;  
            yield return null;
        }
    }


    void EndDialogue()
    {
        dialogueAnimator.SetBool("isOpen", false);
        bubbleAnimator.SetBool("isOpen", false);
        panelAnimator.SetBool("isOpen", false);
    }
}
