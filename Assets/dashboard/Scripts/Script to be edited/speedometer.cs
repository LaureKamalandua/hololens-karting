using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class speedometer : MonoBehaviour {

    public GameObject needle;
    public GameObject myCar;

    public float speed;
    public enum mult { constantMultiplier, variableMultiplier};
    public mult multiplierOption;
    public enum scale { kph, mph, mps};
    public scale InputSpeedScale;
    private float scaleMultplier;

    public float offset;
    public float multiplier;
    public float secondMultiplier;
    public float multiplierChangesAfter;

    //change "demoUI" with your script class name that contains the speed variable
    private demoUI myScript;

    void Awake () {
        //change "demoUI" with your script class name that contains the speed variable
        myScript = myCar.GetComponent<demoUI>();

        needle = transform.FindChild("needle").gameObject;
        ScaleCalc(InputSpeedScale);
        
	
	}

    void ScaleCalc (scale multiplierScale)
    {
        if (multiplierScale == scale.kph) scaleMultplier = 3.6f;
        else if (multiplierScale == scale.mph) scaleMultplier = 2.237f;
        else if (multiplierScale == scale.mps) scaleMultplier = 1;
    }

	void Update () {
        //change "myScripr.speedValue" with "myScript.(your variable)" - [e. g. myScript.speed | myScript.velocity]
        speed = myScript.speedValue;

        MultiplierCalc(multiplierOption);
    }

    void MultiplierCalc (mult multiplierOption)
    {
        Quaternion rot = new Quaternion();

        if (multiplierOption == mult.constantMultiplier)
        {
            rot.eulerAngles = new Vector3(0, 0, (speed * -multiplier - (offset * scaleMultplier)) / scaleMultplier);
            needle.transform.rotation = rot;
        }
        else if (multiplierOption == mult.variableMultiplier)
        {
            if (speed / scaleMultplier < multiplierChangesAfter)
            {
                rot.eulerAngles = new Vector3(0, 0, (speed * -multiplier - (offset * scaleMultplier)) / scaleMultplier);
                needle.transform.rotation = rot;
            }
            if (speed / scaleMultplier >= multiplierChangesAfter)
            {
                rot.eulerAngles = new Vector3(0, 0, (speed * -secondMultiplier + (multiplierChangesAfter * scaleMultplier * (secondMultiplier - multiplier)) - (offset * scaleMultplier)) / scaleMultplier);
                needle.transform.rotation = rot;
            }
        }
    }

    

}
