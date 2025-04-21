using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan/Luca
public class Shooting_New : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Player fired a shot");

            Shoot();

        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

    }
}

