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

    public void startDisplay(Dialogue lines)//called by Trigger. 
    {
        dialogue.Clear();
        nameText.text = lines.name;
        animator.SetBool("isOpen", true);//clear current dialogue, set name, bring up box
        foreach(string line in lines.sentences)
        {
            dialogue.Enqueue(line);
        }
        displayNext();//set up lines, start displaying
    }

    public void displayNext()//called by ^ and playerMovement
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

    IEnumerator TypeSentence (string sentence)//type the next char
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            if (dialogueText.text == currentSentence) typing = false;
            yield return null;
        }
    }

    public void endDialogue()//set bools, bring dialogue box down
    {
        animator.SetBool("isOpen", false);
        talking = false;
    }
}
