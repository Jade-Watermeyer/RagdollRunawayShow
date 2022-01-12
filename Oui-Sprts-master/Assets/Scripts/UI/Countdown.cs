using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeStart = 25;
    public Text textBox;

    public GameObject panel1;

    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
        textBox.text = timeStart.ToString();

        sound.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if(timeStart <= 0)
        {
            timeStart = 0.0f;
            panel1.SetActive(true);
            
            sound.SetActive(true);
        }

        
    }
}
