using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed = 100f;

    //update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
