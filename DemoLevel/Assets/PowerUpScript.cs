using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("PowerUp"))
        {
            Destroy(col.gameObject, .25f);
            HealthScript.health += 1;
        }

    }
}
