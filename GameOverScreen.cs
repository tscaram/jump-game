using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour {
    public Text theEnd;
    
	// Use this for initialization
	void Start () {
        if (ChangeScore.win)
        {
            theEnd.text = "Congratulations! You win!\nPress Esc to start over!";
        }
        else theEnd.text = "Good game! You reached a height of " + ChangeScore.height + " feet.\nPress Esc to start over!";
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
	
	// Update is called once per frame
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
