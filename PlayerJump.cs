using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {
    public GameObject player;
    bool touching = true;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = player.GetComponent<Rigidbody2D>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
            touching = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
            touching = false;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && touching)
            rb.AddForce(new Vector2(0, PlayerMove.jumpHeight));
    }
}
