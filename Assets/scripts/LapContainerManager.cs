using UnityEngine;
using System.Collections;


public class LapContainerManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] lapTimeContainer;

    private int currentView;

    // Use this for initialization
    void Start () {
        currentView = 0;
        StartCoroutine("ChangeLapView");

    }

    IEnumerator ChangeLapView() {

        yield return new WaitForSeconds(5f);

        while (true)
        {

            foreach (Transform child in lapTimeContainer[currentView].transform)
            {
                //child is your child transform
                child.gameObject.SetActive(false);
            }

            if (currentView == lapTimeContainer.Length - 1)
            {
                currentView = 0;
            }
            else
            {
                currentView++;
            }

            foreach (Transform child in lapTimeContainer[currentView].transform)
            {
                //child is your child transform
                child.gameObject.SetActive(true);
            }


            yield return new WaitForSeconds(5f);
        }
    }

    // Update is called once per frame
    void Update () {
	    
	}
}
