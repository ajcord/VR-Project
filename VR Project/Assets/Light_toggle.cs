using UnityEngine;
using System.Collections;

public class Light_toggle : MonoBehaviour {

	// Use this for initialization
    public GameObject[] Lights;
	void Start () {
	if(Lights==null)
    {
        Lights = GameObject.FindGameObjectsWithTag("LIGHT");
    }
    if(Lights==null)
    {
        Debug.Log("void");
    }
        
    foreach(GameObject Light2 in Lights)
    {
        Light light1 = Light2.GetComponent<Light>();
        light1.intensity = 0;
        Debug.Log("Turn light off");

    }
	}
	
	// Update is called once per frame
	void Update () {
        if(Lights==null)
        {
            Debug.Log("Empty");
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Keydown");
            foreach (GameObject Light2 in Lights)
            {
                Light light1 = Light2.GetComponent<Light>();
                light1.intensity = 0;
                Debug.Log("Toggle light");
            }
        }
	
	}
}
