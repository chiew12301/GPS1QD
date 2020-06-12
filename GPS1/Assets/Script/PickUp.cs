using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory Pinventory;
    public GameObject itemButton;

    private MouseCursor mcS;
    void Start()
    {
        Pinventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        mcS = GameObject.FindGameObjectWithTag("Cursor").GetComponent<MouseCursor>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            for(int i = 0; i < Pinventory.slots.Length; i++)
            {
                if(Pinventory.isFilled[i] == false)
                {
                    //Add item
                    Pinventory.isFilled[i] = true;
                    Instantiate(itemButton, Pinventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

    void OnMouseEnter()
    {
        mcS.setToCursor1();
    }

    void OnMouseExit()
    {
        mcS.setToDefaultCursor();
    }

}
