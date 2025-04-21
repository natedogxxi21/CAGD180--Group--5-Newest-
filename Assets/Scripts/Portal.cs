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
        other.transform.position = portalExit.position;
    }
}