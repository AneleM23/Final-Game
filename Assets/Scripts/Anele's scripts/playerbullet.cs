using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullet : MonoBehaviour

{
    public int damageAmount = 3;
    public float speed, destroyTime;

    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
        Destroy(this.gameObject, destroyTime);
    }

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

