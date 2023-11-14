using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;
    //public GunManager currentGun;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
            if (rb == null)
            {
                Debug.LogError("Rigidbody2D not found!");
            }
        }

        if (cam == null)
        {
            cam = Camera.main;
            if (cam == null)
            {
                Debug.LogError("Main camera not found!");
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Debug.Log("Movement: " + movement);
        Debug.Log("Mouse Position: " + mousePos);


        Vector2 lookDirection = mousePos - rb.position;
        //Atan2 is a mathematical function that returns the angle between the x axis and a 2d vector starting at zero terminating at X, Y
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        rb.rotation = angle;


    }
   // public void EquipGun(GunManager newGun)
   // {
      //  if (currentGun != null)
      //  {
      //      currentGun = newGun;
      //  }

      //  currentGun.gameObject.SetActive(true);
   // }
}
