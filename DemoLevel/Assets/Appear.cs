using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Appear : MonoBehaviour
{

    Text continueButton;
    // Start is called before the first frame update
    void Start()
    {
        continueButton = GetComponent<Text>();
        continueButton.text = "Continue>>";
    }

   
}
