using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Controller : MonoBehaviour
{
    public bool pickedUp;

    public Character_Controller pickedUpBy;

    public Vector3 playerHeadpos;

    public Wall_of_Chickens wall;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        pickedUp = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.detectCollisions = !pickedUp;

        if(pickedUpBy != null && pickedUpBy.isAlive)
        {
            pickedUp = true;
        }
        else
        {
            pickedUp = false;
            pickedUpBy = null;
        }
        if(pickedUp && pickedUpBy.isAlive)
        {            
            rb.useGravity = false;
            transform.localPosition = Vector3.zero + (Vector3.up * 0.75f);
        }
        else
        {
            rb.useGravity = true;
            transform.SetParent(null);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            pickedUp = true;
            pickedUpBy = collision.gameObject.GetComponent<Character_Controller>();
            GetHead(collision.collider);

            wall.StartCoroutine(wall.ActivateWall(2));
        }
    }

    void GetHead(Collider playerCollider)
    {
        transform.SetParent(playerCollider.transform);        
        transform.localPosition = Vector3.zero + (Vector3.up * 0.75f);
    }
}
