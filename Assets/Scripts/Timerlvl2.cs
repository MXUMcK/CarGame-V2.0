using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timerlvl2 : MonoBehaviour
{
    private int countDownStart = 10;
    public Text timerUI;

    void Start()
    {
        countDownTimer();
        Time.timeScale = 0;
    }

    void countDownTimer()
    {

        if (countDownStart > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStart);
            timerUI.text = "Timer: " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStart--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }




    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Time.timeScale = 1;
        }
    }
}
