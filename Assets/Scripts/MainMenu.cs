using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f; //sets time to flow normally, in case of previously pressing escape
    }

    public void QuitGame()
    {
        Debug.Log("GAMESAQUITDD");
        Application.Quit(); //closes game
    }
    
}

