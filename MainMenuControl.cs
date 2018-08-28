using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuControl : MonoBehaviour {

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
