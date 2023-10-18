using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damageAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {

        GameObject otherGameObject = other.gameObject;

        if (otherGameObject.CompareTag("Enemy"))
        {
             EnemyHealthSystem enemy = other.gameObject.GetComponent<EnemyHealthSystem>();

           if (enemy != null)
            {
                 enemy.TakeDamage(damageAmount);
            }

            Destroy(gameObject);
       }
        else if (!otherGameObject.CompareTag("Player"))
        {
           Destroy(gameObject);
       }
    }

}

