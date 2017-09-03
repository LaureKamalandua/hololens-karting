using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HeatTimeCounter : MonoBehaviour {

    public float heatFastestLap;

    [SerializeField]
    private Text heatFastestLapText;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        heatFastestLapText.text = heatFastestLap.ToString("n2");
    }
}
