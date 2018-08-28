using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Allows the player to move left and right

public class PlayerMove : MonoBehaviour {

    //Sets up the variables, including text that tells the player to press p to start and gets the move speed declared in the unity editor
	
    Rigidbody2D rb;
    public Text startingText;
    public int moveSpeed;
    public static int jumpHeight = 999;
	
    // grabs the rigidbody component of the player and allows force to be added to it, and freezes time
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))	//Starts the game when the player presses p. If the game is already going, pause it
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                if (startingText.text != null)
                    startingText.text = null;
            }
            else
            {
                startingText.text = "Paused. Press P to continue.";
                Time.timeScale = 0;
            }
        }
    }
    private void FixedUpdate()	//move the player left or right depending on what they press. The controls are specified within the unity editor
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }
}
