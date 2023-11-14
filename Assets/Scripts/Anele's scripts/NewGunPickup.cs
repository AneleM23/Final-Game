using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGunPickup : MonoBehaviour
{
    public float speedMultiplier = 2f; // You can adjust this value for the speed increase
    public int damageMultiplier = 2;   // You can adjust this value for the damage increase

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyPowerUp(other.gameObject);
            Destroy(gameObject);
        }
    }

    void ApplyPowerUp(GameObject player)
    {
        // Get the Bullet component from the player's Bullet script
        Bullet bulletScript = player.GetComponent<Bullet>();

        if (bulletScript != null)
        {
            // Apply speed and damage multipliers to the bullet
            bulletScript.speed *= speedMultiplier;
            bulletScript.damageAmount *= damageMultiplier;
        }
    }

}

