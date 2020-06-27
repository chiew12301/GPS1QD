using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    BoxCollider2D col2d;
    [Header("Dont Destroy After Interact")]
    public bool DontDestroy = false;


    [Header("Dialogue")]
    public bool Dialogue = false;
    public GameObject dialogueDisplay;
    public Dialogue dialogue;

    [Header("Item")]
    public bool Item = false;

    public GameObject itemObtainedPanel;
    public GameObject itemButton;
    public Item item;

    [Header("Inspect Item")]
    public bool Inspect = false;
    public GameObject inspectDisplay;
    private MouseCursor mcS;
    public MoveScriptTesting player;
    private float Distance;


    public bool isShowDialogue = false;
    public bool isItemObtain = false;

    [Header("Mouse")]
    public bool MouseisIn = false;


    void Start()
    {
        mcS = GameObject.FindGameObjectWithTag("Cursor").GetComponent<MouseCursor>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MoveScriptTesting>();
        player.OnPressLeftClick += OnPressLeftClick_Test;

        col2d = GetComponent<BoxCollider2D>();
    }

    private void OnDisable()
    {
        player.OnPressLeftClick -= OnPressLeftClick_Test;
    }

    private void OnEnable()
    {
        player.OnPressLeftClick += OnPressLeftClick_Test;
    }

    private void Update()
    {
        calDistance(player.gameObject);
    }

    public void performPickup()
    {
        if (Inventory.instance.itemLists.Count >= Inventory.instance.maxSize)
        {
            Debug.Log("Inventory is full");
            return;
        }
        else
        {
            if (Dialogue == true)
            {
                dialogueDisplay.SetActive(true);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (Item == true)
            {

                itemObtainedPanel.SetActive(true);

            }

            if (Inspect == true)
            {
                inspectDisplay.SetActive(true);
            }
            Inventory.instance.addItem(item);
            player.OnPressLeftClick -= OnPressLeftClick_Test;
            if (DontDestroy == false)
            {
                ObjectPoolingManager.instance.AddPoolList(this.gameObject);
            }
            else
            {
                col2d.enabled = false;
            }
            mcS.setToDefaultCursor("Hover");
        }
    }

    public float calDistance(GameObject playerObject)
    {
        Distance = Vector2.Distance(this.gameObject.transform.position, playerObject.transform.position);
        return Distance;
    }

    void OnMouseEnter()
    {
        //Debug.Log("Mouse is in");
        mcS.setToCursorEyes("Hover");
        MouseisIn = true;
    }

    private void OnPressLeftClick_Test(bool f)
    {
        //StartCoroutine(timerDelay(2f));
        if (f == true)
        {
            if (calDistance(player.gameObject) <= 3 && MouseisIn == true)
            {
                //Debug.Log("Done");
                performPickup();
            }
            else
            {
                //Debug.Log("Not clicking or not in range");
                mcS.setToDefaultCursor("Hover");
                return;
            }

        }
    }

    void OnMouseExit()
    {
        mcS.setToDefaultCursor("Hover");
        MouseisIn = false;
    }

}
