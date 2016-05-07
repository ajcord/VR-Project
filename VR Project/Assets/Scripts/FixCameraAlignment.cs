using UnityEngine;
using System.Collections;

public class FixCameraAlignment : MonoBehaviour {

    GameObject ts;

	// Use this for initialization
	void Start () {
        ts = GameObject.Find("TrackingSpace");
        Vector3 vec = ts.GetComponent<Transform>().position;
        vec.y -= 1.4f;
        ts.transform.position = vec;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
