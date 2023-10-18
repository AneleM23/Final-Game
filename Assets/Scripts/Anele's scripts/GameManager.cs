using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject portalObject; // The portal GameObject
    public int totalEnemies; // The total number of enemies in the level

    public int killedEnemies = 0;



    // Start is called before the first frame update
    void Start()
    {
        portalObject.SetActive(false);
    }

    public void EnemyKilled()
    {
        killedEnemies++;

        if (killedEnemies >= totalEnemies)
        {
            portalObject.SetActive(true); // Activate the portal when all enemies are killed
        }
    }

}
