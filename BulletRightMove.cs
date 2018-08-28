using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRightMove : MonoBehaviour {

    float speed;

	// Use this for initialization
	void Start () {
        speed = 0.1f;
        StartCoroutine(selfDestruct());
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Time.timeScale != 0)
            transform.Translate(Vector2.right * speed);
        
	}

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
