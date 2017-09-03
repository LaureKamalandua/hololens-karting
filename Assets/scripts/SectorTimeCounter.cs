using UnityEngine;
using System.Collections;

public class SectorTimeCounter : MonoBehaviour {

    public Color fasterColor;
    public Color slowerColor;

    public float fastestLapSector1Time;
    public float fastestLapSector2Time;
    public float fastestLapSector3Time;

    public float currentLapSector1Time;
    public float currentLapSector2Time;
    public float currentLapSector3Time;

	// Use this for initialization
	void Start () {
        fastestLapSector1Time = 0f;
        fastestLapSector2Time = 0f;
        fastestLapSector3Time = 0f;

        currentLapSector1Time = 0f;
        currentLapSector2Time = 0f;
        currentLapSector3Time = 0f;

        fasterColor = Color.green;
        slowerColor = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
