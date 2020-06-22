using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapTransitionTest : MonoBehaviour
{
    public bool isEnd = false;
    public Text endText;
    public GameObject nxtRoom = null;
    public MoveScriptTesting player;
    public GameObject Parents;
    // Start is called before the first frame update
    void Start()
    {
        nxtRoom.SetActive(false);
        endText.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MoveScriptTesting>();
    }

    void checkIsEnd()
    {
        if(nxtRoom != null)
        {
            isEnd = false;
            return;
        }
        isEnd = true;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("What");
        if(collision.gameObject == player)
        {
            Debug.Log("IsNext");
            checkIsEnd();
            player.SetFeeze();
            if (isEnd == true)
            {
                endText.enabled = true;
                return;
            }
            else
            {
                nxtRoom.SetActive(true);
                Parents.SetActive(false);
            }
        }
    }

}
