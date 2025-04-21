using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Projectile Variables")]
    public float speed;
    public bool goingleft;


    // Update is called once per frame
    void Update()
    {
        if (goingleft == true)
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        else
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }

    }
}

