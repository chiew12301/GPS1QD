using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    private InventoryScriptUI InventoryScriptUI;
    // Start is called before the first frame update
    void Start()
    {
        InventoryScriptUI = GameObject.FindGameObjectWithTag("InventoryUI").GetComponent<InventoryScriptUI>();
    }

    public void OnMouseEnter()
    {
        Debug.Log("On Inventory");
        InventoryScriptUI.openInventorySlots();
    }

    public void OnMouseExit()
    {
        StartCoroutine(TimerToOff(0f));
    }

    IEnumerator TimerToOff(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Off Inventory");
        InventoryScriptUI.closeInventorySlots();
    }
}
