using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject regularBulletPrefab;
    public float bulletForce = 20f;

    // Access the Bullet script directly
    public float bulletSpeedMultiplier = 1f;
    public int bulletDamageMultiplier = 1;

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
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - (Vector2)SpawnPoint.position).normalized;

        GameObject bullet = Instantiate(regularBulletPrefab, SpawnPoint.position, Quaternion.identity);
        Bullet bulletScript = bullet.GetComponent<Bullet>();

        // Modify bullet properties based on the power-up
        if (bulletScript != null)
        {
            bulletScript.speed *= bulletSpeedMultiplier;
            bulletScript.damageAmount *= bulletDamageMultiplier;
        }

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
    }


}
