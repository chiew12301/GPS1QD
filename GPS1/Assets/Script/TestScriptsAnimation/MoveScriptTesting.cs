﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScriptTesting : MonoBehaviour
{
    public float Speeds; //Speeds of character
    [SerializeField] Transform target;
    Vector3 targetPos;
    bool isMoving = false;
    bool isPlayed = false;
    public Animator animator; //Animation purpose

    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(Speeds));

        if (Input.GetMouseButtonDown(0))
        {
            SetPosition();
        }
        if (isMoving == true)
        {
            Move();
        }

        //if (Input.GetKeyDown(KeyCode.W)) //Testing Purpose
        //{
        //    Speeds = 1f;
        //    FindObjectOfType<AudioManager>().Play("AudioTest");
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    Speeds = 0.0f;
        //    FindObjectOfType<AudioManager>().Pause("AudioTest");
        //}
    }
    public void SetPosition()
    {
        targetPos = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.position = targetPos;
        targetPos.z = transform.position.z;
        targetPos.y = transform.position.y;
        isMoving = true;
    }

    public void Move()
    {
        //transform.position = Quaternion.LookRotation(Vector3.foward, targetPos);
        Speeds = 2f;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Speeds * Time.deltaTime);
        if(isPlayed == false)
        {
            FindObjectOfType<AudioManager>().Play("AudioTest");
            isPlayed = true;
        }
        if (transform.position == targetPos)
        {
            isMoving = false;
            isPlayed = false;   
            Speeds = 0f;
            FindObjectOfType<AudioManager>().Pause("AudioTest");
        }
    }
}
