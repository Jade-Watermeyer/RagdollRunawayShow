using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_Assembly : MonoBehaviour
{
    public Wall_of_Chickens chickenWall;
    Vector3 wallPos;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {        
        wallPos = transform.localPosition;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    // Update is called once per frame
    void Update()
    {
        rb.detectCollisions = !chickenWall.activated;

        if(chickenWall.activated)
        {
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            transform.localPosition = wallPos;
        }
        else
        {
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
            rb.freezeRotation = true;
        }
    }
}
