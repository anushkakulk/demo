using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene2Trigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueCutScene2>().StartDialogue(dialogue);
    }
    
    void Start()
    {
        TriggerDialogue();
    }

    
}
