using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour {

    


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
