// Importing all of the libraries
using UnityEngine;
using UnityEngine.UI;
using System;

// Defines the number of the position counter on the left
public class PositionCounterNo : MonoBehaviour
{
    public Text counterText;
    void Start()
    {
        // Debug.Log("PositionCounterNo initialized");
        counterText = GetComponent<Text>();
    }
    void Update()
    {
        // Debug.Log("PositionCounterNo update: " + DataProvider.currentData.position);
        if (DataProvider.currentData == null)
        {
            counterText.text = "...";
        }
        else
        {
            string counterDataInt = Convert.ToString((DataProvider.currentData.position));
            counterText.text = counterDataInt;

        }
    }
}