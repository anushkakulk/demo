﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPause : MonoBehaviour
{
    public Text textField;

    public void SetText(string text)
    {
        textField.text = text;
        Destroy(gameObject, 1f);
    }
}