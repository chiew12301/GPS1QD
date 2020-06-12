using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsScript : MonoBehaviour
{
    private Inventory inventory;
    public int i;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if(transform.childCount <=0)
        {
            inventory.isFilled[i] = false;
        }
    }
    public void useItem()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
