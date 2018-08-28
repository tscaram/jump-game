using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour {

    
    //if you hit lava or an enemy, you lose and it loads the losing scene

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava") || collision.gameObject.CompareTag("Enemy"))
        {
            die();
        }
    }

    private void die()
    {
        SceneManager.LoadScene("DeathScene");
    }
}
