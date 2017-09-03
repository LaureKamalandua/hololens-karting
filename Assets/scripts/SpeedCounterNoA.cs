// Importing all of the libraries
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

// Defines the number of the position counter on the left
public class SpeedCounterNoA : MonoBehaviour
{
    public Text counterText;
    private DateTime lastTime;

    void Start()
    {
        counterText = GetComponent<Text>();
       InvokeRepeating("Tick", 0, 0.5f);
       
    }

    void Tick()
    {
        int speed = (int) SpeedObject.Instance.speed;
        counterText.text = speed.ToString();
    }
}