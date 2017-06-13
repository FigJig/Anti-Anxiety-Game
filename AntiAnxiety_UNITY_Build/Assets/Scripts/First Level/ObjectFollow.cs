using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollow : MonoBehaviour {

    public bool followPlayer;
    public Transform player;

	// Use this for initialization
	void Start () {
        followPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {

        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * 10f * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * 10f * Time.deltaTime, Space.World);

        if (followPlayer == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 1.5f * Time.deltaTime);
        }
	}
}
