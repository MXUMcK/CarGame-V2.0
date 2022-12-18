using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyCarOnColl : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        //  destroy game object, suppose to destroy after 5 sec or x amount of  seconds but isnt working but car is destroyi
        Destroy(gameObject, 5f);
        
        
        // load active scene and use tge index of the scene!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
