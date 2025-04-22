using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan
public class HeavyBullets : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 3;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter(Collider hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);

    }
}
