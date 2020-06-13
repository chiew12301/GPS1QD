using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int curScene;
    private bool loaded = false;
    Vector3 loadPosition;
    //private savePointTouch bench;
    private void Start()
    {
        curScene = SceneManager.GetActiveScene().buildIndex;
        //GameObject savePoint = GameObject.FindGameObjectWithTag("Trigger");
        //bench = savePoint.GetComponent<savePointTouch>();

        if (loaded)
        {
            transform.position = loadPosition;
        }
    }

    public void savePlayer()
    {
        saveSystem.Save(this);
    }

    public void loadPlayer()
    {
        playerData data = saveSystem.Load();
        loaded = true;
        loadPosition.x = data.position[0];
        loadPosition.y = data.position[1];
        loadPosition.z = data.position[2];
        Debug.LogError("It works");
        SceneManager.LoadScene(data.curScene);
    }
}
