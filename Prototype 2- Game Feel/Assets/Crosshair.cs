using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Camera cam;
    public Hit weaponChoice;

    // Update is called once per frame
    void Update()
    {
        if (weaponChoice.weapon == 2) {
            gameObject.SetActive(true);
            transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
        } else {
            gameObject.SetActive(false);
        }
    }
}
