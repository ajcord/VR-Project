using UnityEngine;
using System.Collections;

public class StartArea : MonoBehaviour {

    Camera StartCamera;
    GameObject title;
    GameObject subtitle;

    // Use this for initialization
    void Start () {
        StartCamera = gameObject.GetComponent<Camera>();
        title = GameObject.Find("Title");
        subtitle = GameObject.Find("Subtitle");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("A"))
        {
            StartCamera.enabled = false;
            title.SetActive(false);
            subtitle.SetActive(false);
        }
    }
}
