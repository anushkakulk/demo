using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class RespawnScript : MonoBehaviour
{
    public AudioSource oofSource;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    private void Start()
    {
       oofSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           HealthScript.health -= 1;
            player.transform.position = new Vector3(respawnPoint.transform.position.x, respawnPoint.transform.position.y, player.transform.position.z);
            //player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            oofSource.Play();

        }
    }
}
