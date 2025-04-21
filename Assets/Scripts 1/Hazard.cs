using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Controller>())
        {
            collision.gameObject.GetComponent<Controller>().Damaged();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Controller>())
        {
            other.gameObject.GetComponent<Controller>().Damaged();
        }
    }

}

