using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTesterController : MonoBehaviour
{
    public GameObject gun;

    private void Update()
    {
        //Check for input to equip the gun
        if (Input.GetKeyUp(KeyCode.E))
        {
            //Enable gun 
            gun.SetActive(true);
        }
    }
}
