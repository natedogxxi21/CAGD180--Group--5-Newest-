using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBulletPickUp : MonoBehaviour
{
    public GameObject bulletType;
    public float rotSpeed = 1;


    private void Update()
    {
        transform.Rotate(rotSpeed, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        Shooting_New shooter = other.GetComponent<Shooting_New>();
        if (shooter != null)
        {
            shooter.SetBulletType(bulletType);
            Destroy(gameObject);
        }
    }


    
}
