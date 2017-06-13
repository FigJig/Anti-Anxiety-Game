using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInAudio : MonoBehaviour {

    AudioSource BGM;
    public float maxVolume;

	// Use this for initialization
	void Start () {
        BGM = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        BGM.volume += 0.4f * Time.deltaTime;

        if (BGM.volume >= maxVolume)
        {
            BGM.volume = maxVolume;
            gameObject.GetComponent<FadeInAudio>().enabled = false;
        }
	}
}
