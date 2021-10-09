using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView; Caused an issue during build 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

  
    void Update()
    {
        //if the game is already paused, resume or else pause with escape key
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GameIsPaused) 
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

   public void Resume()
    {
        PauseMenuUI.SetActive(false); //deactivates the pause UI
        Time.timeScale = 1f; //resumes time
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //stops time/"pauses"
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("epic menu my bro");
        SceneManager.LoadScene("Title screen");

    }

    public void QuitGame()
    {
        Debug.Log("qiuitinnggn");
        Application.Quit(); //closes the game  
    }
    
    
}



