using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ChooseClip : MonoBehaviour {
    private ChooseSoundType option;
    private AudioSource audio;

    public AudioClip low;
    public AudioClip high;
    public AudioClip voice;


	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
		try {
            option = GameObject.FindWithTag("SoundType").GetComponent<ChooseSoundType>();
            if (option.low) { audio.clip = low; }
            else if (option.high) { audio.clip = high; }
            else if (option.voice) { audio.clip = voice; }
        }catch(Exception e)
        {
            print("No Sound Option in Scene");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
