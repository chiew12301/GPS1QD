//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class PickUpItem : MonoBehaviour
//{
//    [SerializeField]
//    private Text pickUpText;

//    private bool pickUpAllowed;

//    private void Start()
//    {
//        pickUpText.gameObject.SetActive(false);
//    }

//    private void Update()
//    {
//        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
//            PickUp();
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if(collision.gameObject.name.Equals("Player"))
//        {
//            pickUpText.gameObject.SetActive(true);
//            pickUpAllowed = true;
//        }
//    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.gameObject.name.Equals("Player"))
//        {
//            pickUpText.gameObject.SetActive(false);
//            pickUpAllowed = false;
//        }
//    }

//    private void PickUp()
//    {
//        //ScoreScript.scoreValue++;
//        Destroy(gameObject);
//    }

//}
