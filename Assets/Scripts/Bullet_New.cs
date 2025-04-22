using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan/Luca
public class Bullet_New : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 1; //Bullet does 1 damage
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter(Collider collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        Debug.Log("Bullet hit something: ");
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);

    }
}

