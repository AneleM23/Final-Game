using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton pattern

    public int totalEnemies;
    private int enemiesRemaining;

    public GameObject sceneManager; // Drag and drop your scene manager object here

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initialize the number of enemies in the level
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemiesRemaining = totalEnemies;
    }

    public void EnemyKilled()
    {
        enemiesRemaining--;

        if (enemiesRemaining <= 0)
        {
            LevelCompleted();
        }
    }

    private void LevelCompleted()
    {
        // Activate the scene manager or perform any other level completion actions
        sceneManager.SetActive(true);
    }
}


