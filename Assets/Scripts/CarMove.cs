using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {
    private Rigidbody rb;
    private bool waiting = true;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	

    void Update()
    {
        if (!waiting) {
            rb.AddForce(transform.forward * 5000f);
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetAxisRaw("Fire1") != 0) { waiting = false; }
	}
}
