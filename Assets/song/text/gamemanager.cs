﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{


    public float timer;
    public float loadtime;

    public bool start= false;


    public Text button;
    public Text  second;
    public Text loadtimer;

    public Image confilmImage;

    public List<Text> timelist = new List<Text>();

    // Start is called before the first frame update
    void Start()
    {
       // second = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        watch();
        buttonpush();


        
        
    }

    public void timestart()
    {
        if (!start)
            start = true;
        else if (start)
            start = false;
    }

    public void confilm()
    {
        if (!start)
            confilmImage.gameObject.SetActive(true);
    }

    public void timereset()
    {
        timer = 0;
        second.text = "00";
    }


    void watch()
    {
        if (start)
        {
            timer += Time.deltaTime;
            if (timer >= 10f)
                second.text = timer.ToString("F0");

            else if (timer < 10f)
                second.text = "0" + timer.ToString("F0");

            if (timer > 60)
                second.text = (timer - 60f).ToString();

        }
    }

   public void timesave()
    {
        for (int i = 0; i < timelist.Count; i++)
            PlayerPrefs.SetString("timer", timelist[i].ToString());
    }

    public void timeload()
    {
        loadtime = PlayerPrefs.GetFloat("timer".ToString());
        loadtimer.text = loadtime.ToString();
    }


    void buttonpush()
    {
        if (start)
        {
            button.text = "stop";
        }
        if (!start)
            button.text = "start";
    }

}