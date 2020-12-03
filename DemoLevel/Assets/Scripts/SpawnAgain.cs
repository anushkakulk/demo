using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgain : MonoBehaviour
{
    public AudioSource oofSource;
    [SerializeField] public Transform _player;
    [SerializeField] public Transform _respawnPoint;
    private void Start()
    {
        oofSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreScript.scoreValue -= 10;
            HealthScript.health -= 1;
            _player.transform.position = new Vector3(_respawnPoint.transform.position.x, _respawnPoint.transform.position.y, _player.transform.position.z);
            //player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            oofSource.Play();

        }
    }
}