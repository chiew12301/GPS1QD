//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class InventorySlot : MonoBehaviour
//{
//    private Item item;

//    public Image icon;
//    public TextMeshProUGUI stackNum;

//    public void AddItem(Item newItem)
//    {
//        item = newItem;

//        icon.sprite = item.icon;
//        icon.enabled = true;

//        if (item.currentStack > 1)
//        {
//            stackNum.text = item.currentStack.ToString();
//        }
//        else
//        {
//            stackNum.text = "";
//        }
//    }

//    public void UseItem()
//    {
//        item = null;

//        icon.sprite = null;
//        icon.enabled = false;

//        stackNum.text = "";
//    }

//    public void RemoveItem()
//    {
//        if (item != null)
//        {
//            Inventory.instance.Remove(item);
//        }
//    }
//}
