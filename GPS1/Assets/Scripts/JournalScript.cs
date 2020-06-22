using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JournalScript : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    public GameObject []Notes;

    [Header("Buttons")]
    public Button JournalButton;
    public Button PrevButton;
    public Button NextButton;

    [Header("Pages")]
    public GameObject PrevPage;
    public GameObject NextPage;
    private int Page = 1;

    [Header("Note Tabs")]    //Journal Tabs
    public GameObject NoteDetails;
    public GameObject NoteTab;
    public GameObject NoteTabBig;
    public Button NoteTabSmall;

    [Header("Setting Tabs")]    //Journal Tabs
    public GameObject SettingsDetails;
    public GameObject SettingsTab;
    public GameObject SettingsTabBig;
    public Button SettingsTabSmall;
    
    

    void Update()
    {
        pageVisibility();
    }
    public void ExitJournal()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        ResetNotes();
        JournalButton.interactable = true;
    }

    public void OpenJournal()
    {
        OpenNoteTab();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;

        Notes[0].SetActive(true);
        Notes[1].SetActive(false);

        //PrevButton.Select();
        JournalButton.interactable = false;

        Page = 1;
    }

    public void OpenNoteTab()
    {
        NoteTab.SetActive(false);
        NoteTabBig.SetActive(true);
        SettingsTabBig.SetActive(false);
        SettingsTab.SetActive(true);

        NoteDetails.SetActive(true);
        SettingsDetails.SetActive(false);
    }

    public void Note_1()
    {
        ResetNotes();
        Notes[0].SetActive(true);
    }

    public void Note_2()
    {
        ResetNotes();
        Notes[1].SetActive(true);
    }

    public void Note_3()
    {
        ResetNotes();
        Notes[2].SetActive(true);
    }

    public void OpenSettings()
    {
        NoteTab.SetActive(true);
        NoteTabBig.SetActive(false);
        SettingsTabBig.SetActive(true);
        SettingsTab.SetActive(false);

        NoteDetails.SetActive(false);
        SettingsDetails.SetActive(true);
    }

    public void pageVisibility()
    {
        if(Page == 1)
        {
            NextPage.SetActive(true);
            PrevPage.SetActive(false);
        }
        else if(Page == 2)
        {
            NextPage.SetActive(true);
            PrevPage.SetActive(true);   
        }
        else if(Page == 3)
        {
            NextPage.SetActive(false);
            PrevPage.SetActive(true);
        }
    }

    public void GoNextPage()
    {
        if (Page == 1)
        {
            Note_2();
            Page = 2;
        }
        else if(Page == 2)
        {
            Note_3();
            Page = 3;
        }
        else if (Page == 3)
        {
            //nothing
        }

    }

    public void GoPrevPage()
    {
        if (Page == 1)
        {
            //nothing
        }
        else if (Page == 2)
        {
            Note_1();
            Page = 1;
        }
        else if (Page == 3)
        {
            Note_2();
            Page = 2;
        }
    }

    private void ResetNotes()
    {
        Notes[0].SetActive(false);
        Notes[1].SetActive(false);
        Notes[2].SetActive(false);
    }
}
