using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class PlayerMoveScript : MonoBehaviour
{

    [SerializeField] Transform target;
    public float speed;
    Vector3 targetPos;
    bool isMoving = false;

    private void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetPosition();
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
        isMoving = true;
    }

    public void Move()
    {
        //transform.position = Quaternion.LookRotation(Vector3.foward, targetPos);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (transform.position == targetPos)
        {
            isMoving = false;
        }
    }
}


