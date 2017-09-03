using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class demoUI : MonoBehaviour {

    public GameObject speed;
    public GameObject rpm;
    public GameObject gear;
    public GameObject speedSlider;
    public GameObject rpmSlider;
    public GameObject gearSlider;
    public float speedValue;
    public float rpmValue;
    public float gearValue;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        speedValue = Mathf.Round (speedSlider.GetComponent<Slider>().value);
        rpmValue = Mathf.Round( rpmSlider.GetComponent<Slider>().value);
        gearValue = Mathf.Round( gearSlider.GetComponent<Slider>().value);

        speed.GetComponent<Text>().text = speedValue.ToString() + " kph" + " " + (Mathf.Round(speedValue * 0.6214f)).ToString() + " mph";
        rpm.GetComponent<Text>().text = rpmValue.ToString() + " rpm";
        gear.GetComponent<Text>().text = "gear " + gearValue.ToString();



    }
}
