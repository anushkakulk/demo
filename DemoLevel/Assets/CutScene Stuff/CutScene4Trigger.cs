using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene4Trigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueCutScene4>().StartDialogue(dialogue);
    }

    void Start()
    {
        TriggerDialogue();
    }
}
