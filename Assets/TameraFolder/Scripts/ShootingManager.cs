using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    public Transform pointOfFire;
    public GameObject projectilePrefab;
    public float projectileForce = 20f;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, pointOfFire.position, pointOfFire.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(pointOfFire.up * projectileForce, ForceMode2D.Impulse);


    }
}
