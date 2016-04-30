using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {

    float speed = 10f;
    GameObject cat;
	// Use this for initialization
	void Start () {
        cat = GameObject.FindGameObjectWithTag("spincat");
	}
	
	// Update is called once per frame
	void Update () {
        cat.transform.Rotate(cat.GetComponent<Transform>().up, speed * Time.deltaTime);
	}
}
