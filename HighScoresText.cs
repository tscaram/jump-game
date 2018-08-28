using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Controls the high scores screen and ensures that the right scores are displayed. If there are no scores yet, display 0

public class HighScoresText : MonoBehaviour {

    public Text highScores;

    // Pulls the scores from playerprefs and if they don't exist use 0 instead
    void Start () {
        int endlessScore = 0;
        int hardcoreScore = 0;
        if (PlayerPrefs.HasKey("Hardcore"))
        {
            hardcoreScore = PlayerPrefs.GetInt("Hardcore");
        }
            
        if (PlayerPrefs.HasKey("Endless"))
        {
            endlessScore = PlayerPrefs.GetInt("Endless");
        }
        highScores.text = "Hardcore: " + hardcoreScore + '\n' + "Endless: " + endlessScore;
    }
	
    // Return to main menu if escape is pressed
    void Update () {
	if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    //resets all the scores to 0 and then runs the start function again so you can see they've been reset
    public void reset()
    {
        if (PlayerPrefs.HasKey("Hardcore"))
        {
            PlayerPrefs.SetInt("Hardcore", 0);
        }
        if (PlayerPrefs.HasKey("Endless"))
        {
            PlayerPrefs.SetInt("Endless", 0);
        }
        Start();
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
