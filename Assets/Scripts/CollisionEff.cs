using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEff : MonoBehaviour
{
    public GameObject hitEffect;
    

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(hitEffect, other.GetContact(0).point, Quaternion.identity);
    }
}
