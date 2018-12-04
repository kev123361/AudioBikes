using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveAndRightTurn : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject player;
    public float distance;
    private DriveState state;

    public enum DriveState {Waiting, Driving, Turning, Speeding };

    public bool moving;
    public bool waiting;
    public float moveTime;

    // Use this for initialization
    void Start()
    {
        state = DriveState.Waiting;
        waiting = true;
        moving = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (state == DriveState.Waiting && distance <= 50f)
        {
            state = DriveState.Driving;
        } else if (state == DriveState.Waiting) { rb.velocity = new Vector3(0, 0, 0); }
        else if (state == DriveState.Driving)
        {

            moveTime += Time.deltaTime;
            if (moveTime >= 1.8f) {
                state = DriveState.Turning;
                moveTime = 0f;
            }
            rb.AddForce(transform.forward * 5000f);

        }
        else if (state == DriveState.Turning)
        {
            moveTime += Time.deltaTime;
            if (moveTime >= .5f)
            {
                state = DriveState.Speeding;
                rb.velocity = new Vector3(0, 0, 0);
            }


            rb.AddForce(transform.forward * -5000f);
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, 180, 0) * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
           
        }
        else if (state == DriveState.Speeding)
        {
            
            rb.AddForce(transform.forward * 9000f);
        }
        
        
    }
}
