using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishline : MonoBehaviour
{
    public Egg_Controller egg;

    public Character_Controller winner;

    public Wall_of_Chickens wall;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8 && egg.pickedUp)
        {
            print(other.ToString() + "wins");
            egg.pickedUpBy = null;
            egg.transform.SetParent(null);
            egg.transform.position = new Vector3(100, 8, 8);
            egg.pickedUp = false;
        }
    }
}
