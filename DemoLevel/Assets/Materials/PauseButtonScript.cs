using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButtonScript : MonoBehaviour
{
    bool isPaused = false;

    public AudioSource pauseSource;
    private void Start()
    {
        pauseSource = GetComponent<AudioSource>();
    }
    public void pauseGame()
         
    {
        pauseSource.Play();
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;

        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
           
        }
    }
}
    