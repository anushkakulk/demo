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
        /*string[] sentences = { "Uh hello. Who are you?", "I am Martha, and you must be the savior King Kramer promised.",
                            "Yeah… I don’t really know what that’s about. He didn’t explain it very clearly to me.",
                            "Well, you’ve seen the dangerous slimes out there right? They are destroying the kingdom, and you are here to save us.",
                            "I haven’t even graduated high school yet; I’m not really the “hero” type.",
                            "Perhaps not in your world, but here, you are the only one with the power to stop the evil slimes. You can Respawn and we can’t.",
                            "Huh.",
                            "It’s not that difficult, I promise. Just find the magic key to banish all of the evil slimes away.",
                            "And where would that be?",
                            "I’m not sure, but I think Devin will know more. His house is a couple leagues from here, and evil slimes guard the roads. Will you go?",
                            "Sure. (What am I doing? I’m not a hero; I’m just a kid.)"}; */
        //dialogue = sentences;
     
        TriggerDialogue();
    }

    
}
