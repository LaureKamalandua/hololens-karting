using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gearIndicator : MonoBehaviour {

    public GameObject myCar;
    public float gearPos;
    public float gearOffset;

    private string gearText;

    //change "demoUI" with your script class name that contains the gear variable (float)
    private demoUI myScript;

	void Start () {
        //change "demoUI" with your script class name that contains the gear variable (float)
        myScript = myCar.GetComponent<demoUI>();
	
	}

	void Update () {
        //change "myScripr.gearValue" with "myScript.(your variable)" - [e. g. myScript.gear | myScript.gearPosition]
        gearPos = myScript.gearValue;

        gearText = (gearPos + gearOffset).ToString();
        if (gearText == "0") gearText = "N";
        if (gearText == "-1") gearText = "R";

        transform.GetComponent<Text>().text = gearText;
	
	}
}
