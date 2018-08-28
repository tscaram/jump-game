using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls how the player is allowed to jump

public class PlayerJump : MonoBehaviour {

    public GameObject player;
    bool touching = true;
    Rigidbody2D rb;
	
    // Gets the rigidbody component of the player so that physics can be applied
    void Start () {
        rb = player.GetComponent<Rigidbody2D>();
    }

    //there is an invisible collider on the player that detects what's directly below the player. If the player is colliding with a 
    //platform underneath, the player can jump
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
            touching = true;
    }

    //When the platform exits the invisible collider, the player can no longer jump
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
            touching = false;
    }

    // If the player is touching a platform and they press space, add the jump force to the character
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && touching)
            rb.AddForce(new Vector2(0, PlayerMove.jumpHeight));
    }
}
