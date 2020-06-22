using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropScrip : MonoBehaviour
{
    private bool selected;
    //public PlayerMoveScript pS;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (selected == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    void OnMouseDrag()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
            //pS.isMoving = false;
        }
    }
}
