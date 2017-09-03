using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tachometer : MonoBehaviour {

    public GameObject needle;
    public GameObject myCar;

    public float rpm;
    public enum mult { constantMultiplier, variableMultiplier };
    public mult multiplierOption;

    public float offset;
    public float multiplier;
    public float secondMultiplier;
    public float multiplierChangesAfter;

    //change "demoUI" with your script class name that contains the RPM variable
    private demoUI myScript;

    void Start () {
        //change "demoUI" with your script class name that contains the RPM variable
        myScript = myCar.GetComponent<demoUI>();

        needle = transform.FindChild("needle").gameObject;
    }
	
	void Update () {
        //change "myScripr.rpmValue" with "myScript.(your variable)" - [e. g. myScript.rpm | myScript.rev]
        rpm = myScript.rpmValue;

        MultiplierCalc(multiplierOption);

    }

    void MultiplierCalc(mult multiplierOption)
    {
        Quaternion rot = new Quaternion();

        if (multiplierOption == mult.constantMultiplier)
        {
            rot.eulerAngles = new Vector3(0, 0, (rpm * -multiplier - offset));
            needle.transform.rotation = rot;
        }
        else if (multiplierOption == mult.variableMultiplier)
        {
            if (rpm < multiplierChangesAfter)
            {
                rot.eulerAngles = new Vector3(0, 0, (rpm * -multiplier - offset));
                needle.transform.rotation = rot;
            }
            if (rpm >= multiplierChangesAfter)
            {
                rot.eulerAngles = new Vector3(0, 0, (rpm * -secondMultiplier + (multiplierChangesAfter * (secondMultiplier - multiplier)) - offset));
                needle.transform.rotation = rot;
            }
        }
    }
}
