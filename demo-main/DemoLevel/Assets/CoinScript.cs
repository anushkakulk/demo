using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioSource coinSource; 
    private void Start()
    {
        coinSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            Destroy(col.gameObject, .00005f);
            ScoreScript.scoreValue += 5;
            coinSource.Play();
        }
    }
}
    

