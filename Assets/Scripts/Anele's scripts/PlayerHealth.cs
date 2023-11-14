using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Play death animation or restart the level
        Debug.Log("Player has died.");
        Invoke("RestartGame", 3f);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthText();
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthText();
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Lives: " + currentHealth.ToString();
        }
    }

    // New method to expose current health value
    public int GetCurrentHealth()
    {
        return currentHealth;
    }


    void RestartGame()
    {
        // Assuming 0 is the index of your start scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}



