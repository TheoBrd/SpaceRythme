using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedPlanet : MonoBehaviour
{
 

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            Destroy(collision.gameObject);
        }

    }
}
