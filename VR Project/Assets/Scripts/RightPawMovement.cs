using UnityEngine;
using System.Collections;

public class RightPawMovement : MonoBehaviour
{

    public Transform farEnd;
    private Vector3 defPos;
    private Vector3 start;
    private Vector3 endpoint;
    private Vector3 initialLocation;
    public float pawLength = 0.4f;
    private float secondsForOneLength = 1.0f;
    private bool run;
    private float startTime;

    void Start()
    {
        initialLocation = transform.position - transform.parent.position;
        defPos = transform.localPosition;
        run = false;
        GetComponent<MeshRenderer>().enabled = false;
    }

    void Update()
    {
        if (run)
        {
            GetComponent<MeshRenderer>().enabled = true;
            transform.position = Vector3.Lerp(start, endpoint,
                Mathf.SmoothStep(0f, pawLength,
                Mathf.PingPong((Time.time - startTime) / secondsForOneLength * 2, 1f)
                ));
            if (Time.time > startTime + secondsForOneLength)
            {
                transform.position = start;
                run = false;
                GetComponent<MeshRenderer>().enabled = false;
            }
        }
        else
        {
            //reset the start position
            transform.localPosition = defPos;

            //Only check for the trigger if we are not already running
            if (Input.GetAxis("RightTrigger") == 1)
            {
                //start = transform.parent.position + initialLocation;
                start = transform.position;
                endpoint = start;
                endpoint += transform.parent.forward;
                run = true;
                startTime = Time.time;
            }
        }
    }
}
