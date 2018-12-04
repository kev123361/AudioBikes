using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFX : MonoBehaviour {

    private AudioSource audio;
    public GameObject player;
    private bool played = false;
    public float distance;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance <= 25 && !played)
        {
            played = true;
            audio.Play();
        }
    }
}
