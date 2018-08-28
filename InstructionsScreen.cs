using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsScreen : MonoBehaviour {
    //if you press the main menu button on the screen, it takes you to the main menu
    
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
