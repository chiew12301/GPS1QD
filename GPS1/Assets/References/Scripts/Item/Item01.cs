//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
//public class Item : ScriptableObject
//{
//    new public string name = "New Item";
//    public int amount = 1;
//    public int currentStack = 1;
//    public bool showInInventory = false;
//    public Sprite icon = null;
//    public ItemType itemType;

//    public enum ItemType
//    {
//        Weapon,
//        Material1,
//        Material2,
//    }

//    public virtual void UseItem()
//    {
//        Debug.Log("Using " + name);
//    }

//    public bool IsStackable()
//    {
//        switch (itemType)
//        {
//            default:

//            case ItemType.Weapon:
//                return false;

//            case ItemType.Material1:
//                return true;

//            case ItemType.Material2:
//                return true;
//        }
//    }
//}
