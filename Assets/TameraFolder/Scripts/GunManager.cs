using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float fireRate = 0.5f;
    private float fireCooldown = 0f;

    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > fireCooldown)
        {
            Shoot();
            fireCooldown = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        // Set the bullet's speed and direction
       // rb.velocity = projectileSpawnPoint.forward * projectileSpeed;

        //-Destroy(projectile, projectileLifetime); // Destroy the bullet after a certain time
    }
}
