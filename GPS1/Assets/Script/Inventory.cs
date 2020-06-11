using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemLists; 
    // Start is called before the first frame update
    void Start()
    {
        itemLists = new List<Item>();
        Debug.Log("ItemSlots Created");
    }

    public void addItem(Item i)
    {
        if(i.name == "book")
        {
            i.desc = "Meh just a book";
        }
        itemLists.Add(i);
        Debug.Log("Item Get");
        Debug.Log(i.name);
    }
}
