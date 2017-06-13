using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Rigidbody rb;
    public float thrust;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnMouseDown()
    {
        rb.AddForce(transform.forward * thrust);
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // Vector3 dir = gameObject.transform.position - mousePos;
        //rb.AddForce(dir.normalized * thrust, ForceMode.Impulse);
    }
}
