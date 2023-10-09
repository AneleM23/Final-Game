using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    GameObject target;
    public float speed, destroyTime;
    Rigidbody2D bulletRB;

    private void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(target.gameObject);
       Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
      // transform.position = Vector2.MoveTowards(transform.position, moveDir, speed * Time.deltaTime);
       bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);

        Destroy(this.gameObject, destroyTime);
    }
}
