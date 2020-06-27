using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public  List<Item> itemLists = new List<Item>();
    public int maxSize = 5;
    public static Inventory instance;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback; //Event

    public static string savedName; //! New 
    public static string savedDesc; //! New 
    public static Sprite saveditemSprite;

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
        if (Input.GetKeyDown(KeyCode.W)) //Testing list item
        {
            showAllList();
        }
    }

    public void addItem(Item i)
    {
        Time.timeScale = 0;
        if (itemLists.Count >= maxSize)
        {
            Debug.Log("Inventory is full");
            return;
        }
        itemLists.Add(i);
        Debug.Log("Item Get");
        Debug.Log(i.name);
        savedName = i.name.ToString();
        savedDesc = i.desc.ToString();
        saveditemSprite = i.itemSprite;
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
