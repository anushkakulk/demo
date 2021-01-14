using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class JumpingEnemy : MonoBehaviour
{
    public float JumpForce = 500;
    Rigidbody2D jnmeRigidBody2D;
    public bool isFalling = false;
    public void Awake()
    {
        jnmeRigidBody2D = GetComponent<Rigidbody2D>();

    }

    public void update()
    {
         //void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.CompareTag("Ground"))
        //{
            //isFalling = false;
        //}
    }
        //if(isFalling = false)
        //{
        //jnmeRigidBody2D.AddForce(new Vector2(0, JumpForce));
        // isFalling = true;
        //}
        jnmeRigidBody2D.AddForce(new Vector3(0f, JumpForce * Time.deltaTime, 0f));
    }

    
}

