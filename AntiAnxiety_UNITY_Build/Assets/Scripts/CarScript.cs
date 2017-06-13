using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Transform leftLane, rightLane;
    private Transform target;
    public bool laneChanged;

    public float speed;

    void Start()
    {
        laneChanged = false;
        target = leftLane;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          if (laneChanged == false)
            {
                target = rightLane;
                //this.transform.position = Vector3.MoveTowards(transform.position, rightLane.position, speed * Time.deltaTime);

              
            }

            if (laneChanged == true)
            {
                //this.transform.position = Vector3.MoveTowards(transform.position, leftLane.position, speed * Time.deltaTime);

                target = leftLane;
            }
        }
        if (transform.position == leftLane.position)
        {
            laneChanged = false;
        }

        if (transform.position == rightLane.position)
        {
            laneChanged = true;
        }
        this.transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

