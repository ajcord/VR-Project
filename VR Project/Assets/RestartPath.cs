using UnityEngine;
using System.Collections;
using UnitySteer.Attributes;
using UnitySteer.Tools;
using UnitySteer.Behaviors;

public class RestartPath : MonoBehaviour {

    GameObject vehicle;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameObject.Find("Wanderer").GetComponent<AutonomousVehicle>().Speed <= 0.001f) {
            Vector3 start = new Vector3(-0.75f, 0.05f, 0.5f);
            GameObject.Find("Wanderer").transform.position = start;
        }
	}
}
