using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingNew : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject newBulletPrefab;
    public float bulletForce = 20f;

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

        GameObject bullet = Instantiate(newBulletPrefab, SpawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
    }
}
