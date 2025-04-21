using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Projectile Variables")]
    public bool shooting = true;
    //Changed "going left" to "shooting"
    [Header("Spawner Variables")]
    public GameObject projectilePrefab;
    public float timeBetweenShots;


    // Start is called before the first frame update
    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            if (projectile.GetComponent<Bullet>())
            {
                projectile.GetComponent<Bullet>().shooting = shooting;
                //timeBetweenShots
                //Disable hold down space bar for a longgg shot
            }

        }
    }
}

