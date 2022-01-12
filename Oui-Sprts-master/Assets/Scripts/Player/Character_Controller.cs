using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : MonoBehaviour
{

    public float maxSpeed;
    public float jumpHeight;
    public float gravity;

    public bool isAlive;
    public bool isMoving;
    public bool isGrounded;

    private Rigidbody rb;

    private Collider maincoll;

    public LayerMask groundLayer;

    private Transform t;

    public Vector2 axisValues;

    private Vector3 newVelocity;

    private RespawnManager respawnPos;

    private MeshRenderer mesh;

    public float respawntime;

    private void Start()
    {
        t = transform;

        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.useGravity = true;

        maincoll = GetComponent<Collider>();

        mesh = GetComponent<MeshRenderer>();

        gameObject.layer = 8;
    }

    void Update()
    {
        rb.detectCollisions = isAlive;
        mesh.enabled = isAlive;

        if(respawnPos == null)
        {
            respawnPos = FindObjectOfType<RespawnManager>();
        }

        if(isAlive)
        {
            if (isGrounded && rb.velocity.y < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            }

            newVelocity = new Vector3(axisValues.x, 0, axisValues.y);

            if (newVelocity != Vector3.zero)
            {
                gameObject.transform.forward = newVelocity;
            }
        }
        else
        {
            respawnPos.StartCoroutine(respawnPos.RespawnPlayer(this, respawntime));
        }
    }

    private void FixedUpdate()
    {
        Bounds colliderbounds = maincoll.bounds;
        Vector3 groundcheckpos = colliderbounds.min + new Vector3(colliderbounds.size.x * 0.5f, 0.1f, 0);

        isGrounded = Physics.Raycast(groundcheckpos, Vector3.down, 0.5f, groundLayer);

        rb.velocity = new Vector3(newVelocity.x * maxSpeed, rb.velocity.y - gravity, newVelocity.z * maxSpeed);

        Debug.DrawLine(groundcheckpos, groundcheckpos - new Vector3(0, 0.23f, 0), isGrounded ? Color.green : Color.red);
    }

    #region
    private void OnJump()
    {
        if(isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
    }

    private void OnMovement(InputValue value)
    {
        axisValues = value.Get<Vector2>();
    }
    #endregion
}
