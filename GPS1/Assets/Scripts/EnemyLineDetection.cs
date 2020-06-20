using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineDetection : MonoBehaviour
{
    public GameObject EnemyVisionBox;
    private Transform target;
    public float speedChase = 4f;

    //Left & Right way points
    public float moveSpeedPatrol = 3f;
    Transform leftWayPoint;
    Transform rightWayPoint;
    Vector3 localScale;
    bool movingRight = true;
    Rigidbody2D rb;

    bool chaseActivation = false;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //Left & Right way points
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
    }

    void Update()
    {

        if (chaseActivation)
        {
            chaseToPlayer();
        }
        else
        {
            //Left & Right way points
            if (transform.position.x > rightWayPoint.position.x)
                movingRight = false;
            if (transform.position.x < leftWayPoint.position.x)
                movingRight = true;

            if (movingRight)
                moveRight();
            else
                moveLeft();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("CHASE");
            EnemyVisionBox.SetActive(false);
            chaseActivation = true;
        }   
        else if (collision.CompareTag("Wall"))
        {
            Debug.Log("WALL");
        }
        
        

        /*if (GameObject.FindGameObjectWithTag("Wall").GetComponent<Transform>())
        {
            Debug.Log("WALL");
        }

        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>())
        {
            Debug.Log("CHASE");
            EnemyVisionBox.SetActive(false);
            chaseActivation = true;
        }*/

        
    }

    void chaseToPlayer() //Chase to player
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speedChase * Time.deltaTime);
    }

    void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeedPatrol, rb.velocity.y);
    }

    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeedPatrol, rb.velocity.y);
    }
}
