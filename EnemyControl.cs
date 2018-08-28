using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    GameObject player;

    public GameObject bulletLeft;
    public GameObject bulletRight;


    bool playerToRight;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(controller());
    }

    // Update is called once per frame
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

    void shoot(bool toRight)
    {
        if (toRight)
        {
            Instantiate(bulletRight, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        else
            Instantiate(bulletLeft, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }

    IEnumerator controller()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            shoot(playerToRight);
        }
    }
}
