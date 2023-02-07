using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public bool isOpened = false;
    [SerializeField]
    private float closeX, openX;
    public GameObject inventory;
    Vector3 pos;

    public void PressInventoryButton() {
        if (isOpened) {
            isOpened = false;
        } else {
            isOpened = true;
        }
    }

    void Update() {
        pos = transform.position;
        if (isOpened) {
            inventory.SetActive(true);
            pos.y = Screen.width * openX;
        } else {
            inventory.SetActive(false);
            pos.y = Screen.width * closeX;
        }
        transform.position = pos;
    }
}

