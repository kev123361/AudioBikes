using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDoor : MonoBehaviour {
    public GameObject door;
    private Animator doorAnim;
    public GameObject player;
    public float distance;
    private PlayFX playFx;

    private bool opening = false;

    // Use this for initialization
    void Start () {
        doorAnim = door.GetComponent<Animator>();
        playFx = GetComponent<PlayFX>();
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance <= 10 && !opening)
        {
            if (!playFx.enabled) { playFx.enabled = true; }
            opening = true;
            doorAnim.SetInteger("EtatAnim", 1);
        }

    }
}
