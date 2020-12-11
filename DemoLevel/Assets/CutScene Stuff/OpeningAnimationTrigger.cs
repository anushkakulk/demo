using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpeningAnimationTrigger : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    private Vector3 position;
    public Animator MyAnimator;
    public bool TurnOn;
    // Use this for initialization
    void Start()
    {
        MyAnimator.gameObject.GetComponent<Animator>().enabled = true;
        position = gameObject.transform.position;
        TurnOn = false;
        target = new Vector3(6, -.6f, 0);
    }

    
    public void Update()
    {
        if (TurnOn)
        {

            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);

            if (transform.position.y == target.y && transform.position.x == target.x)
            {
                End();
            }

        }
    }

    public void Switch()
    {
        TurnOn = true;
    }

    void End()
    {
        MyAnimator.gameObject.GetComponent<Animator>().enabled = false;
        

    }

}
