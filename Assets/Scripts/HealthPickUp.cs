using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Ravandi, Luca
 * 4/18/2025
 * Instructions for health pack
 */
public class HealthPickUp : MonoBehaviour
{
    public float rotSpeed = 1;
    public int health;
    private void Update()
    {
        transform.Rotate(0, rotSpeed, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Controller>())
        {
            other.GetComponent<Controller>().health += 15;
            Destroy(gameObject);
        }
    }
}

