using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScriptUI : MonoBehaviour
{
    private Inventory inventory;
    private SlotsScript[] itemSlots;
    public Transform itemParent;
    public GameObject slotPrefab;
    public bool isOpen = false;
    public GameObject GranParentsInventory;
    void Start()
    {
        closeInventorySlots();
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
    }

    void UpdateUI()
    {
        itemSlots = itemParent.GetComponentsInChildren<SlotsScript>();

        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (i < inventory.itemLists.Count)
            {
                itemSlots[i].AddItem(inventory.itemLists[i]);
            }
            else
            {
                itemSlots[i].UseItem();
            }
        }
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(1))
        //{
        //    if (isOpen == false)
        //    {
        //        openInventorySlots();
        //    }
        //    else
        //    {
        //        closeInventorySlots();
        //    }
        //}
    }
    public void closeInventorySlots()
    {
        GranParentsInventory.gameObject.SetActive(false);
        isOpen = false;
    }

    public void openInventorySlots()
    {
        GranParentsInventory.gameObject.SetActive(true);
        isOpen = true;
    }
}
