using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class gauge : MonoBehaviour {

    public GameObject gauge1;
    public GameObject gauge2;
    public GameObject gauge3;
    public GameObject gauge4;
    public enum selectGauge { Gauge1, Gauge2, Gauge3, Gauge4};
    public selectGauge gaugeSelect;


    void Start () {
	
	}

	void Update () {
        GaugeSelect(gaugeSelect);


    }

    void GaugeSelect(selectGauge gaugeSelect)
    {
        if (gaugeSelect == selectGauge.Gauge1) { gauge1.SetActive(true); gauge2.SetActive(false); gauge3.SetActive(false); gauge4.SetActive(false); }
        if (gaugeSelect == selectGauge.Gauge2) { gauge1.SetActive(false); gauge2.SetActive(true); gauge3.SetActive(false); gauge4.SetActive(false); }
        if (gaugeSelect == selectGauge.Gauge3) { gauge1.SetActive(false); gauge2.SetActive(false); gauge3.SetActive(true); gauge4.SetActive(false); }
        if (gaugeSelect == selectGauge.Gauge4) { gauge1.SetActive(false); gauge2.SetActive(false); gauge3.SetActive(false); gauge4.SetActive(true); }
    }
}
