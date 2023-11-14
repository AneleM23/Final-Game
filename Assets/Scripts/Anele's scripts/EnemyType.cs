using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyType : MonoBehaviour
{
    public string destinationSceneName;
    public Vector3 destinationPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        // Set the player's position to the destination position
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = destinationPosition;

        // Load the destination scene
        SceneManager.LoadScene(destinationSceneName);
    }

}
