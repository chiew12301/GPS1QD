using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScriptTesting : MonoBehaviour
{
    public float Speeds = 0.0f; //Speeds of character

    public Animator animator; //Animation purpose

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(Speeds));

        if (Input.GetKeyDown(KeyCode.W))
        {
            Speeds = 1f;
            FindObjectOfType<AudioManager>().Play("AudioTest");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Speeds = 0.0f;
            FindObjectOfType<AudioManager>().Pause("AudioTest");
        }
    }
}
