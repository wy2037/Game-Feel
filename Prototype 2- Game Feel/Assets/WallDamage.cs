using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDamage : MonoBehaviour
{
    private Rigidbody2D rb;
    private Health enemyHp;
    private float speed;
    [SerializeField]
    float minSpeed;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            rb = other.GetComponent<Rigidbody2D>();
            enemyHp = other.GetComponent<Health>();

            speed = Mathf.Pow(rb.velocity.x, 2) + Mathf.Pow(rb.velocity.y, 2);
            if (speed > minSpeed) {
                enemyHp.takeDamage((int)Mathf.Sqrt(speed) / 5);
            }
        }
    }
}
