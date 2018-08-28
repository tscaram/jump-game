using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoresText : MonoBehaviour {

    public Text highScores;

	// Use this for initialization
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
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}

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
