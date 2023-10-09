using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damageAmount = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject otherGameObject = collision.gameObject;

        if (otherGameObject.CompareTag("Enemy"))
        {
             EnemyHealthSystem enemy = collision.gameObject.GetComponent<EnemyHealthSystem>();

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

