using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAt : MonoBehaviour {

    public float speed;
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;

            if (player.gameObject.GetComponent<Movement>().isMoving == true)
            {
                if (interactedObject.tag == "Ground")
                {
                    transform.LookAt(interactionInfo.point);
                }
            }
        }
    }
}
