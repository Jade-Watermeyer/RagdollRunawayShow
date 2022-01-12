using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyLights : MonoBehaviour
{
    public GameObject off1;
    public GameObject off2;
    public GameObject off3;
    public GameObject off4;
    public GameObject off5;
    public GameObject off6;
    public GameObject off7;
    public GameObject off8;
    public GameObject off9;

    public GameObject on1;
    public GameObject on2;
    public GameObject on3;
    public GameObject on4;
    public GameObject on5;
    public GameObject on6;
    public GameObject on7;
    public GameObject on8;
    public GameObject on9;

    public float timer = 0;

    private bool a = false;
    private bool b = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f && a == false)
        {
            off1.SetActive(false);
            off2.SetActive(false);
            off3.SetActive(false);
            off4.SetActive(false);
            off5.SetActive(false);
            off6.SetActive(false);
            off7.SetActive(false);
            off8.SetActive(false);
            off9.SetActive(false);

            on1.SetActive(true);
            on2.SetActive(true);
            on3.SetActive(true);
            on4.SetActive(true);
            on5.SetActive(true);
            on6.SetActive(true);
            on7.SetActive(true);
            on8.SetActive(true);
            on9.SetActive(true);

            a = true;
        }

        if (timer >= 2f && b == false)
        {
            off1.SetActive(true);
            off2.SetActive(true);
            off3.SetActive(true);
            off4.SetActive(true);
            off5.SetActive(true);
            off6.SetActive(true);
            off7.SetActive(true);
            off8.SetActive(true);
            off9.SetActive(true);

            on1.SetActive(false);
            on2.SetActive(false);
            on3.SetActive(false);
            on4.SetActive(false);
            on5.SetActive(false);
            on6.SetActive(false);
            on7.SetActive(false);
            on8.SetActive(false);
            on9.SetActive(false);

            timer = 0;
            a = false;
        }
    }
}
