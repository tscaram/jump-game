using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuControl : MonoBehaviour {

    //Controls which game mode is being used in a static string that can be accessed across all the other scripts.
    //Also controls all of the buttons on the main menu
    
    public static string gameMode = "";

    public void startGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void startEndless()
    {
        SceneManager.LoadScene("Random");
    }


    public void exitGame()
    {
        Application.Quit();
    }

    public void instructionsPage()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void hardcore()
    {
        SceneManager.LoadScene("Hardcore");
    }

    public void scoresPage()
    {
        SceneManager.LoadScene("Scores");
    }
}
