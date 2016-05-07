using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {


    float pushPower = 5.0f;
    Rigidbody body;
    Vector3 force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic) { return; }

        if (hit.moveDirection.y < -0.3)
        {
            force = new Vector3(0, -0.5f, 0) * 10.0f * body.mass;
        } else
        {
            force = hit.controller.velocity * pushPower;
        }

        body.AddForceAtPosition(force, hit.point);

    }
}
