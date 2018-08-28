using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScore : MonoBehaviour {
    public Text scoreBoard;
    public Transform self;
    public static int height;
    public static bool win;

    private Scene scene;
    private string sceneName;
	// Use this for initialization
	void Start () {
        height = (int) self.position.y;
        scoreBoard.text = "Height: " + height;
        win = false;

        scene = SceneManager.GetActiveScene();

        sceneName = scene.name;

	}
	
	// Update is called once per frame
	void Update () {
        if (self.position.y > height)
        {
            height = (int)self.position.y;
            scoreBoard.text = "Height: " + height;
        }

        if (height > 150 && sceneName.Equals("MainScene"))
        {
            win = true;
            SceneManager.LoadScene(2);
        }


	}
}
