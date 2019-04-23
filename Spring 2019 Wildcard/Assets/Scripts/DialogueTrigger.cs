using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue sentence;

    public void startTalking()
    {
        FindObjectOfType<DialogueManager>().startDisplay(sentence);
    }
}
