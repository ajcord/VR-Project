using UnityEngine;
using System.Collections;

public class ControllerInputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("X"))
        {
            Debug.Log("X was pressed");
        }
        if (Input.GetButtonDown("Y"))
        {
            Debug.Log("Y was pressed");
        }
        if (Input.GetButtonDown("A"))
        {
            Debug.Log("A was pressed");
        }
        if (Input.GetButtonDown("B"))
        {
            Debug.Log("B was pressed");
        }
        if (Input.GetAxis("LeftJoystickX") != 0)
        {
            Debug.Log("LeftJoystickX: " + Input.GetAxis("LeftJoystickX"));
        }
    }
}
