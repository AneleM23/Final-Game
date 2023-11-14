using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;  // Singleton pattern
    public int numberOfEnemies;

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

    public void EnemyKilled()
    {
        numberOfEnemies--;

        if (numberOfEnemies <= 0)
        {
            Debug.Log("All enemies killed. Loading next scene in 4 seconds.");
            Invoke("LoadNextScene", 4f);
        }
    }

    public void LoadNextScene()
    {
        // Load the next scene using SceneManager
      //  int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(3);
    }


}



