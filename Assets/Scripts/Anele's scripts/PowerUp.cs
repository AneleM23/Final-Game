using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int healthIncrease = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // Check if the player's current health is below the maximum value
                if (playerHealth.GetCurrentHealth() < playerHealth.maxHealth)
                {
                    // Increase player's health by the specified amount
                    playerHealth.Heal(healthIncrease);

                    // Destroy the power-up object
                    Destroy(gameObject);
                }
            }
        }
    }
}
