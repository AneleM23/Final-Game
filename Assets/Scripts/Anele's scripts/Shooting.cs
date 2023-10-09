using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject bulletPrefab;
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
        //GameObject bullet =  Instantiate(bulletPrefab, SpawnPoint.position, SpawnPoint.rotation);
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //  rb.AddForce(SpawnPoint.up * bulletForce, ForceMode2D.Impulse);

        // Calculate the direction from SpawnPoint to mouse cursor
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - (Vector2)SpawnPoint.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, SpawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force in the direction of the mouse cursor
        rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
    }


}

