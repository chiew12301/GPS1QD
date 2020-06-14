//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Inventory01 : MonoBehaviour
//{
//    public int space = 5;
//    public delegate void OnItemChanged();
//    public OnItemChanged onItemChangedCallback;
//    public List<Item> itemList = new List<Item>();
//    public static Inventory instance;

//    void Awake()
//    {
//        if (instance != null)
//        {
//            return;
//        }

//        instance = this;
//    }

//    public void AddItem(Item item)
//    {
//        if (!item.showInInventory)
//        {
//            if (itemList.Count >= space)
//            {
//                return;
//            }

//            if (item.IsStackable())
//            {
//                bool itemAlreadyInInventory = false;

//                foreach (Item inventoryItem in itemList)
//                {
//                    if (inventoryItem.itemType == item.itemType)
//                    {
//                        inventoryItem.currentStack += item.amount;
//                        itemAlreadyInInventory = true;
//                    }
//                }

//                if (!itemAlreadyInInventory)
//                {
//                    itemList.Add(item);
//                }
//            }
//            else
//            {
//                itemList.Add(item);
//            }

//            if (onItemChangedCallback != null)
//                onItemChangedCallback.Invoke();
//        }
//    }

//    public void Remove(Item item)
//    {
//        if (item.IsStackable())
//        {
//            Item itemInInventory = null;

//            foreach (Item inventoryItem in itemList)
//            {
//                if (inventoryItem.itemType == item.itemType)
//                {
//                    inventoryItem.currentStack -= item.amount;
//                    itemInInventory = inventoryItem;
//                }
//            }

//            if (itemInInventory != null && itemInInventory.currentStack <= 0)
//            {
//                itemList.Remove(itemInInventory);
//            }
//        }
//        else
//        {
//            itemList.Remove(item);
//        }

//        if (onItemChangedCallback != null)
//            onItemChangedCallback.Invoke();
//    }
//}
