using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ChangeScene : MonoBehaviour {
    private DataTracking dataStuff;


    public GameObject mainPlayer;

    public double distance = 0.0;

    // Use this for initialization
    void Start() {
        try
        {
            dataStuff = GameObject.FindWithTag("SoundType").GetComponent<DataTracking>();
        }
        catch (Exception e)
        {
            print("No Sound Option in Scene");
        }
    }

    // Update is called once per frame
    void Update() {
        distance = Vector3.Distance(mainPlayer.transform.position, this.transform.position);
        

        
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            dataStuff.AddData(SceneManager.GetActiveScene().name + ", " + distance);
            SceneManager.LoadScene("NoCrash");
        }
    }

    private void OnTriggerEnter(Collider player) {
        if (player.gameObject.tag == "MainCamera") {
            dataStuff.AddData(SceneManager.GetActiveScene().name + ", 0");


            SceneManager.LoadScene("Crash");
        }
        
        
    }
}
