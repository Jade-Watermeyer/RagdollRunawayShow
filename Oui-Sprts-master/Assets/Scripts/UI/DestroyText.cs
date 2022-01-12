using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DestroyText : MonoBehaviour
{
    public float timeStart = 5;
    public Text textBox;

    public GameObject startSound;
    public GameObject timerText;

    private GameObject destroyText;

    // Start is called before the first frame update
    void Start()
    {
   
        textBox.text = timeStart.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;

        

        if (timeStart <= 5)
        {
            textBox.text = "Get Ready!";
            startSound.SetActive(true);
        }

        if (timeStart <= 4)
        {
            textBox.text = "Get Set!";
        }

        if (timeStart <= 3)
        {
            textBox.text = "Deep Breath";
        }

        if (timeStart <= 2)
        {
            textBox.text = "Start!";

            timerText.SetActive(true);

        }

        if (timeStart <= 0)
        {
            timeStart = 0.0f;
            textBox.text = " ";
        }

        
    }
}
