using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Wall_of_Chickens : MonoBehaviour
{
    public bool activated;

    public Egg_Controller egg;

    public float moveSpeed = 0.5f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        activated = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!egg.pickedUp)
        {
            activated = false;
        }

        rb.detectCollisions = activated;
        rb.useGravity = activated;
        
        if(activated)
        {
            transform.position = Vector3.MoveTowards(transform.position, egg.pickedUpBy.transform.position, moveSpeed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            collision.gameObject.GetComponent<Character_Controller>().isAlive = false;
        }
    }

    public IEnumerator ActivateWall(float time)
    {
        yield return new WaitForSeconds(time);
        activated = true;
    }
}
