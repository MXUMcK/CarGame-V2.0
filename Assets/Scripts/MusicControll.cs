using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControll : MonoBehaviour
{
    public static MusicControll instance;
    
    
    
    private void Awake() 
    {
        // this will stop destroying the music game object when loading other scenes 
        DontDestroyOnLoad(this.gameObject);

        if (instance == null) 
        {
            instance = this; 
        }
        else 
        
        {
            Destroy(gameObject); 
        }
    }
}
