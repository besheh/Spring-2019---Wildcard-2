using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Dialogue sentence;
    public int triggerIndex;

    public void startTalking()
    {
        FindObjectOfType<DialogueManager>().startDisplay(sentence);
        FindObjectOfType<FlagManager>().upFlag(triggerIndex);
    }
}
