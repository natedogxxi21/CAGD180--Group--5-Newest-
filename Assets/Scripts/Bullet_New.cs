using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan/Luca
public class Bullet_New : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter(Collider hitInfo)
    {

        Destroy(gameObject);

    }
}
