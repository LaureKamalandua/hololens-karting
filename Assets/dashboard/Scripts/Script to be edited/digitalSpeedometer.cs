using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class digitalSpeedometer : MonoBehaviour {

    public GameObject myCar;
    public enum inputScale { KPH, MPH, MPS};
    public inputScale inputSpeedScale;
    public enum outputScale { KPH, MPH, MPS};
    public outputScale OutputSpeedScale;
    public float speed;

    private string speedText;
    private string scaleText;
    private float speedMultiplier;

    //change "demoUI" with your script class name that contains the speed variable
    private demoUI myScript;

    void Start () {
        //change "demoUI" with your script class name that contains the speed variable
        myScript = myCar.GetComponent<demoUI>();

        SpeedScale(OutputSpeedScale);

    }

	void Update () {
        //change "myScript.speedValue" with "myScript.(your variable)" - [e. g. myScript.speed | myScript.velocity]
        speed = myScript.speedValue;

        speedText = (Mathf.Round(speed * speedMultiplier)).ToString();
        transform.GetComponent<Text>().text = speedText;

	
	}

    void SpeedScale (outputScale speedScale)
    {
        if (inputSpeedScale == inputScale.KPH)
        {
            if (speedScale == outputScale.KPH) { speedMultiplier = 1; scaleText = " KPH"; }
            else if (speedScale == outputScale.MPH) { speedMultiplier = 0.62137f; scaleText = " MPH"; }
            else if (speedScale == outputScale.MPS) { speedMultiplier = 0.2778f; scaleText = " M/S"; }
        }
        else if (inputSpeedScale == inputScale.MPH)
        {
            if (speedScale == outputScale.KPH) { speedMultiplier = 1.61f; scaleText = " KPH"; }
            else if (speedScale == outputScale.MPH) { speedMultiplier = 1; scaleText = " MPH"; }
            else if (speedScale == outputScale.MPS) { speedMultiplier = 0.447f; scaleText = " M/S"; }
        }
        else if (inputSpeedScale == inputScale.MPS)
        {
            if (speedScale == outputScale.KPH) { speedMultiplier = 3.6f; scaleText = " KPH"; }
            else if (speedScale == outputScale.MPH) { speedMultiplier = 2.237f; scaleText = " MPH"; }
            else if (speedScale == outputScale.MPS) { speedMultiplier = 1; scaleText = " M/S"; }
        }
    }
}
