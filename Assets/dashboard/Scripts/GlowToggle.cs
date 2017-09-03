using UnityEngine;
using System.Collections;

public class GlowToggle : MonoBehaviour {

    public bool glow;

    public GameObject speedometerParent;
    public GameObject tachometerParent;
    public GameObject tachoNeedleParent;
    public GameObject speedoNeedleParent;
    public GameObject speedometer;
    public GameObject tachometer;
    public GameObject speedometerGlow;
    public GameObject tachometerGlow;
    public GameObject tachoNeedle;
    public GameObject tachoNeedleGlow;
    public GameObject speedoNeedle;
    public GameObject speedoNeedleGlow;

    void Start() {
        speedometerParent = transform.FindChild("Speedometer").gameObject;
        speedoNeedleParent = speedometerParent.transform.FindChild("needle").gameObject;
        tachoNeedleParent = tachometerParent.transform.FindChild("needle").gameObject;

        speedometer = speedometerParent.transform.FindChild("speedometer").gameObject;
        speedometerGlow = speedometerParent.transform.FindChild("speedometer_glow").gameObject;
        tachometer = tachometerParent.transform.FindChild("tachometer").gameObject;
        tachometerGlow = tachometerParent.transform.FindChild("tachometer_glow").gameObject;
        speedoNeedle = speedoNeedleParent.transform.FindChild("needle").gameObject;
        speedoNeedleGlow = speedoNeedleParent.transform.FindChild("needle_glow").gameObject;
        tachoNeedle = tachoNeedleParent.transform.FindChild("needle").gameObject;
        tachoNeedleGlow = tachoNeedleParent.transform.FindChild("needle_glow").gameObject;

    }
	
	void Update () {
        if (glow == true) { speedometerGlow.SetActive(true); tachometerGlow.SetActive(true); speedometer.SetActive(false); tachometer.SetActive(false); speedoNeedleGlow.SetActive(true); tachoNeedleGlow.SetActive(true); speedoNeedle.SetActive(false); tachoNeedle.SetActive(false); }
        else if (glow == false) { speedometer.SetActive(true); tachometer.SetActive(true); speedometerGlow.SetActive(false); tachometerGlow.SetActive(false); speedoNeedleGlow.SetActive(false); tachoNeedleGlow.SetActive(false); speedoNeedle.SetActive(true); tachoNeedle.SetActive(true); }

    }
}
