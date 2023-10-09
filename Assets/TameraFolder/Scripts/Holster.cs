using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holster : MonoBehaviour
{
    public Transform firePoint;

    private bool isPickedUp = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is with the player character.
        if (collision.CompareTag("Player") && !isPickedUp)
        {
            // Attach the gun to the player's weapon slot.
            transform.parent = firePoint;

            // Position and rotation adjustments may be needed to align the gun properly.

            // Disable the Collider (optional).
            GetComponent<Collider2D>().enabled = false;

            // Set isPickedUp to true to prevent repeated pickups.
            isPickedUp = true;
        }
    }
}
