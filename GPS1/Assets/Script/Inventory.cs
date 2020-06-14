using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public  List<Item> itemLists = new List<Item>();
    private int maxSize = 5;
    public static Inventory instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback; //Event

    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ItemSlots Created");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            showAllList();
        }
    }

    public void addItem(Item i)
    {
        if(itemLists.Count >= maxSize)
        {
            Debug.Log("Inventory is full");
            return;
        }
        itemLists.Add(i);
        Debug.Log("Item Get");
        Debug.Log(i.name);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

    }

    public void ClearItem(Item i)
    {
        itemLists.Remove(i);
        Debug.Log("Item Clear");
        Debug.Log(i.name);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public void showAllList()
    {
        foreach (Item item in itemLists)
        {
            Debug.Log(item.name);
        }
    }
}
