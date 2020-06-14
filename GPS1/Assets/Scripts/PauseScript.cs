using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;

    public GameObject SettingsMenuUI;

    public Button PauseButton;

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        PauseButton.interactable = false;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        PauseButton.interactable = true;

    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("Menu");
        Debug.Log("Returning to Main Menu");
    }

    public void Volume()
    {
        SettingsMenuUI.SetActive(true);
    }

    public void ExitSettings()
    {
        SettingsMenuUI.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quitting game");
        //Application.Quit();
    }

}
