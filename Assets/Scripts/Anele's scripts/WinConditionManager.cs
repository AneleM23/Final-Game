using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditionManager : MonoBehaviour
{
    public static WinConditionManager instance;

    public Text winText;

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

    public void CheckWinCondition()
    {
        // Check if all enemies are killed
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            ShowWinText();
        }
    }

    void ShowWinText()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Win Text reference is missing. Assign the Text component in the Inspector.");
        }
    }

}
