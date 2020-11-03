using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            ScoreScript.scoreValue += 20;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
  