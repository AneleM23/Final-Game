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

    // Update is called once per frame
   private void Update()
    {
      //  if (currentHealth <= 0)
       // {
        //    Destroy(gameObject);   
        //}

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(bulletDamage);
        }
    }

}
