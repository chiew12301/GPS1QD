using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Item")]
public class Item : MonoBehaviour
{
    public Sprite itemSprite = null; //Item Sprite/Icon
    new public string name = "New Item"; //Name of the item
    new public string desc = "New Desc"; //Description of the item

    public bool isFull = false; //is the item default wear (Might delete)

}
