using UnityEngine;
using System.Collections;

public class StartArea : MonoBehaviour {

    Camera StartCamera;
    GameObject title;
    GameObject subtitle;
    GameObject player;

    // Use this for initialization
    void Start () {
        StartCamera = gameObject.GetComponent<Camera>();
        player = GameObject.Find("OVRPlayerController");
        player.SetActive(false);
        title = GameObject.Find("Title");
        subtitle = GameObject.Find("Subtitle");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("A"))
        {
            player.SetActive(true);
            StartCamera.enabled = false;
            title.SetActive(false);
            subtitle.SetActive(false);
        }
    }
}
