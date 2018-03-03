using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollector : MonoBehaviour {

    public bool hasBall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReceiveBall()
    {
        hasBall = true;
    }
}
