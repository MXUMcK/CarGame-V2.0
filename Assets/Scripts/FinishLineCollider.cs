using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineCollider : MonoBehaviour
{
    // so we can change the scene in the GUI
    
    public string sceneName;
  private void OnCollisionEnter(Collision collision)
  {
      SceneManager.LoadScene(sceneName);

  }
}
