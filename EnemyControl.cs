using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls how the enemies act

public class EnemyControl : MonoBehaviour {

    
    GameObject player;

    public GameObject bulletLeft;
    public GameObject bulletRight;


    bool playerToRight;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");    //make the enemy recognize the player
        StartCoroutine(controller());       //starts infinite loop that allows the enemies to target the player
    }

    //every frame, decide whether the player is on the left and the right. if the player is more than 10 height above the enemy,
    //destroy that enemy
    void Update()
    {
        if (player.transform.position.x > transform.position.x)
        {
            playerToRight = true;
        }
        else
            playerToRight = false;

        if (player.transform.position.y - transform.position.y > 10)
            Destroy(gameObject);

    }

    //if the player is to the right, shoot the lava to the right. otherwise shoot the lava to the left.
    
    void shoot(bool toRight)
    {
        if (toRight)
        {
            Instantiate(bulletRight, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        else
            Instantiate(bulletLeft, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }

    //every three seconds, shoot lava
    IEnumerator controller()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            shoot(playerToRight);
        }
    }
}
