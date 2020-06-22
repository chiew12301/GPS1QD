using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject itemButton;
    public Item item;
    private MouseCursor mcS;
    public MoveScriptTesting player;
    private float Distance;
    public bool MouseisIn = false;
    void Start()
    {
        mcS = GameObject.FindGameObjectWithTag("Cursor").GetComponent<MouseCursor>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MoveScriptTesting>();
        player.OnPressLeftClick += OnPressLeftClick_Test;
    }

    private void Update()
    {
        calDistance(player.gameObject);
    }

    public void performPickup()
    {
        Inventory.instance.addItem(item);
        player.OnPressLeftClick -= OnPressLeftClick_Test;
        mcS.setToDefaultCursor();
        Destroy(transform.gameObject);
        DontDestroyOnLoad(gameObject);
    }
    public float calDistance(GameObject playerObject)
    {
        Distance = Vector2.Distance(this.gameObject.transform.position, playerObject.transform.position);
        return Distance;
    }

    void OnMouseEnter()
    {
        Debug.Log("Mouse is in");
        mcS.setToCursor1();
        MouseisIn = true;
    }

    private void OnPressLeftClick_Test(bool f)
    {
        if (f == true)
        {
            if (calDistance(player.gameObject) <= 3 && MouseisIn == true)
            {
                Debug.Log("Done");
                performPickup();
            }
            else
            {
                Debug.Log("Not clicking or not in range");
                return;
            }

        }
    }

    void OnMouseExit()
    {
        mcS.setToDefaultCursor();
        MouseisIn = false;
    }

}
