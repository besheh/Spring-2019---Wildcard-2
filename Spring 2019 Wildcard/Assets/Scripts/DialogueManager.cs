using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public bool typing = false;
    public bool talking = false;
    public string currentSentence;

    public Queue<string> dialogue;

    void Start()
    {
        dialogue = new Queue<string>();
    }
    public void startDisplay(Dialogue lines)
    {
        dialogue.Clear();
        nameText.text = lines.name;
        animator.SetBool("isOpen", true);
        foreach(string line in lines.sentences)
        {
            dialogue.Enqueue(line);
        }
        displayNext();
    }
    public void displayNext()
    {
        if(dialogue.Count == 0)
        {
            endDialogue();
            return;
        }
        talking = true;
        //StopAllCoroutines();
        if (typing)
        {
            StopAllCoroutines();
            dialogueText.text = currentSentence;
            typing = false;
        }
        else
        {
            currentSentence = dialogue.Dequeue();
            StartCoroutine(TypeSentence(currentSentence));
            typing = true;
        }
       // dialogueText.text = dialogue.Dequeue();
    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            if (dialogueText.text == currentSentence) typing = false;
            yield return null;
        }
    }
    public void endDialogue()
    {
        animator.SetBool("isOpen", false);
        talking = false;
    }
}
