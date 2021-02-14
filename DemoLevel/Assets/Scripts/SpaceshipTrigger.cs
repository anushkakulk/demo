using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchScene();

        }
    }
    void SwitchScene()
    {

        Debug.Log("Switch to cutScene4");
        SceneManager.LoadScene("cutScene4");
    }
}