using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    private float xRange, yRange;
    public int weapon;
    public Health hp;

    void Start() {
        weapon = 1;
    }
    // Update is called once per frame
    void OnMouseDown() 
    {
        if (weapon == 1) {
            rb.AddForce(new Vector3(Random.Range(xRange * -1, xRange), Random.Range(yRange/3, yRange)));
            hp.takeDamage(Random.Range(1, 3));
        } else if (weapon == 2) {
            hp.takeDamage(5);
        }
    }
}
