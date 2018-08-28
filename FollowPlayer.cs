using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make the camera follow the player as it moves up.

public class FollowPlayer : MonoBehaviour {

    public int offset;
    public int offsetZ;
    public GameObject player;
    public Transform self;

	// Use this for initialization
	void Start () {
            self = GetComponent<Transform>();
	}
	
	// Once per frame, set the camera equal to the y position of the player, while locking the x and z positions
	void Update () {
            self.position = new Vector3(offset, player.transform.position.y, offsetZ);


	}
}
