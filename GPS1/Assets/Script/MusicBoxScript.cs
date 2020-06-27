using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MusicBoxScript : MonoBehaviour
{
    public int counterBookDrop = 0;
    private void Update()
    {
        CheckBookDrop();
    }

    void CheckBookDrop()
    {
        if(counterBookDrop >=3)
        {

            Debug.Log("Done Puzzle");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Book"))
        {
            counterBookDrop++;
            Debug.Log("Counter" + counterBookDrop);
            collision.gameObject.SetActive(false);
        }
    }
}
