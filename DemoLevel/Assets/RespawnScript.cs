using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
    private void OnTriggerEnter2D(Collider2D other) 
    { 
        if(other.CompareTag("Player"))
        {
            player.transform.position = new Vector3(respawnPoint.transform.position.x, respawnPoint.transform.position.y, player.transform.position.z);
            //player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
