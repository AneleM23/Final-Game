using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueEnemyShoot : MonoBehaviour
{

    public float speed;
    public float stopDistance;
    public float retreatDistance;

    private float reloadRate;
    public float reloadTimer;

    public GameObject projectile;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        reloadRate = reloadTimer;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, player.position) < stopDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if (reloadRate <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            reloadRate = reloadTimer;
        }
        else
        {
            reloadRate -= Time.deltaTime;
        }
    }
}