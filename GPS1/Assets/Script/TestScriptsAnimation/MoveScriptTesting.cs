using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScriptTesting : MonoBehaviour
{
    public float Speeds; //Speeds of character
    [SerializeField] Transform target = null;
    private InventoryScriptUI inventoryUI;
    Vector3 targetPos;
    bool isMoving = false;
    bool isPlayed = false;
    public bool isLeftClicked = false;
    public Animator animator; //Animation purpose
    //Event
    public delegate void PressLeftClickEvent(bool f);
    public PressLeftClickEvent OnPressLeftClick;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
        inventoryUI = GameObject.FindGameObjectWithTag("InventoryUI").GetComponent<InventoryScriptUI>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(Speeds));

        if (Input.GetMouseButtonDown(0))
        {
            isLeftClicked = true;
            if(inventoryUI.isOpen == false)
            {
                SetPosition();
            }
            else
            {
                Debug.Log("Inventory opened");
                return;
            }

            if(OnPressLeftClick != null)
            {
                OnPressLeftClick.Invoke(isLeftClicked);
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            isLeftClicked = false;
        }
        if (isMoving == true)
        {
            Move();
        }
    }
    public void SetPosition()
    {
        targetPos = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.position = targetPos;
        targetPos.z = transform.position.z;
        targetPos.y = transform.position.y;
        isMoving = true;
    }

    public void SetFeeze()
    {
        targetPos = target.position;
        target.position = targetPos;
        targetPos.z = transform.position.z;
        targetPos.y = transform.position.y;
        isMoving = false;
        isPlayed = false;
    }

    public void StopMoving()
    {
        if(isMoving == true)
        {
            Speeds = 0f;
            Vector3 temp = transform.position;
            this.transform.position = temp;
            isMoving = false;
        }
        else
        {
            return;
        }
    }

    public void Move()
    {
        //transform.position = Quaternion.LookRotation(Vector3.foward, targetPos);
        Speeds = 2f;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Speeds * Time.deltaTime);
        if(isPlayed == false)
        {
            FindObjectOfType<AudioManager>().Play("Moving");
            isPlayed = true;
        }
        if (transform.position == targetPos)
        {
            isMoving = false;
            isPlayed = false;   
            Speeds = 0f;
            FindObjectOfType<AudioManager>().Pause("Moving");
        }
    }
}
