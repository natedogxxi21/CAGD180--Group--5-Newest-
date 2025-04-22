using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nathan
public class Enemy : MonoBehaviour
{
    public int health = 5;

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();

        }

    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
