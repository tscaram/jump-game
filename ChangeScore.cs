using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//controls how the scoreboard changes as the player moves up

public class ChangeScore : MonoBehaviour {
    public Text scoreBoard;
    public Transform self;
    public static int height;
    public static bool win;

    private Scene scene;
    private string sceneName;

    //initializes the scoreboard
    void Start () {
        height = (int) self.position.y;
        scoreBoard.text = "Height: " + height;
        win = false;

        scene = SceneManager.GetActiveScene();

        sceneName = scene.name;

    }
	
    //updates the score once per frame, making sure it stays consistent with what the player's actual height is
    void Update () {
        if (self.position.y > height)
        {
            height = (int)self.position.y;
            scoreBoard.text = "Height: " + height;
        }

        if (height > 150 && sceneName.Equals("MainScene"))    //if the player hits height 150, they win
        {
            win = true;
            SceneManager.LoadScene(2);   //loads the gameover scene
        }


    }
}
