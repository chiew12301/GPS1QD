using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    public string firstScene;
    public Animator transition;
    private float transitionTime = 2f;
    // Start is called before the first frame update


    // Update is called once per frame
    public void newStart()
    {
        SceneManager.LoadScene(firstScene);
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(firstScene);
    }
}
