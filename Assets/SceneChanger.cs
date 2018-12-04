using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public bool isMoving;
    private string[] scenes = { "BrakingCar", "CarDoor", "CarDoor 1", "CarFromLeft", "CarFromLeft 1", "CarFromRight", "LeftTurn"};

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetAxisRaw("Fire1") != 0 || Input.GetKeyDown("space")) {
            // choose random
            SceneManager.LoadScene(scenes[(int)Random.Range(0, 7)]);
            Debug.Log("pressed");
        }
	}
}
