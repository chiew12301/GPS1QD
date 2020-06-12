using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //private List<Item> itemLists;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    itemLists = new List<Item>();
    //    Debug.Log("ItemSlots Created");
    //}

    //public void addItem(Item i)
    //{
    //    itemLists.Add(i);
    //    Debug.Log("Item Get");
    //    Debug.Log(i.name);
    //}

    //public void ClearItem(Item i)
    //{
    //    for(int j = 0; j < itemLists.Count; j++)
    //    {
    //        if(itemLists[j] == i)
    //        {
    //            itemLists.RemoveAt(j);
    //        }
    //    }
    //    Debug.Log("Item Clear");
    //    Debug.Log(i.name);
    //}
    public bool[] isFilled;
    public GameObject[] slots;
}
