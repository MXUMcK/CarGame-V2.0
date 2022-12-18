using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnColl : MonoBehaviour
{
    // Start is called before the first frame update
    public void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "big_cone")
        {
            Destroy(collision.gameObject);
        }
    }
}
