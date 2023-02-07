using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject bladeTrail;

    // Update is called once per frame
    void Update()
    {
        rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            other.GetComponent<Health>().takeDamage(100);
        }
    }
}
