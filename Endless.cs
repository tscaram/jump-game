using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script controls the endless mode of the game

public class Endless : MonoBehaviour
{

    public GameObject[] platforms = new GameObject[5];  //the number of random platforms designed
    int height = 2;
    // Initializes the game, and instantiates the first ten platforms
    void Start()
    {
        MainMenuControl.gameMode = "Endless";  
        for (int i = 0; i < 10; i++)
        {
            instantiateRandom();
        }
    }



    // If the height increases to the point that a new platform must be created, create the platform
    void Update()
    {

        if (height - ChangeScore.height == 30)
        {
            instantiateRandom();
        }
        if (Input.GetKeyDown(KeyCode.Escape))   //quits to the main menu if the player presses escape
            SceneManager.LoadScene(0);
    }



    void instantiateRandom()
    {
        int whichObject = Random.Range(0, 6);   //choose a random platform design
        float x = 0;
        switch (whichObject)    //offset each individual platform so that it lines up correctly with the walls and the player
        {
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


        Instantiate(platforms[whichObject], new Vector2(x, height), Quaternion.Euler(new Vector3(0, 0, 90)));   //instantiate the object
        height += 3;
    }

}
