using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// to do:
// WinScreen Menu Buttons
// 
//
//
//
public class MenuButtons : MonoBehaviour
{
    public Slider healthbar;
    public GameObject PauseMenu;
    public GameObject UI;
    public GameObject DifficultySettings;
    // pause button
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            //make pause menu visible
            PauseMenu.GetComponent<Canvas>().enabled = true;
            UI.GetComponent<Canvas>().enabled = false;
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
        Time.timeScale = 1;
        UI.GetComponent<Canvas>().enabled = true;
        PauseMenu.GetComponent<Canvas>().enabled = false;
        DifficultySettings.GetComponent<Canvas>().enabled = false;
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
        UI.GetComponent<Canvas>().enabled = false;

    }
    //for the setting a go back button
    public void GoBack()
    {
        PauseMenu.GetComponent<Canvas>().enabled = true;
        DifficultySettings.GetComponent<Canvas>().enabled = false;
    }
    //exit pause menu button
    public void ExitMenu()
    {
        Resume();
    }

    //Easy Diffculty
    public void EasyMode()
    {
        PlayerPrefs.SetInt("Max HP", 5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    //Normal Diffculty
    public void NormalMode()
    {
        PlayerPrefs.SetInt("Max HP", 3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    //Hard Diffculty
    public void HardMode()
    {
        PlayerPrefs.SetInt("Max HP", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();

    }

    //Winscreen play again
    public void Playagain()
    {
        SceneManager.LoadScene("Level1");
    }

   //WinScreen Not to Play again
   public void Backtomenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
