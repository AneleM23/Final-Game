using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;
    public Camera cam;

    public GunManager currentGun;

    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += playerInput.normalized * moveSpeed * Time.deltaTime;

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }

    public void EquipGun(GunManager newGun)
    {
        if (currentGun != null)
        {
            currentGun = newGun;
        }

        currentGun.gameObject.SetActive(true);
    }
}



