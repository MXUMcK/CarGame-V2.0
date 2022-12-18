using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    
    //  i used the same structor as start screen 
    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void ExitButton()
    {
        SceneManager.LoadScene("Start");
    }
}
