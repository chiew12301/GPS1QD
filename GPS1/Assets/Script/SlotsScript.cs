using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotsScript : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    public Image Icon;
    public Item item;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public void AddItem(Item newItem)
    {
        item = newItem;

        Icon.sprite = item.itemSprite;
        Icon.enabled = true;
    }
    public void UseItem()
    {
        item = null;

        Icon.sprite = null;
        Icon.enabled = false;
    }

    public void RemoveItem()
    {
        if (item != null)
        {
            Inventory.instance.ClearItem(item);
        }
    }
}
