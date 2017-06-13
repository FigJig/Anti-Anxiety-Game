using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourChange : MonoBehaviour {

	public float colourChangeDelay = 0.5f;
	public Color mycolour;
	float currentDelay = 0f;
	bool colourChangeCollision = false;

	void OnCollisionEnter() {
		Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
	}
	void checkColourChange()
	{        
		if(colourChangeCollision)
		{
			transform.GetComponent<Renderer>().material.color = mycolour;
			if(Time.time > currentDelay)
			{
				transform.GetComponent<Renderer>().material.color = Color.white;
				colourChangeCollision = false;
			}
		}
	}

	void Update()
	{
		checkColourChange();
	}
}