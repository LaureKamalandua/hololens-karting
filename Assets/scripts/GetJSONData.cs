// Importing all of the libraries
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

// Defines the structure of the JSON data
public class JSONDataObject
{
    public decimal speed { get; set; }
    public int position { get; set; }
    public int circuit_distance { get; set; }
    public string circuit_name { get; set; }
    public int circuit_racers { get; set; }
    public string circuit_coordinates { get; set; }
}

// Contains updated data for every 60 frames per second from the HTTP request to the API
public static class DataProvider
{
    public static JSONDataObject currentData = null;
}

// Submits a request at every frame to retrieve the data from the API and send the output to the DataProvider class
public class GetJSONData : MonoBehaviour
{ 
    private int framecount = 0;
    private void updateData()
    {
        Debug.Log("GetJSONData has updated the data");
        string url = "http://hololens-karting.westeurope.cloudapp.azure.com/coronel";
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
    }

    public IEnumerator WaitForRequest(WWW www)
    {
        yield return www;
        if (www.error == null)
        {
            // Sends the HTTP response in the proper JSON format to the DataProvider class
            DataProvider.currentData = FormatJSONDataObject(www.text)[0];
        }
        else
        {
            // Debug.Log(www.error);
        }
    }

    // Deserializes the output from the HTTP request to the right JSON format
    static public List<JSONDataObject> FormatJSONDataObject(string input)
    {
        List<JSONDataObject> result = new List<JSONDataObject>();
        List<Dictionary<string, string>> itemList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(input);
        foreach (Dictionary<string, string> item in itemList)
        {
            foreach (KeyValuePair<string, string> kvp in item)
            {
                string key = kvp.Key;
                string val = null;
                item.TryGetValue(key, out val);
                List<JSONDataObject> dataObj = JsonConvert.DeserializeObject<List<JSONDataObject>>(val);
                result.AddRange(dataObj);
            }
        }
        return result;
    }

    public void Update()
    {
        //updateData();
        /*
        this.framecount++;
        if (this.framecount % 60 == 0)
        {
            updateData();
        }
        */
    }
}