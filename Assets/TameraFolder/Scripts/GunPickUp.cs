using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public GunManager gunToPickup;
    public PlayerController playerController;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.EquipGun(gunToPickup);
                this.gameObject.SetActive(false);

                Debug.Log("Collided");
            }
        }
    }

}
