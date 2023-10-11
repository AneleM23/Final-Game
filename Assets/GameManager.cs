using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Public variable to set the number of enemies needed
    public int enemyCount; 
    public GameObject sceneChangerObject;
    // Private variable to keep track of the current number of enemies
    private int currentEnemyCount;

    private void Start()
    {
        currentEnemyCount = 0; 
    }

    public void EnemyKilled()
    {
        currentEnemyCount++; // Increment the enemy count whenever an enemy is killed

        if (currentEnemyCount >= enemyCount) // Check if the required number of enemies has been reached
        {
            SceneChanger1 sceneChanger = sceneChangerObject.GetComponent<SceneChanger1>();

            if (sceneChanger != null) // Check if the SceneChanger script is present on the given object
            {
                sceneChanger.ChangeScene(); // Call the method to change the scene using the SceneChanger script
            }
        }
    }

}
