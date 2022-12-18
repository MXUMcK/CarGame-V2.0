using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int countDownStart = 7;
    public Text timerUI;

    void Start()
    {

        countDownTimer();
        
        // i added this in the pause the game once level 1 starts so the timer is paused 
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
        
        
        // this will unpuase the game 
        if (Input.GetKey(KeyCode.W))
        {
            Time.timeScale = 1;
        }

        
    }
}
