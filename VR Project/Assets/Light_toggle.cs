using UnityEngine;
using System.Collections;

public class Light_toggle : MonoBehaviour {

	// Use this for initialization
    public Light[] Lights = new Light[10];
	void Start () {
	if(Lights==null)
    {
       // Lights = GameObject.FindGameObjectsWithTag("LIGHT");
        Lights = GameObject.FindObjectsOfType<Light>();
    }
    
        
  /*  foreach(GameObject Light2 in Lights)
    {
        Light light1 = Light2.GetComponent<Light>();
        light1.intensity = 0;
        Debug.Log("Turn light off");

    } */
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
            //GameObject Light2 = Lights[0];
            //Light light1 = Light2.GetComponent<Light>();
            //light1.intensity = 0;
            Lights[0].intensity = 0;
                Debug.Log("Toggle");
        }
	
	}
}
