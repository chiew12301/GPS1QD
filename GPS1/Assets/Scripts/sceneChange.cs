using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    private doorTouch door;
    public string levelName;

    private void Start()
    {
        GameObject d = GameObject.FindGameObjectWithTag("Trigger");
        door = d.GetComponent<doorTouch>();

    }
    public void changeScene()
    {
        if (door.playerTouch)
        {
            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelName);
    }

}
