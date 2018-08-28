using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardCore : MonoBehaviour {

    public GameObject[] platforms = new GameObject[6];
    int height = 2;

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        MainMenuControl.gameMode = "Hardcore";
        for (int i = 0; i < 10; i++)
        {
            instantiateRandom();
        }
    }



    // Update is called once per frame
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

    void instantiateEnemy(int theHeight)
    {
        int chance = Random.Range(0, 6);
        if (chance == 0)
        {
            Instantiate(enemy, new Vector2(Random.Range(-4, 4), theHeight), Quaternion.identity);
        }
    }

}
