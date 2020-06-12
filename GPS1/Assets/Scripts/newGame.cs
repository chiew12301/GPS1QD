using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Global
{
    public static int state = 0;
    //0 = New Game
    //1 = Happy ending
    //2 = Bad Ending
    //3 = Secret ending
}
public class newGame : MonoBehaviour
{
    public string firstScene;
    public Animator transition;
    public float transitionTime;
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
