using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveAndStop : MonoBehaviour {

    private Rigidbody rb;
    public GameObject player;
    public float distance;

    public bool moving;
    public bool waiting;
    public float moveTime;

	// Use this for initialization
	void Start () {
        waiting = true;
        moving = false;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        

        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (waiting && distance <= 40f)
        {
            waiting = false;
            moving = true;
        }

        if (!waiting)
        {
            if (moving)
            {

                moveTime += Time.deltaTime;
                if (moveTime >= 2.3f) { moving = false; }
                rb.AddForce(transform.forward * 5000f);

            }
            else
            {
                if (rb.velocity.magnitude > .25)
                {
                    rb.AddForce(transform.forward * -9000f);
                }
                else { rb.velocity = new Vector3(0, 0, 0); }

            }
        } else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
	}
}
