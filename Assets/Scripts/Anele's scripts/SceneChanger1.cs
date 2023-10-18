using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{

    public string sceneToLoad; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        
        SceneManager.LoadScene(sceneToLoad);
    }
}
