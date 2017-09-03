using System;
using UnityEngine;
using System.Collections;
using Assets.Scripts.Utilities;

public class SpeedObject : Singleton<SpeedObject> {

    private Vector3 lastPos;
    private DateTime lastTime;
    public float speed { get; private set; }

	// Use this for initialization
	void Start ()
	{
        lastPos = transform.position;
        InvokeRepeating("Tick", 0, 0.5f);
	}

    void Tick()
    {
        Vector3 postition = transform.position;
        float distance = Vector3.Distance(lastPos, postition);
        speed = (distance / 0.5f) * 3.6f;
        lastPos = postition;
    }
}
