using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KramerAnimation : MonoBehaviour
{

    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= 10)
        {
            m_Animator.Play("MyAnimation");
        }
        else
        {
            m_Animator.Play("Stop");  //Here another state
        }
    }
}
