using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan/Luca
public class Shooting_New : MonoBehaviour
{

    public Transform firePoint;
    public GameObject currentBulletPrefab;

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
        Instantiate(currentBulletPrefab, firePoint.position, firePoint.rotation);

    }

    public void SetBulletType(GameObject newBulletPrefab)
    {
        currentBulletPrefab = newBulletPrefab;
        Debug.Log("Bullet type changed to: " + newBulletPrefab.name);
    }
}
