using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public bool isMoving;
    NavMeshAgent playerNav;
    public bool reachedDestination;
    private Vector3 temp;

    public float speed;

    GameObject brain;

    // Use this for initialization
    void Start()
    {
        playerNav = GetComponent<NavMeshAgent>();
        isMoving = false;
        reachedDestination = true;
        brain = gameObject.transform.Find("Brain").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            isMoving = true;
            reachedDestination = false;
        }

        if (Input.GetMouseButtonUp(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            isMoving = false;
        }

        if (isMoving == true)
        {
            temp = Input.mousePosition;
            temp.z = 25f; // Set this to be the distance you want the object to be placed in front of the camera, has to equal difference between camera and level.
            this.transform.position = Vector3.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(temp), speed * Time.deltaTime);
        }

        if (reachedDestination == false)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(temp), speed);
            
            if (this.transform.position == temp)
            {
                reachedDestination = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InteractableObject")
        {
            Debug.Log("hit object");
            other.gameObject.GetComponent<ObjectFollow>().followPlayer = true;
        }
    }
}
