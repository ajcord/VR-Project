﻿using UnityEngine;
using System.Collections;

public class light_toggle_3 : MonoBehaviour {

	// Use this for initialization
    public Light light1 = new Light();
	void Start () {
        light1 = GameObject.FindObjectOfType<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
           // light1.intensity = 0;
            light1.enabled = !light1.enabled;
        }
	}
}
