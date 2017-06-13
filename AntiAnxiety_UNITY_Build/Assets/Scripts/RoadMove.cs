using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour {

    public float speed;
    public Transform startPos;

	void Update () {      
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            // transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "RoadReset")
        {
            transform.position = startPos.transform.position;
        }
    }
}
