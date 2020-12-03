using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualTriggerAnimation : MonoBehaviour
{
    public OpeningAnimationTrigger Anim;

    public void TriggerAnim()
    {
        FindObjectOfType<OpeningAnimationTrigger>().Switch();
    }
}
