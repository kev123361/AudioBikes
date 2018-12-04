using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Rigidbody rb;

    public bool isMoving;
    public float topSpeed;
    public float currSpeed;

    private bool isAxisInUse;
	// Use this for initialization
	void Start () {
        isMoving = false;
        isAxisInUse = false;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        currSpeed = rb.velocity.x;
        if (Input.GetAxisRaw("Fire1") != 0)
        {
            if (!isAxisInUse)
            {
                isMoving = !isMoving;
                isAxisInUse = true;
            }
        } else { isAxisInUse = false; }


        if (isMoving)
        {
            rb.AddForce(new Vector3(-1, 0, 0) * 3f);
            if (rb.velocity.x < -topSpeed)
            {
                rb.velocity = new Vector3(-topSpeed, 0, 0);
            }
        } else
        {
            if (rb.velocity.x < 0f)
            {
                rb.AddForce(new Vector3(-1, 0, 0) * -18f);
            }
            else { rb.velocity = new Vector3(0, 0, 0); }
        }
	}


}
