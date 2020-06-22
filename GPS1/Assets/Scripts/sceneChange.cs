using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public Animator transition;
    private float transitionTime = 1.0f;
    private doorTouch door;
    public GameObject designatedDoor;
    private GameObject player = null;
    private Vector3 newLocation;
    public string doorName;

    private void Start()
    {
        GameObject d = GameObject.Find(doorName);
        door = d.GetComponent<doorTouch>();
        player = GameObject.Find("Player");
        newLocation.x = designatedDoor.transform.position.x;
        newLocation.y = designatedDoor.transform.position.y;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log(player.transform.position.x);
        }
        
    }
    public void changeArea()
    {

        if (door.playerTouch)
        {
            transition.SetTrigger("Start");
            StartCoroutine(LoadArea());
            Debug.Log("it works");

        }
    }

    IEnumerator LoadArea()
    {


        yield return new WaitForSeconds(transitionTime);

        player.transform.position = new Vector3(newLocation.x,newLocation.y);
        
    }

}
