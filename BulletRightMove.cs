using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRightMove : MonoBehaviour {

    /*This does the same as the BulletLeftMove script, but goes to the right instead.
      These scripts are for the hardcore mode where enemies shoot at you.
     */
	
    float speed;


    void Start () {
        speed = 0.1f;
        StartCoroutine(selfDestruct());
    }
	

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
