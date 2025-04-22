using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Ravandi, Luca
 * 4/14/2025
 * Instructions for Portal
 */

public class Portal : MonoBehaviour
{
    public Transform portalExit;

    private void OnTriggerEnter(Collider other)
    {
        Transform rootTransform = other.transform.root;

        //Resets Rigidbody
        Rigidbody rb = rootTransform.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        rootTransform.position = portalExit.position;

        Debug.Log("Teleported: " + rootTransform.name);
    }
}
//other.transform.position = portalExit.position;