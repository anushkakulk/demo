using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpeningAnimationTrigger : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    private Vector3 position;
    public Animator MyAnimator;
    // Use this for initialization
    void Start()
    {
        MyAnimator.gameObject.GetComponent<Animator>().enabled = true;
        position = gameObject.transform.position;
        MyAnimator = GetComponent<Animator>();
        target = new Vector3(6, -.6f, 0);
    }

    
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if(position.y == target.y && position.x == target.x)
        {
            End();
        }
    }

    void End()
    {
        MyAnimator.enabled = false ;
    }

}
