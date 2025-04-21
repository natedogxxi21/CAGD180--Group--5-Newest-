using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Projectile Variables")]
    public float speed;
    public bool shooting;


    // Update is called once per frame
    void Update()
    {
        if (shooting == true )
            //And Player is facing Left) 
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        if (shooting == true )
            //And Player is facing Right)
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }

    }

}

