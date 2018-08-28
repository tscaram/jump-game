using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeftMove : MonoBehaviour {

    float speed;
    
    //initializing speed and telling the bullet to start the selfdestruct coroutine
    void Start()
    {
        speed = 0.1f;
        StartCoroutine(selfDestruct());
    }

    //Once per frame, translate the bullet to the left
    void FixedUpdate()
    {

        if (Time.timeScale != 0)
            transform.Translate(Vector2.left * speed);

    }

    //Tells the bullet to self destruct if it hasn't hit anything in 3 seconds
    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
