﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{

    public GameObject PauseMenu;
    public GameObject DifficultySettings;
    // pause button
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            //make pause menu visible
            PauseMenu.GetComponent<Canvas>().enabled = true;
        }
        else if (Time.timeScale == 0)
        {
            //unpause
            Resume();
        }

    }
    // new game button
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    // quit button
    public void QuitGame()
    {
        Application.Quit();
    }
    // resume button
    public void Resume()
    {
        PauseMenu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    //retry button
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }
    //code below is for the difficulty settings
    public void DifficultySettingsMenu()
    {
        DifficultySettings.GetComponent<Canvas>().enabled = true;
        PauseMenu.GetComponent<Canvas>().enabled = false;
    }
    //for the setting a go back button
    public void GoBack()
    {
        PauseMenu.GetComponent<Canvas>().enabled = true;
        DifficultySettings.GetComponent<Canvas>().enabled = false;
    }

}