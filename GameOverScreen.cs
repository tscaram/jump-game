using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {
    public Text theEnd;
    
    // Use this for initialization
    void Start () {
	//if you're playing the normal game mode and you win, say you win
        if (ChangeScore.win)
        {
            theEnd.text = "Congratulations! You win!\nPress Esc to start over!";
        }
        else theEnd.text = "Good game! You reached a height of " + ChangeScore.height + " feet.\nPress Esc to start over!";
	    
	//if youre playing the endless or hardcore game mode, if you beat the high score, save the high score
        if (PlayerPrefs.HasKey(MainMenuControl.gameMode))
        {
            if (MainMenuControl.gameMode.Equals("Endless"))
            {
                if (ChangeScore.height > PlayerPrefs.GetInt("Endless"))
                {
                    PlayerPrefs.SetInt("Endless", ChangeScore.height);
                }
            }
            else
            {
                if (ChangeScore.height > PlayerPrefs.GetInt("Hardcore"))
                {
                    PlayerPrefs.SetInt("Hardcore", ChangeScore.height);
                }
            }
        }
        else
            PlayerPrefs.SetInt(MainMenuControl.gameMode, ChangeScore.height);
	}
	
    // Go to the main menu when escape is pressed
    void Update () {
	if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
