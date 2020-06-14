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

    private void OnMouseEnter()
    {
        Debug.Log("On Inventory");
        InventoryScriptUI.openInventorySlots();
    }

    private void OnMouseExit()
    {
        StartCoroutine(TimerToOff(3f));
    }

    IEnumerator TimerToOff(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Off Inventory");
        InventoryScriptUI.closeInventorySlots();
    }
}
