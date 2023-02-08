using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Camera cam;
    public Hit weaponChoice;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (weaponChoice.weapon == 2) {
            gameObject.SetActive(true);
            transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
        } else {
            gameObject.SetActive(false);
        }
    }
}
