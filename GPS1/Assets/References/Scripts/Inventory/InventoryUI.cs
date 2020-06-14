//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class InventoryUI : MonoBehaviour
//{
//    private Inventory inventory;
//    private InventorySlot[] itemSlots;

//    public Transform itemParent;
//    public GameObject slotPrefab;
//    //ublic ClassSelection cs;

//    void Start()
//    {
//        inventory = Inventory.instance;
//        inventory.onItemChangedCallback += UpdateUI;

//        if (ClassSelection.instance.isStrength)
//        {
//            Inventory.instance.space = 6;
//            GameObject slot = Instantiate(slotPrefab, new Vector2(0f, 0f), Quaternion.identity) as GameObject;
//            slot.transform.SetParent(itemParent);
//        }
//    }

//    void UpdateUI()
//    {
//        itemSlots = itemParent.GetComponentsInChildren<InventorySlot>();

//        for (int i = 0; i < itemSlots.Length; i++)
//        {
//            if (i < inventory.itemList.Count)
//            {
//                itemSlots[i].AddItem(inventory.itemList[i]);
//            }
//            else
//            {
//                itemSlots[i].UseItem();
//            }
//        }
//    }
//}
