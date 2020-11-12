using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            Destroy(col.gameObject, .25f);
            ScoreScript.scoreValue += 5;
        }
    }
}
    

