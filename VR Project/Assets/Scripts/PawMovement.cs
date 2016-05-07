using UnityEngine;
using System.Collections;

public class PawMovement : MonoBehaviour {

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
    }

    void Update()
    {
        if(Input.GetButton("X"))
        {
            //start = transform.parent.position + initialLocation;
            start = transform.position;
            endpoint = start;
            endpoint += transform.parent.forward;
            run = true;
            startTime = Time.time;
        }
        if (run)
        {
            transform.position = Vector3.Lerp(start, endpoint,
                Mathf.SmoothStep(0f, pawLength,
                Mathf.PingPong((Time.time - startTime) / secondsForOneLength * 2, 1f)
                ));
            if (Time.time > startTime + secondsForOneLength)
            {
                transform.position = start;
                run = false;
            }
        }
        // added to reset start pos
        if (!run)
        {
            transform.localPosition = defPos;
        }
    }
}
