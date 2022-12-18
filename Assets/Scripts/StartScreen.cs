using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{   
    // restart level 
    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitButton()
    {
        // had to wrap this code in if statements or it was given me errors,
        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif

    }
    
    public void Info()
    {
        SceneManager.LoadScene("Info");
    }
}