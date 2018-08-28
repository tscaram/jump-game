using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//controls the hardcore game mode

public class HardCore : MonoBehaviour {
    
    //sets up the array of platforms and sets initial height
    public GameObject[] platforms = new GameObject[6];
    int height = 2;

    //sets up the enemy gameobject, allowing the script to instantiate enemies
    public GameObject enemy;

    // Sets the game mode and instantiates the first ten platforms
    void Start()
    {
        MainMenuControl.gameMode = "Hardcore";
        for (int i = 0; i < 10; i++)
        {
            instantiateRandom();
        }
    }



    // Works the same as the endless script, except this one has a chance of instantiating an enemy
    void Update()
    {

        if (height - ChangeScore.height == 30)
        {
            instantiateRandom();
            instantiateEnemy(height);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }


    //instantiates new platforms with offsets
    void instantiateRandom()
    {
        int whichObject = Random.Range(0, 6);
        float x = 0;
        switch (whichObject)
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

        Instantiate(platforms[whichObject], new Vector2(x, height), Quaternion.Euler(new Vector3(0, 0, 90)));
        height += 3;
    }

    //has a one in 5 chance of instantiating an enemy on the platform in a random location
    void instantiateEnemy(int theHeight)
    {
        int chance = Random.Range(0, 6);
        if (chance == 0)
        {
            Instantiate(enemy, new Vector2(Random.Range(-4, 4), theHeight), Quaternion.identity);
        }
    }

}
