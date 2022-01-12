using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningWheel : MonoBehaviour
{
    public Transform t;
    public float rotatespeed;

    public bool isSpinning;

    // Start is called before the first frame update
    void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        t.Rotate(Vector3.forward * rotatespeed * Time.deltaTime);
    }
}
