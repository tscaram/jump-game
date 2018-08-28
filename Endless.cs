using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endless : MonoBehaviour
{

    public GameObject[] platforms = new GameObject[5];
    int height = 2;
    // Use this for initialization
    void Start()
    {
        MainMenuControl.gameMode = "Endless";  
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

}
