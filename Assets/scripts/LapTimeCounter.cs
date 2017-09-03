using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapTimeCounter : MonoBehaviour {

    [SerializeField]
    private Text lapTime;

    public float currentTime;

	// Use this for initialization
	void Start () {
        currentTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        //if (DataProvider.currentData == null)
        //{
        //    lapTime.text = "...";
        //}
        //else
        //{
        //    string counterDataInt = System.Convert.ToString((DataProvider.currentData.position));
        //    lapTime.text = counterDataInt;

        //}

        // Update lap time
        currentTime += Time.deltaTime;
        lapTime.text = currentTime.ToString("n2");

    }
}
