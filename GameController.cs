using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //The length of this array was picked in the unity editor as we developed the game, so this number doesn't actually line up with
    //the real number in the game
    public GameObject[] platforms = new GameObject[4];

    void Start () {
        int height = 2;
	    
	//instantiates 50 random platforms as soon as the scene is created. This is used for the main mode, which has a fixed win height
	for (int i = 0; i < 50; i++) {	
            int whichObject = Random.Range(0, 6);
            float x = 0;
            switch (whichObject){
                case 0:
                    x = 2.165f;
                    break;
                case 1:
                    x = -2.01f;
                    break;
                case 2:
                    x = -2.702f;
                    break;
                case 3:
                    x = -6.082f;
                    break;
                case 4:
                    x = 0f;
                    break;
                case 5:
                    x = -4.55f;
                    break;
            }


            Instantiate(platforms[whichObject], new Vector2(x, height), Quaternion.Euler(new Vector3(0,0,90)));
            height += 3;
        }
    }
	
    //if the player presses escape, quit to the main menu
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
}
