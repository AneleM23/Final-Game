using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float speed;
    public float lineOfSight;
    public float ShootingLineOfSight;
    public float fireRate = 1.5f;
    private float reloadTime;
    public GameObject enemyBullet;
    public GameObject enemyBulletParent;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if (distanceFromPlayer < lineOfSight && distanceFromPlayer > ShootingLineOfSight)
        {
            Debug.Log("Moving towards player");
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= ShootingLineOfSight && reloadTime < Time.time)
        {
            Debug.Log("Shooting at player");
            Instantiate(enemyBullet, enemyBulletParent.transform.position, Quaternion.identity);
            reloadTime = Time.time + fireRate;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
        Gizmos.DrawWireSphere(transform.position, ShootingLineOfSight);
    }

}
