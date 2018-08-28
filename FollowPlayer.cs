using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public int offset;
    public int offsetZ;
    public GameObject player;
    public Transform self;

	// Use this for initialization
	void Start () {
        self = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        self.position = new Vector3(offset, player.transform.position.y, offsetZ);


	}
}
