using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int maxLives = 3;   
    public int currentHealth;   
    public int bulletDamage = 1;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxLives;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(bulletDamage);
            Destroy(other.gameObject); // Destroy the bullet
        }
    }
}
