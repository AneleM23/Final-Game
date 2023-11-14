using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 10f;
    public float projectileLifetime = 2f;

    void Start()
    {
        // Destroy the bullet after a certain time
        Destroy(gameObject, projectileLifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Handle bullet collision with other objects/enemies if needed
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Deal damage or apply other logic
        }

        // Destroy the bullet on collision
        Destroy(gameObject);
    }
}
