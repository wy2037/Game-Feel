using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public Camera cam;
    
    private float startX;
    private float startY;
    
    private bool isDragged = false;

    void Update()
    {
        if (isDragged) {
            DragObject();
        }
    }
    
    void OnMouseDown() {
        Vector2 mousePos = Input.mousePosition;
        
        mousePos = cam.ScreenToWorldPoint(mousePos);
        
        startX = mousePos.x - transform.localPosition.x;
        startY = mousePos.y - transform.localPosition.y;
        
        isDragged = true;
    }
    
    void OnMouseUp() {
        isDragged = false;
    }
    
    public void DragObject() {
        Vector2 mousePos = Input.mousePosition;
        
        mousePos = cam.ScreenToWorldPoint(mousePos);
        transform.localPosition = new Vector2(mousePos.x - startX, mousePos.y - startY);
    }
}
