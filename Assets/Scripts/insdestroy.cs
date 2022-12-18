using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class insdestroy : MonoBehaviour
{
    public Text test;

    private void Start()
    {
       
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Destroy(gameObject,1f);
        }
    }
}
