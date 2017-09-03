// Importing all of the libraries
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

// Defines the number of the position counter on the left
public class SpeedCounterNoB : MonoBehaviour
{
    public Text counterText;
    void Start()
    {
        // Debug.Log("SpeedCounterNoA initialized");
        counterText = GetComponent<Text>();
    }
    void Update()
    {
        // Debug.Log("SpeedCounterNoA update: " + DataProvider.currentData.speed);
        if (DataProvider.currentData == null)
        {
            counterText.text = "...";
        }
        else
        {
            string counterDataInt = Convert.ToString((DataProvider.currentData.speed));
            counterText.text = ((counterDataInt.Substring(counterDataInt.IndexOf(".")+1)).Substring(0,2));
        }
    }
}