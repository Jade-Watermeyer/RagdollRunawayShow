using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour
{
    public GameObject main;
    public GameObject the;
    public GameObject runaway;
    public GameObject ragdoll;
    public GameObject show;

    public GameObject main1;
    public GameObject the1;
    public GameObject runaway1;
    public GameObject ragdoll1;
    public GameObject show1;

    public float timer = 0;
    public float off;
    public float on;
    public float off1;
    public float theOn;
    public float runawayOn;
    public float ragdollOn;
    public float showOn;
    public float repeat;

    private bool a = false;
    private bool b = false;
    private bool c = false;
    private bool d = false;
    private bool e = false;
    private bool f = false;
    private bool g = false;


    // Start is called before the first frame update
    void Start()
    {
        main1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= off && a == false)
        {
            main.SetActive(false);
            main1.SetActive(true);

            the1.SetActive(true);
            runaway1.SetActive(true);
            ragdoll1.SetActive(true);
            show1.SetActive(true);

            a = true;
        }

        if (timer >= on && b == false)
        {
            main.SetActive(true);
            main1.SetActive(false);
            b = true;
        }

        if (timer >= off1 && c == false)
        {
            main.SetActive(false);
            main1.SetActive(true);
            c = true;
        }

        if (timer >= theOn && d == false)
        {
            main.SetActive(true);

            the.SetActive(true);
            runaway.SetActive(false);
            ragdoll.SetActive(false);
            show.SetActive(false);

            the1.SetActive(false);
            runaway1.SetActive(true);
            ragdoll1.SetActive(true);
            show1.SetActive(true);

            d = true;
        }

        if (timer >= runawayOn && e == false)
        {
            main.SetActive(true);

            the.SetActive(true);
            runaway.SetActive(true);
            ragdoll.SetActive(false);
            show.SetActive(false);

            the1.SetActive(false);
            runaway1.SetActive(false);
            ragdoll1.SetActive(true);
            show1.SetActive(true);

            e = true;
        }

        if (timer >= ragdollOn && f == false)
        {
            main.SetActive(true);

            the.SetActive(true);
            runaway.SetActive(true);
            ragdoll.SetActive(true);
            show.SetActive(false);

            the1.SetActive(false);
            runaway1.SetActive(false);
            ragdoll1.SetActive(false);
            show1.SetActive(true);

            f = true;
        }

        if (timer >= showOn && g == false)
        {
            main.SetActive(true);

            the.SetActive(true);
            runaway.SetActive(true);
            ragdoll.SetActive(true);
            show.SetActive(true);

            the1.SetActive(false);
            runaway1.SetActive(false);
            ragdoll1.SetActive(false);
            show1.SetActive(false);

            g = true;
        }

        if (timer >= repeat)
        {
            timer = 0;

            a = false;
            b = false;
            c = false;
            d = false;
            e = false;
            f = false;
            g = false;
        }
    }
}
