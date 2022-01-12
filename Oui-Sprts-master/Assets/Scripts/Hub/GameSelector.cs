using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelector : MonoBehaviour
{
    public LayerMask wheellayer;

    public RaycastHit hit;

    public LoadScene chosengame;

    public SpinningWheel wheel;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out hit, wheellayer))
        {
            chosengame = hit.collider.GetComponent<LoadScene>();

            if(!wheel.isSpinning)
            {
                print(chosengame.ToString());
            }   
        }
    }
}
