using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public GameObject[] wheelsToRotate;
    public TrailRenderer[] trails;
    public float rotationSpeed;
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {   
        // know what direction to spin the wheels 
        float verticalA = Input.GetAxisRaw("Vertical");
        float horizontalAxis = Input.GetAxisRaw("Horizontal");

        foreach (var wheel in wheelsToRotate)
        {
            wheel.transform.Rotate(Time.deltaTime * verticalA * rotationSpeed,0,0,Space.Self);
        }

        if (horizontalAxis > 0 )
        {
            //turning right 
            anim.SetBool("left", false);
            anim.SetBool("right", true);
        } else if (horizontalAxis < 0 )
        {
            // turning left    
            anim.SetBool("right", false);
            anim.SetBool("left", true);
        }
        else
        {
            // straight 
            anim.SetBool("right", false);
            anim.SetBool("left", false);
        }

        if (horizontalAxis != 0)
        {
            foreach (var trails in trails)
            {
                trails.emitting = true;
            } 
        }

        else
        {
            foreach (var trails in trails)
            {
                trails.emitting = false;
            } 
        }
    }
}
