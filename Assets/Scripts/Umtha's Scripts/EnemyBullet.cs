using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    GameObject target;
    public float speed, destroyTime;
    Rigidbody2D bulletRB;
    public int damageAmount = 2; // Change the damage amount here

    private void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(target.gameObject);

        Destroy(this.gameObject, destroyTime);

        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);

        Destroy(this.gameObject, destroyTime);
    }

    // If the bullet collides with the player, deal damage
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
            Destroy(this.gameObject);
        }
    }
}



