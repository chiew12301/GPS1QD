using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScriptUI : MonoBehaviour
{
    bool isOpen = false;
    public Canvas uiCanvas;
    void Start()
    {
        closeInventorySlots();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(isOpen == false)
            {
                openInventorySlots();
            }
            else 
            {
                closeInventorySlots();
            }
        }
    }
    public void closeInventorySlots()
    {
        uiCanvas.gameObject.SetActive(false);
        isOpen = false;
    }

    public void openInventorySlots()
    {
        uiCanvas.gameObject.SetActive(true);
        isOpen = true;
    }
}
