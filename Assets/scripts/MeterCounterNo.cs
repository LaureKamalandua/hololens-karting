// Importing all of the libraries
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

// Defines the text of the meter counter on the right
public class MeterCounterNo : MonoBehaviour
{
    public Text counterText;
    void Start()
    {
        Debug.Log("MeterCounterNo initialized");
        counterText = GetComponent<Text>();
    }
    void Update()
    {
        // Debug.Log("MeterCounterNo update: " + DataProvider.currentData.circuit_distance);
        if (DataProvider.currentData == null)
        {
            counterText.text = "...";
        }
        else
        {
            // need to convert decimal to string here
            counterText.text = " " + DataProvider.currentData.circuit_distance;
        }
    }
}