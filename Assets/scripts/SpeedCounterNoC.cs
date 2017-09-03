// Importing all of the libraries
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

// Defines the text of the meter counter on the right
public class SpeedCounterNoC : MonoBehaviour
{
    public Text counterText;
    void Start()
    {
        counterText = GetComponent<Text>();
    }
    void Update()
    {
        counterText.text = "KM/H";
    }
}