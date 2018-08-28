using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : MonoBehaviour {

    Rigidbody2D rb;
    public Text startingText;
    public int moveSpeed;
    public static int jumpHeight = 999;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
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
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }
}
