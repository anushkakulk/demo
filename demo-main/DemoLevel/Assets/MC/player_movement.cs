using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 1000f;
    private float movement = 10f;
    private Rigidbody2D rigidBody;

    public GameObject bulletToRight, bulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else if (movement < 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    
        if (Input.GetButtonDown ("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
          fire();
        }

        void fire ()
        {
         bulletPos = transform.position;
            if (movement > 0f)
            {
                bulletPos += new Vector2(+1f, -0.5f);
                Instantiate(bulletToRight, bulletPos, Quaternion.identity);
            } else if (movement < 0f)
            {
                bulletPos += new Vector2(-1f, -0.5f);
                Instantiate(bulletToLeft, bulletPos, Quaternion.identity);
            }
            }
        }


    }
