﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTracking : MonoBehaviour {

    //public string[] data;
    public List<string> data = new List<string>();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddData(string newData)
    {
        data.Add(newData);
    }
}
