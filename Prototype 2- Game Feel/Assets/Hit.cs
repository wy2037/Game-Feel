using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    private float xRange, yRange;

    // Update is called once per frame
    void OnMouseDown() 
    {
        rb.AddForce(new Vector3(Random.Range(xRange * -1, xRange), Random.Range(yRange/3, yRange)));
    }
}
